# CompressionHelper Class


A class that contains methods for managing data compression.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static class CompressionHelper
```
**F#**
``` F#
[<AbstractClassAttribute>]
[<SealedAttribute>]
type CompressionHelper = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  CompressionHelper</td></tr>
</table>



## Methods
<table>
<tr>
<td><a href="M_CapyKit_Helpers_CompressionHelper_Compress.md">Compress</a></td>
<td>Compresses a given object using the <code>gzip</code> algorithm.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_CompressionHelper_CompressToString.md">CompressToString</a></td>
<td>Compresses a given object to a string using <code>base64</code> encoding of <code>gzip</code> format.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_CompressionHelper_Decompress__1.md">Decompress(T)(Byte[])</a></td>
<td>Decompresses a given compressed <code>gzip</code> byte stream.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_CompressionHelper_Decompress__1_1.md">Decompress(T)(String)</a></td>
<td>Decompresses a given <code>base64</code> encoded string of <code>gzip</code> format.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_CompressionHelper_DecompressToString.md">DecompressToString</a></td>
<td>Decompresses the given <code>base64</code> string in <code>gzip</code> format.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
