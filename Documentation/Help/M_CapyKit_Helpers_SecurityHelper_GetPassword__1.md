# GetPassword&lt;T&gt;(String, Byte[], Object[]) Method


Retrieves a <a href="T_CapyKit_Password.md">Password</a> object using the specified password, salt, and optional constructor arguments.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static Password GetPassword<T>(
	string password,
	byte[] salt,
	params Object[] args
)
where T : IPasswordAlgorithm

```
**F#**
``` F#
static member GetPassword : 
        password : string * 
        salt : byte[] * 
        args : Object[] -> Password  when 'T : IPasswordAlgorithm
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The plaintext password to be hashed.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>A random value used as an additional input to the one-way function that hashes data, a password or passphrase. This is used to make each output different for the same input thus adding security.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Optional constructor arguments for the <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a> implementation instance.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of <a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a> implementation to use.</dd></dl>

#### Return Value
<a href="T_CapyKit_Password.md">Password</a>  
A new <a href="T_CapyKit_Password.md">Password</a> object with the given password and salt, as well as an instance of *T* created using the provided constructor arguments.

## Remarks
This method uses reflection to find a constructor for the specified password algorithm type (*T*). It emits an error event if a suitable constructor is not found or if there is an error invoking the constructor.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_GetPassword.md">GetPassword Overload</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
