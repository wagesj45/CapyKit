# Password Constructor


Constructor.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
internal Password(
	string password,
	byte[] salt,
	IPasswordAlgorithm algorithm,
	params Object[] args
)
```
**F#**
``` F#
new : 
        password : string * 
        salt : byte[] * 
        algorithm : IPasswordAlgorithm * 
        args : Object[] -> Password
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The password to be hashed.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The salt used for encryption.</dd><dt>  <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a></dt><dd>The algorithm used for password encryption.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>A variable-length parameters list containing arguments to include for the <em>algorithm</em>.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_Password.md">Password Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
