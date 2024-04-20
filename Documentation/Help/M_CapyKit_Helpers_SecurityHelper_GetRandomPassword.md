# GetRandomPassword Method


Gets a cryptographically strong random password.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public static string GetRandomPassword(
	int length
)
```
**VB**
``` VB
Public Shared Function GetRandomPassword ( 
	length As Integer
) As String
```
**C++**
``` C++
public:
static String^ GetRandomPassword(
	int length
)
```
**F#**
``` F#
static member GetRandomPassword : 
        length : int -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The length of the password to generate.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The password.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
