# GetPassword&lt;T&gt;(String, Object[]) Method


Retrieves a <a href="T_CapyKit_Password.md">Password</a> object using the specified password and generates a random salt value. Then it uses that salt to call the overloaded <a href="M_CapyKit_Helpers_SecurityHelper_GetPassword__1.md">GetPassword(T)(String, Byte[], Object[])</a> method with the given password and the generated salt as arguments.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static Password GetPassword<T>(
	string password,
	params Object[] args
)

```
**F#**
``` F#
static member GetPassword : 
        password : string * 
        args : Object[] -> Password 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The plaintext password to be hashed.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Optional constructor arguments for the <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a> implementation instance.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a> implementation to use.</dd></dl>

#### Return Value
<a href="T_CapyKit_Password.md">Password</a>  
A new <a href="T_CapyKit_Password.md">Password</a> object with the given password and a randomly generated salt, as well as an instance of *T* created using any optional constructor arguments provided.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_GetPassword.md">GetPassword Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
<a href="F_CapyKit_Helpers_SecurityHelper_SALT_SIZE.md">SALT_SIZE</a>  
