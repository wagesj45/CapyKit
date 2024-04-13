using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Extensions
{
    /// <summary>  Provides static extension methods for performing common LINQ operations on <see cref="IEnumerable{T}"/> and <see cref="IQueryable{T}"/> collections. </summary>
    public static class LINQExtensions
    {
        /// <summary>
        /// Filters out items matching a <paramref name="predicate"/> from the collection.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">    The source to act on. </param>
        /// <param name="predicate"> The predicate. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process remove in this collection.
        /// </returns>
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.Where(item => !predicate(item));
        }

        /// <summary>
        /// Filters out items matching a <paramref name="predicate"/> from the collection.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">    The source to act on. </param>
        /// <param name="predicate"> The predicate. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process remove in this collection.
        /// </returns>
        public static IQueryable<T> Filter<T>(this IQueryable<T> source, System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            if(predicate.Parameters.Count > 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Warning, "More than one parameter was found in the predicate, which could result in unexpected behavior.");
            }

            var parameter = predicate.Parameters.FirstOrDefault();
            var negatedPredicate = Expression.Not(predicate);
            var lamda = Expression.Lambda<Func<T, bool>>(negatedPredicate, parameter);

            return source.Where(lamda);
        }

        /// <summary>
        /// Get a page of items from a collection, skipping <paramref name="pageNumber"/> pages of
        /// <paramref name="pageSize"/> items per page.
        /// </summary>
        /// <remarks> This method uses natural numbering starting at page 1. </remarks>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when <paramref name="pageNumber"/> is less than <c>1</c> or if
        ///     <paramref name="pageSize"/> is less than
        ///     <c>1</c>.
        /// </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">     The source to act on. </param>
        /// <param name="pageNumber"> The page number to retrieve. </param>
        /// <param name="pageSize">   Number of items per page. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process page in this collection.
        /// </returns>
        public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageNumber is out of range. [{0}]", args: new[] { pageNumber });
                throw new ArgumentOutOfRangeException("pageNumber");
            }

            if (pageSize < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageSize is out of range. [{0}]", args: new[] { pageSize });
                throw new ArgumentOutOfRangeException("pageSize");
            }

            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        /// <summary>
        /// Get a page of items from a collection, skipping <paramref name="pageNumber"/> pages of
        /// <paramref name="pageSize"/> items per page.
        /// </summary>
        /// <remarks> This method uses natural numbering starting at page 1. </remarks>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when <paramref name="pageNumber"/> is less than <c>1</c> or if
        ///     <paramref name="pageSize"/> is less than
        ///     <c>1</c>.
        /// </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">     The source to act on. </param>
        /// <param name="pageNumber"> The page number to retrieve. </param>
        /// <param name="pageSize">   . </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process page in this collection.
        /// </returns>
        public static IQueryable<T> Page<T>(this IQueryable<T> source, int pageNumber, int pageSize)
        {
            if (pageNumber < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageNumber is out of range. [{0}]", args: new[] { pageNumber });
                throw new ArgumentOutOfRangeException("pageNumber");
            }

            if (pageSize < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageSize is out of range. [{0}]", args: new[] { pageSize });
                throw new ArgumentOutOfRangeException("pageSize");
            }

            return source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
        }

        /// <summary>
        /// The number of pages of <paramref name="pageSize"/> size in the given collection.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when <paramref name="pageSize"/> is less than <c>1</c>.
        /// </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">   The source to act on. </param>
        /// <param name="pageSize"> Size of the page. </param>
        /// <returns> An int. </returns>
        public static int PageCount<T>(this IEnumerable<T> source, int pageSize)
        {
            if (pageSize < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageSize is out of range. [{0}]", args: new[] { pageSize });
                throw new ArgumentOutOfRangeException("pageSize");
            }

            var ceiling = Math.Ceiling(Convert.ToDouble(source.Count()) / pageSize);
            return Convert.ToInt32(ceiling);
        }

        /// <summary>
        /// The number of pages of <paramref name="pageSize"/> size in the given collection.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     Thrown when <paramref name="pageSize"/> is less than <c>1</c>.
        /// </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="source">   The source to act on. </param>
        /// <param name="pageSize"> Size of the page. </param>
        /// <returns> An int. </returns>
        public static int PageCount<T>(this IQueryable<T> source, int pageSize)
        {
            if (pageSize < 1)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "pageSize is out of range. [{0}]", args: new[] { pageSize });
                throw new ArgumentOutOfRangeException("pageSize");
            }

            var ceiling = Math.Ceiling(Convert.ToDouble(source.Count()) / pageSize);
            return Convert.ToInt32(ceiling);
        }

        /// <summary> An IQueryable&lt;T&gt; extension method that left outer join. </summary>
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <typeparam name="U">    Generic type parameter. </typeparam>
        /// <typeparam name="TKey"> Type of the key. </typeparam>
        /// <typeparam name="R">    Type of the r. </typeparam>
        /// <param name="source">           The source to act on. </param>
        /// <param name="inner">            The inner. </param>
        /// <param name="outerSelector">    The outer selector. </param>
        /// <param name="innerSelector">    The inner selector. </param>
        /// <param name="resultSelector">   The result selector. </param>
        /// <param name="defaultGenerator"> (Optional) The default generator. </param>
        /// <returns> An IQueryable&lt;R&gt; </returns>
        public static IQueryable<R> LeftOuterJoin<T, U, TKey, R>(this IQueryable<T> source, IQueryable<U> inner, Expression<Func<T, TKey>> outerSelector, Expression<Func<U, TKey>> innerSelector, Func<T, IEnumerable<U>, R> resultSelector, Func<T, U> defaultGenerator = null)
        {
            Func<T, IEnumerable<U>, R> resultOrDefaultSelector = (i, o) =>
            {
                if (defaultGenerator == null)
                {
                    defaultGenerator = (t) => default(U);
                }

                if (!o.Any())
                {
                    return resultSelector(i, new[] { defaultGenerator(i) });
                }

                return resultSelector(i, o);
            };

            return source.LeftOuterJoin(inner, outerSelector, innerSelector, (a, b) => resultSelector(a, b));
        }

        /// <summary> An IQueryable&lt;T&gt; extension method that left outer join. </summary>
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <typeparam name="U">    Generic type parameter. </typeparam>
        /// <typeparam name="TKey"> Type of the key. </typeparam>
        /// <typeparam name="R">    Type of the r. </typeparam>
        /// <param name="source">         The source to act on. </param>
        /// <param name="inner">          The inner. </param>
        /// <param name="outerSelector">  The outer selector. </param>
        /// <param name="innerSelector">  The inner selector. </param>
        /// <param name="resultSelector"> The result selector. </param>
        /// <returns> An IQueryable&lt;R&gt; </returns>
        private static IQueryable<R> LeftOuterJoin<T, U, TKey, R>(this IQueryable<T> source, IQueryable<U> inner, Expression<Func<T, TKey>> outerSelector, Expression<Func<U, TKey>> innerSelector, Expression<Func<T, IEnumerable<U>, R>> resultSelector)
        {
            return source.GroupJoin(inner, outerSelector, innerSelector, resultSelector);
        }

        /// <summary> An IEnumable&lt;T&gt; extension method that left outer join. </summary>
        /// <typeparam name="T">    Generic type parameter. </typeparam>
        /// <typeparam name="U">    Generic type parameter. </typeparam>
        /// <typeparam name="TKey"> Type of the key. </typeparam>
        /// <typeparam name="R">    Type of the r. </typeparam>
        /// <param name="source">           The source to act on. </param>
        /// <param name="inner">            The inner. </param>
        /// <param name="outerSelector">    The outer selector. </param>
        /// <param name="innerSelector">    The inner selector. </param>
        /// <param name="resultSelector">   The result selector. </param>
        /// <param name="defaultGenerator"> (Optional) The default generator. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process left outter join in this collection.
        /// </returns>
        public static IEnumerable<R> LeftOuterJoin<T, U, TKey, R>(this IEnumerable<T> source, IEnumerable<U> inner, Func<T, TKey> outerSelector, Func<U, TKey> innerSelector, Func<T, IEnumerable<U>, R> resultSelector, Func<T, U> defaultGenerator = null)
        {
            var combined = source.GroupJoin(inner, outerSelector, innerSelector, (i, o) => new { inner = i, outer = o });

            if (defaultGenerator == null)
            {
                defaultGenerator = (t) => default(U);
            }

            return combined.Select(anon =>
            {
                if (!anon.outer.Any())
                {
                    return resultSelector(anon.inner, new[] { defaultGenerator(anon.inner) });
                }

                return resultSelector(anon.inner, anon.outer);
            });
        }

        /// <summary>
        /// Enumerates distinct items in this collection as defined by the key <paramref name="property"/>.
        /// </summary>
        /// <typeparam name="T"> Generic type parameter of the parent object. </typeparam>
        /// <typeparam name="U"> Generic type parameter property value. </typeparam>
        /// <param name="items">    The items to act on. </param>
        /// <param name="property"> The property. </param>
        /// <returns>
        /// An enumerator that allows foreach to be used to process distinct items in this collection.
        /// </returns>
        public static IEnumerable<T> Distinct<T, U>(this IEnumerable<T> items, Func<T, U> property)
        {
            var propertyComparer = new PropertyComparer<T, U>(property);
            return items.Distinct(propertyComparer);
        }
    }
}
