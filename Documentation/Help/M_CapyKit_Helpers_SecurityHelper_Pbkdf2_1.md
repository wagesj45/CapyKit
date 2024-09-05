# Pbkdf2(String, Byte[]) Method


Generates a new <a href="T_CapyKit_Password.md">Password</a> object using the PBKDF2 algorithm with the provided *password* and *salt*.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static Password Pbkdf2(
	string password,
	byte[] salt
)
```
**F#**
``` F#
static member Pbkdf2 : 
        password : string * 
        salt : byte[] -> Password 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The clear text password to be hashed.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>A random value used to add an additional layer of security to the generated hash.</dd></dl>

#### Return Value
<a href="T_CapyKit_Password.md">Password</a>  
A new <a href="T_CapyKit_Password.md">Password</a> object containing the hashed password and salt.

## Remarks
This method uses the PBKDF2 (Password-Based Key Derivation Function 2) algorithm to generate a new password hash. The algorithm iteratively applies a pseudorandom function to the password and salt, which increases the security of the resulting hash.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_Pbkdf2.md">Pbkdf2 Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
