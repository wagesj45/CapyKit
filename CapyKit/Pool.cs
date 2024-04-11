using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapyKit
{
    /// <summary>
    /// A managed pool of resources. This class provides a thread-safe way to manage a collection of
    /// objects of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T"> The type of objects to be managed by the pool. </typeparam>
    public class Pool<T>
    {
        #region Members

        /// <summary> The collection of pooled items. </summary>
        private readonly ConcurrentBag<PoolItem<T>> poolItemCollection;

        /// <summary> (Immutable) The number of items in the pool. </summary>
        private readonly int poolSize;

        #endregion Members

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Pool{T}"/> class with the specified pool size.
        /// </summary>
        /// <param name="poolSize"> The size of the pool. </param>
        public Pool(int poolSize)
        {
            this.poolSize = poolSize;
            this.poolItemCollection = new ConcurrentBag<PoolItem<T>>();
            FillPoolItemCollection(poolSize);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pool{T}"/> class with the specified pool size
        /// and constructor selector.
        /// </summary>
        /// <param name="poolSize">            The size of the pool. </param>
        /// <param name="constructorSelector">
        ///     The constructor selector used to create new instances of <typeparamref name="T"/>.
        /// </param>
        public Pool(int poolSize, Func<T> constructorSelector)
        {
            this.poolSize = poolSize;
            this.poolItemCollection = new ConcurrentBag<PoolItem<T>>();
            FillPoolItemCollection(poolSize, constructorSelector);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pool{T}"/> class with the specified collection
        /// of items.
        /// </summary>
        /// <param name="collection">
        ///     The collection of <typeparamref name="T"/> items with which to seed the pool.
        /// </param>
        public Pool(IEnumerable<T> collection)
        {
            this.poolSize = collection.Count();
            this.poolItemCollection = new ConcurrentBag<PoolItem<T>>();
            FillPoolItemCollection(collection);
        }

        #endregion Constructors

        #region Methods

        /// <summary>
        /// Initializes the pool with the specified number of items using the default constructor.
        /// </summary>
        /// <param name="poolSize"> The size of the pool. </param>
        private void FillPoolItemCollection(int poolSize)
        {
            FillPoolItemCollection(poolSize, () => default(T));
        }

        /// <summary>
        /// Initializes the pool with the specified number of items using the specified constructor
        /// selector.
        /// </summary>
        /// <param name="poolSize">            The size of the pool. </param>
        /// <param name="constructorSelector"> The constructor selector. </param>
        private void FillPoolItemCollection(int poolSize, Func<T> constructorSelector)
        {
            for (int i = 0; i < poolSize; i++)
            {
                this.poolItemCollection.Add(new PoolItem<T>(constructorSelector(), i));
            }
        }

        /// <summary> Fill the pool item collection from an existing <typeparamref name="T"/> collection. </summary>
        /// <param name="collection"> The <typeparamref name="T"/> collection. </param>
        private void FillPoolItemCollection(IEnumerable<T> collection)
        {
            int index = 0;
            foreach (var item in collection)
            {
                this.poolItemCollection.Add(new PoolItem<T>(item, index++));
            }
        }

        /// <summary> Gets the first available item from the pool and sets its lock. </summary>
        /// <returns> The first available item from the pool. </returns>
        public PoolItem<T> GetAvailableItem()
        {
            lock (this.poolItemCollection)
            {
                if (this.poolItemCollection.Any(item => !item.Locked))
                {
                    var firstAvailableItem = this.poolItemCollection.First(item => !item.Locked);
                    firstAvailableItem.SetLock();

                    CapyEventReporter.EmitEvent(EventLevel.Debug, "Accessed ppol and retrieved {0}", args: new[] { firstAvailableItem });

                    return firstAvailableItem;
                }
            }

            CapyEventReporter.EmitEvent(EventLevel.Error, "Could not return an available item.");
            return null;
        }

        /// <summary> Releases the lock on the specified item and returns it to the pool. </summary>
        /// <remarks>
        /// This method sets the <see cref="PoolItem{T}.Locked"/> flag to <see langword="false"/> so that
        /// it can be retrieved by <see cref="Pool{T}.GetAvailableItem"/>.
        /// </remarks>
        /// <param name="item"> The item to release. </param>
        public void ReleaseItem(PoolItem<T> item)
        {
            item.ReleaseLock();
        }

        #endregion Methods
    }

    /// <summary> A pool item. This class cannot be inherited. </summary>
    /// <typeparam name="T"> The type of the pooled item. </typeparam>
    public sealed class PoolItem<T>
    {
        #region Members

        /// <summary> The pooled item. </summary>
        private readonly T item;

        /// <summary> A flag indicating whether the item is locked or not. </summary>
        private bool locked;

        /// <summary> The zero-based index of the pooled item. </summary>
        private readonly int index;

        /// <summary> The name of the pooled item <see cref="Type"/>. </summary>
        private readonly string typeName;

        #endregion Members

        #region Properties

        /// <summary> Gets the pooled resource. </summary>
        /// <value> The pooled resource. </value>
        public T Item
        {
            get
            {
                return this.item;
            }
        }

        /// <summary> Gets a value indicating whether this object is locked or not. </summary>
        /// <value> A value indicating whether this object is locked or not. </value>
        public bool Locked
        {
            get
            {
                return this.locked;
            }
        }

        /// <summary> Gets the zero-based index of the pooled item. </summary>
        /// <value> The index. </value>
        public int Index
        {
            get
            {
                return this.index;
            }
        }

        /// <summary> Gets the name of the <see cref="Type"/> of the pooled item. </summary>
        /// <value> The name of the <see cref="Type"/> of the pooled item. </value>
        public string TypeName
        {
            get
            {
                return this.typeName;
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PoolItem{T}"/> class with the specified item and
        /// index.
        /// </summary>
        /// <param name="item">  The pooled item. </param>
        /// <param name="index"> The zero-based index of the pooled item. </param>
        internal PoolItem(T item, int index)
        {
            this.item = item;
            this.index = index;
            this.locked = false;
            this.typeName = typeof(T).Name;
        }

        #endregion Constructors

        #region Methods

        /// <summary> Sets the lock on the item indicating that it is in use. </summary>
        /// <remarks> If the item is already locked, an error event is emitted. </remarks>
        /// <returns>
        /// <see langword="true"/> if the item is locked successfully, <see langword="false"/> if it
        /// fails.
        /// </returns>
        public bool SetLock()
        {
            if (this.locked)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Lock requested for {0}, but the lock request failed.", args: new[] { this });
                return false;
            }

            this.locked = true;

            return true;
        }

        /// <summary> Releases the lock on the item. </summary>
        /// <remarks> If the item is not locked, an error event is emitted. </remarks>
        public void ReleaseLock()
        {
            if (!this.locked)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Lock release requested for {0}, but the lock was already released.", args: new[] { this } );
            }

            this.locked = false;
        }

        #endregion Methods

        #region Overrides

        /// <summary> Returns a string that represents the current object and its lock state. </summary>
        /// <returns> A string that represents the current object and its lock state. </returns>
        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", this.typeName, this.index, this.locked ? "Locked" : "Unlocked");
        }

        #endregion Overrides
    }
}
