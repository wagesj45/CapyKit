# GetRandomPassword Method


Gets a cryptographically strong random password.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public static string GetRandomPassword(
	int length,
	params ValidCharacterCollection[] validCharacters
)
```
**F#**
``` F#
static member GetRandomPassword : 
        length : int * 
        validCharacters : ValidCharacterCollection[] -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The length of the password to generate.</dd><dt>  <a href="T_CapyKit_Helpers_ValidCharacterCollection.md">ValidCharacterCollection</a>[]</dt><dd>\[Missing &lt;param name="validCharacters"/&gt; documentation for "M:CapyKit.Helpers.SecurityHelper.GetRandomPassword(System.Int32,CapyKit.Helpers.ValidCharacterCollection[])"\]</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The password.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
