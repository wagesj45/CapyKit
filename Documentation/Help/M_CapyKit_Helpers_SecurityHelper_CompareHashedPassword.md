# CompareHashedPassword Method


Compares an unencrypted *providedPassword* with a stored, encrypted *existingPassword*.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static bool CompareHashedPassword(
	string providedPassword,
	string existingPassword
)
```
**VB**
``` VB
Public Shared Function CompareHashedPassword ( 
	providedPassword As String,
	existingPassword As String
) As Boolean
```
**C++**
``` C++
public:
static bool CompareHashedPassword(
	String^ providedPassword, 
	String^ existingPassword
)
```
**F#**
``` F#
static member CompareHashedPassword : 
        providedPassword : string * 
        existingPassword : string -> bool 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The provided password, unencrypted.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The existing, encrypted password.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if hash comparison succeeds, false if it fails.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
