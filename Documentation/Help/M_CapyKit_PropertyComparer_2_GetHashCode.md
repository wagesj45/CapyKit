# GetHashCode(T) Method


Returns a hash code for the specified object.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public int GetHashCode(
	T obj
)
```
**F#**
``` F#
abstract GetHashCode : 
        obj : 'T -> int 
override GetHashCode : 
        obj : 'T -> int 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_PropertyComparer_2">T</a></dt><dd>The <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a> for which a hash code is to be returned.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>  
A hash code for the specified object.

#### Implements
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.iequalitycomparer-1.gethashcode" target="_blank" rel="noopener noreferrer">IEqualityComparer(T).GetHashCode(T)</a>  


## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td>The type of <em>obj</em> is a reference type and <em>obj</em> is null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_PropertyComparer_2">PropertyComparer(T, U) Class</a>  
<a href="Overload_CapyKit_PropertyComparer_2_GetHashCode">GetHashCode Overload</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
