# GetValidCharacterComposition Method


Static method that returns a valid character composition based on the given ValidCharacterCollection parameters.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
private static string GetValidCharacterComposition(
	params ValidCharacterCollection[] validCharacters
)
```
**F#**
``` F#
private static member GetValidCharacterComposition : 
        validCharacters : ValidCharacterCollection[] -> string 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_Helpers_ValidCharacterCollection.md">ValidCharacterCollection</a>[]</dt><dd>An array of ValidCharacterCollection enumeration values representing the desired character sets.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>  
A string containing all the characters from the specified character sets.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
