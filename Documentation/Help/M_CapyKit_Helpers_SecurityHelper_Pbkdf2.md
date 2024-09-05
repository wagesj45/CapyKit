# Pbkdf2(String) Method


Generates a new <a href="T_CapyKit_Password.md">Password</a> object using the PBKDF2 algorithm with the provided *password*. This overload of the method generates a random salt value for added security.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static Password Pbkdf2(
	string password
)
```
**F#**
``` F#
static member Pbkdf2 : 
        password : string -> Password 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The clear text password to be hashed.</dd></dl>

#### Return Value
<a href="T_CapyKit_Password.md">Password</a>  
A new <a href="T_CapyKit_Password.md">Password</a> object containing the hashed password and a randomly generated salt.

## Remarks
This method uses the PBKDF2 (Password-Based Key Derivation Function 2) algorithm to generate a new password hash. The algorithm iteratively applies a pseudorandom function to the password and salt, which increases the security of the resulting hash. In this overload, a random salt value is generated using <a href="M_CapyKit_Helpers_SecurityHelper_GetRandomBytes.md">GetRandomBytes(Int32)</a> method.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_Pbkdf2.md">Pbkdf2 Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
