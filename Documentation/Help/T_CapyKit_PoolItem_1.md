# PoolItem&lt;T&gt; Class


A pool item. This class cannot be inherited.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public sealed class PoolItem<T>

```
**F#**
``` F#
[<SealedAttribute>]
type PoolItem<'T> = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  PoolItem(T)</td></tr>
</table>



#### Type Parameters
<dl><dt /><dd>The type of the pooled item.</dd></dl>

## Constructors
<table>
<tr>
<td><a href="M_CapyKit_PoolItem_1__ctor.md">PoolItem(T)</a></td>
<td>Initializes a new instance of the PoolItem(T) class with the specified item and index.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Index.md">Index</a></td>
<td>Gets the zero-based index of the pooled item.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Item.md">Item</a></td>
<td>Gets the pooled resource.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Locked.md">Locked</a></td>
<td>Gets a value indicating whether this object is locked or not.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_TypeName.md">TypeName</a></td>
<td>Gets the name of the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the pooled item.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
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
<td><a href="M_CapyKit_PoolItem_1_ReleaseLock.md">ReleaseLock</a></td>
<td>Releases the lock on the item.</td></tr>
<tr>
<td><a href="M_CapyKit_PoolItem_1_SetLock.md">SetLock</a></td>
<td>Sets the lock on the item indicating that it is in use.</td></tr>
<tr>
<td><a href="M_CapyKit_PoolItem_1_ToString.md">ToString</a></td>
<td>Returns a string that represents the current object and its lock state.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">Object.ToString()</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_PoolItem_1_index.md">index</a></td>
<td>The zero-based index of the pooled item.</td></tr>
<tr>
<td><a href="F_CapyKit_PoolItem_1_item.md">item</a></td>
<td>The pooled item.</td></tr>
<tr>
<td><a href="F_CapyKit_PoolItem_1_locked.md">locked</a></td>
<td>A flag indicating whether the item is locked or not.</td></tr>
<tr>
<td><a href="F_CapyKit_PoolItem_1_typeName.md">typeName</a></td>
<td>The name of the pooled item <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a>.</td></tr>
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
