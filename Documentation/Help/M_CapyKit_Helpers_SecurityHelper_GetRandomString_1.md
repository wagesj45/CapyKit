# GetRandomString(Int32, ValidCharacterCollection[]) Method


Gets a cryptographically strong random string using the character values found in [!:VALID_CHARACTERS].



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public static string GetRandomString(
	int length,
	params ValidCharacterCollection[] validChars
)
```
**F#**
``` F#
static member GetRandomString : 
        length : int * 
        validChars : ValidCharacterCollection[] -> string 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.int32" target="_blank" rel="noopener noreferrer">Int32</a></dt><dd>The length of the string to create.</dd><dt>  <a href="T_CapyKit_Helpers_ValidCharacterCollection">ValidCharacterCollection</a>[]</dt><dd>\[Missing &lt;param name="validChars"/&gt; documentation for "M:CapyKit.Helpers.SecurityHelper.GetRandomString(System.Int32,CapyKit.Helpers.ValidCharacterCollection[])"\]</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
The random string.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper">SecurityHelper Class</a>  
<a href="Overload_CapyKit_Helpers_SecurityHelper_GetRandomString">GetRandomString Overload</a>  
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  
