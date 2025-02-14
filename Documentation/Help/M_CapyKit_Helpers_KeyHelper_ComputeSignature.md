# ComputeSignature Method


Computes an HMAC-SHA256 over the salt using the master key and truncates it to the same number of bytes as the salt.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
private byte[] ComputeSignature(
	byte[] salt
)
```
**F#**
``` F#
private member ComputeSignature : 
        salt : byte[] -> byte[] 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The salt.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]  
The calculated signature.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_KeyHelper.md">KeyHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
