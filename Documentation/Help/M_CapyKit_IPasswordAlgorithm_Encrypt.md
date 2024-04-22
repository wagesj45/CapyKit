# Encrypt Method


Encrypts the given password using a defined algorithm.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
byte[] Encrypt(
	string password,
	params Object[] args
)
```
**F#**
``` F#
abstract Encrypt : 
        password : string * 
        args : Object[] -> byte[] 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The plaintext password.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Additional arguments for the encryption process, such as salt and length.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]  
A byte array with the hashed *password*.

## See Also


#### Reference
<a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm Interface</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
