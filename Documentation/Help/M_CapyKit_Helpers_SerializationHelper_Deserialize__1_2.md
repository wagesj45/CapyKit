# Deserialize&lt;T&gt;(String) Method


Deserializes a `JSON` encoded string to the given *T*.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static T Deserialize<T>(
	string str
)

```
**VB**
``` VB
Public Shared Function Deserialize(Of T) ( 
	str As String
) As T
```
**C++**
``` C++
public:
generic<typename T>
static T Deserialize(
	String^ str
)
```
**F#**
``` F#
static member Deserialize : 
        str : string -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The <code>JSON</code> encoded string representing a <em>T</em> object.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
T  
A *T* object.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SerializationHelper">SerializationHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SerializationHelper_Deserialize">Deserialize Overload</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
