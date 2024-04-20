# Compare Method


Compares the given plaintext password with an encrypted value using PBKDF2 algorithm.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
bool Compare(
	string password,
	byte[] encryptedValue,
	params Object[] args
)
```
**VB**
``` VB
Function Compare ( 
	password As String,
	encryptedValue As Byte(),
	ParamArray args As Object()
) As Boolean
```
**C++**
``` C++
bool Compare(
	String^ password, 
	array<unsigned char>^ encryptedValue, 
	... array<Object^>^ args
)
```
**F#**
``` F#
abstract Compare : 
        password : string * 
        encryptedValue : byte[] * 
        args : Object[] -> bool 
override Compare : 
        password : string * 
        encryptedValue : byte[] * 
        args : Object[] -> bool 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The plaintext password to compare.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.byte" target="_blank" rel="noopener noreferrer">Byte</a>[]</dt><dd>The encrypted value to compare against.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>[]</dt><dd>Additional arguments for the encryption process, such as salt and length.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
True if the given *password* matches the *encryptedValue*, false if they are different.

## See Also


#### Reference
<a href="T_CapyKit_IPasswordAlgorithm">IPasswordAlgorithm Interface</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
