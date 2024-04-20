# Encrypt Method


Encrypts the given password using a defined algorithm.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
byte[] Encrypt(
	string password,
	params Object[] args
)
```
**VB**
``` VB
Function Encrypt ( 
	password As String,
	ParamArray args As Object()
) As Byte()
```
**C++**
``` C++
array<unsigned char>^ Encrypt(
	String^ password, 
	... array<Object^>^ args
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
<a href="T_CapyKit_IPasswordAlgorithm">IPasswordAlgorithm Interface</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
