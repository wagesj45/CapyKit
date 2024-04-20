# CompressToString Method


Compresses a given object to a string using `base64` encoding of `gzip` format.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static string CompressToString(
	Object obj
)
```
**VB**
``` VB
Public Shared Function CompressToString ( 
	obj As Object
) As String
```
**C++**
``` C++
public:
static String^ CompressToString(
	Object^ obj
)
```
**F#**
``` F#
static member CompressToString : 
        obj : Object -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a></dt><dd>The object.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A string in `base64` encoding.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_CompressionHelper">CompressionHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
