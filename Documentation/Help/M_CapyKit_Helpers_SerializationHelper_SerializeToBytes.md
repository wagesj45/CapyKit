# SerializeToBytes Method


Serializes an object to a byte array.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static byte[] SerializeToBytes(
	Object obj
)
```
**VB**
``` VB
Public Shared Function SerializeToBytes ( 
	obj As Object
) As Byte()
```
**C++**
``` C++
public:
static array<unsigned char>^ SerializeToBytes(
	Object^ obj
)
```
**F#**
``` F#
static member SerializeToBytes : 
        obj : Object -> byte[] 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a></dt><dd>The object.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]  
A `JSON` encoded string.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SerializationHelper">SerializationHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
