# CalculateHash Method


Calculates the hash of a given string using an <a href="https://learn.microsoft.com/dotnet/api/system.security.cryptography.md5" target="_blank" rel="noopener noreferrer">MD5</a> value as the first 32 bits.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static int CalculateHash(
	string str
)
```
**F#**
``` F#
static member CalculateHash : 
        str : string -> int 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The string to be hashed.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a>  
The calculated hash.

## Remarks
This method is used for a quick and consistent hash function. It should not be considered cryptographically sound or used in security contexts.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_CalculationHelper.md">CalculationHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
