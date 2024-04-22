# CompareStrings Method


Compare two strings as case sensative.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
private static bool CompareStrings(
	string first,
	string second
)
```
**F#**
``` F#
private static member CompareStrings : 
        first : string * 
        second : string -> bool 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The first string.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The second string.</dd></dl>

#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if the comparison succeeds, false if not.

## Remarks
This method is a proxy for using <a href="https://learn.microsoft.com/dotnet/api/system.string.compare#system-string-compare(system-string-system-int32-system-string-system-int32-system-int32-system-stringcomparison)" target="_blank" rel="noopener noreferrer">Compare(String, Int32, String, Int32, Int32, StringComparison)</a> with the `StringComparison` set to <a href="https://learn.microsoft.com/dotnet/api/system.stringcomparison#system-stringcomparison-ordinal" target="_blank" rel="noopener noreferrer">Ordinal</a>.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
