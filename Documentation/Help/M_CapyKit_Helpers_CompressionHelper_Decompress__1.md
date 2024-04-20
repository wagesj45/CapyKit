# Decompress&lt;T&gt;(Byte[]) Method


Decompresses a given compressed `gzip` byte stream.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static T Decompress<T>(
	byte[] byteStream
)

```
**VB**
``` VB
Public Shared Function Decompress(Of T) ( 
	byteStream As Byte()
) As T
```
**C++**
``` C++
public:
generic<typename T>
static T Decompress(
	array<unsigned char>^ byteStream
)
```
**F#**
``` F#
static member Decompress : 
        byteStream : byte[] -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The compressed byte stream.</dd></dl>

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
