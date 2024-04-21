# Deserialize&lt;T&gt;(Byte[]) Method


Deserializes an object to a given *T* type.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public static T Deserialize<T>(
	byte[] bytes
)

```
**F#**
``` F#
static member Deserialize : 
        bytes : byte[] -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The byte array representing a <em>T</em> object.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
T  
A *T* object.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.formatexception" target="_blank" rel="noopener noreferrer">FormatException</a></td>
<td>Thrown when the format of the byte array is incorrect.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SerializationHelper.md">SerializationHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SerializationHelper_Deserialize.md">Deserialize Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
