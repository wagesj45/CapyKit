# Deserialize&lt;T&gt;(Stream) Method


Deserializes an object to a given *T* type.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static T Deserialize<T>(
	Stream stream
)

```
**VB**
``` VB
Public Shared Function Deserialize(Of T) ( 
	stream As Stream
) As T
```
**C++**
``` C++
public:
generic<typename T>
static T Deserialize(
	Stream^ stream
)
```
**F#**
``` F#
static member Deserialize : 
        stream : Stream -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.io.stream" target="_blank" rel="noopener noreferrer">Stream</a></dt><dd>The steam.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
T  
A *T* object.

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.formatexception" target="_blank" rel="noopener noreferrer">FormatException</a></td>
<td>Thrown when the format of an input is incorrect.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SerializationHelper">SerializationHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SerializationHelper_Deserialize">Deserialize Overload</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
