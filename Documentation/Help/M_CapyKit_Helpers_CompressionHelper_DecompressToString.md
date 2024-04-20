# DecompressToString Method


Decompresses the given `base64` string in `gzip` format.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static string DecompressToString(
	string compressed
)
```
**VB**
``` VB
Public Shared Function DecompressToString ( 
	compressed As String
) As String
```
**C++**
``` C++
public:
static String^ DecompressToString(
	String^ compressed
)
```
**F#**
``` F#
static member DecompressToString : 
        compressed : string -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The compressed string.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A decomressed string.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_CompressionHelper">CompressionHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  