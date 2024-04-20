# SHA256Hash Method


Produces a <a href="https://en.wikipedia.org/wiki/SHA-2">SHA256</a> hash from a given *value*.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static byte[] SHA256Hash(
	string value
)
```
**VB**
``` VB
Public Shared Function SHA256Hash ( 
	value As String
) As Byte()
```
**C++**
``` C++
public:
static array<unsigned char>^ SHA256Hash(
	String^ value
)
```
**F#**
``` F#
static member SHA256Hash : 
        value : string -> byte[] 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The value.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]  
A byte array equal to the SHA256 hash of *value* or an empty array if it fails.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
