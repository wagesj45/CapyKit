# PoolItem&lt;T&gt; Class


A pool item. This class cannot be inherited.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public sealed class PoolItem<T>

```
**VB**
``` VB
Public NotInheritable Class PoolItem(Of T)
```
**C++**
``` C++
generic<typename T>
public ref class PoolItem sealed
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

## Properties
<table>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Index">Index</a></td>
<td>Gets the zero-based index of the pooled item.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Item">Item</a></td>
<td>Gets the pooled resource.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_Locked">Locked</a></td>
<td>Gets a value indicating whether this object is locked or not.</td></tr>
<tr>
<td><a href="P_CapyKit_PoolItem_1_TypeName">TypeName</a></td>
<td>Gets the name of the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the pooled item.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_PoolItem_1_ReleaseLock">ReleaseLock</a></td>
<td>Releases the lock on the item.</td></tr>
<tr>
<td><a href="M_CapyKit_PoolItem_1_SetLock">SetLock</a></td>
<td>Sets the lock on the item indicating that it is in use.</td></tr>
<tr>
<td><a href="M_CapyKit_PoolItem_1_ToString">ToString</a></td>
<td>Returns a string that represents the current object and its lock state.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">Object.ToString()</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit">CapyKit Namespace</a>  
