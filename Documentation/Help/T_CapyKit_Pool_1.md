# Pool&lt;T&gt; Class


A managed pool of resources. This class provides a thread-safe way to manage a collection of objects of type *T*.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public class Pool<T>

```
**F#**
``` F#
type Pool<'T> = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  Pool(T)</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>The type of objects to be managed by the pool.</dd></dl>

## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Pool_1__ctor.md">Pool(T)(IEnumerable(T))</a></td>
<td>Initializes a new instance of the Pool(T) class with the specified collection of items.</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1__ctor_1.md">Pool(T)(Int32)</a></td>
<td>Initializes a new instance of the Pool(T) class with the specified pool size.</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1__ctor_2.md">Pool(T)(Int32, Func(T))</a></td>
<td>Initializes a new instance of the Pool(T) class with the specified pool size and constructor selector.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1_FillPoolItemCollection.md">FillPoolItemCollection(IEnumerable(T))</a></td>
<td>Fill the pool item collection from an existing <em>T</em> collection.</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1_FillPoolItemCollection_1.md">FillPoolItemCollection(Int32)</a></td>
<td>Initializes the pool with the specified number of items using the default constructor.</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1_FillPoolItemCollection_2.md">FillPoolItemCollection(Int32, Func(T))</a></td>
<td>Initializes the pool with the specified number of items using the specified constructor selector.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1_GetAvailableItem.md">GetAvailableItem</a></td>
<td>Gets the first available item from the pool and sets its lock.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Pool_1_ReleaseItem.md">ReleaseItem</a></td>
<td>Releases the lock on the specified item and returns it to the pool.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_Pool_1_poolItemCollection.md">poolItemCollection</a></td>
<td>The collection of pooled items.</td></tr>
<tr>
<td><a href="F_CapyKit_Pool_1_poolSize.md">poolSize</a></td>
<td>(Immutable) The number of items in the pool.</td></tr>
</table>

## Extension Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties</a></td>
<td>An object extension method that updates the properties of a given <em>target</em> object with the values from a given <em>source</em> object.<br />(Defined by <a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
