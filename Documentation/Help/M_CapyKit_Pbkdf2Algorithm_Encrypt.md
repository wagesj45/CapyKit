# Encrypt Method


Encrypts the given password using a PBKDF2 algorithm.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public byte[] Encrypt(
	string password,
	params Object[] args
)
```
**F#**
``` F#
abstract Encrypt : 
        password : string * 
        args : Object[] -> byte[] 
override Encrypt : 
        password : string * 
        args : Object[] -> byte[] 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The plaintext password.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Additional arguments for the encryption process, specifically <ol><li><code>salt</code></li><li><code>length</code></li><li><code>iterations</code></li></ol>

</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]  
A byte array with the hashed *password*.

#### Implements
<a href="M_CapyKit_IPasswordAlgorithm_Encrypt">IPasswordAlgorithm.Encrypt(String, Object[])</a>  


## See Also


#### Reference
<a href="T_CapyKit_Pbkdf2Algorithm">Pbkdf2Algorithm Class</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
