# CompareHashedPassword(Password, String, Byte[], IPasswordAlgorithm, Object[]) Method


Compares an unencrypted *password* with a stored, encrypted *existingPassword*. This method uses the specified *algorithm* to retrieve the hashed version of the *password* and then compares it with the *existingPassword*.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static bool CompareHashedPassword(
	Password existingPassword,
	string password,
	byte[] salt,
	IPasswordAlgorithm algorithm,
	params Object[] args
)
```
**F#**
``` F#
static member CompareHashedPassword : 
        existingPassword : Password * 
        password : string * 
        salt : byte[] * 
        algorithm : IPasswordAlgorithm * 
        args : Object[] -> bool 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_Password.md">Password</a></dt><dd>The existing, encrypted password.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The unencrypted password to be compared.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The salt value used in password hashing.</dd><dt>  <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a></dt><dd>The password hashing algorithm.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Additional arguments required for constructing the password algorithm instance.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if hash comparison succeeds, false if it fails.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_CompareHashedPassword.md">CompareHashedPassword Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
