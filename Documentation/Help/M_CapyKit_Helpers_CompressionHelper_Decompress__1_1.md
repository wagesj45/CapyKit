# Decompress&lt;T&gt;(String) Method


Decompresses a given `base64` encoded string of `gzip` format.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static T Decompress<T>(
	string encodedString
)

```
**VB**
``` VB
Public Shared Function Decompress(Of T) ( 
	encodedString As String
) As T
```
**C++**
``` C++
public:
generic<typename T>
static T Decompress(
	String^ encodedString
)
```
**F#**
``` F#
static member Decompress : 
        encodedString : string -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The <code>base64</code> encoded <code>gzip</code> string.</dd></dl>

#### Type Parameters
<dl><dt /><dd>Generic type parameter.</dd></dl>

#### Return Value
T  
A *T* typed object.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_CompressionHelper">CompressionHelper Class</a>  
<a href="Overload_CapyKit_Helpers_CompressionHelper_Decompress">Decompress Overload</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  