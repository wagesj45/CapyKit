# SetDetectorMethod Method


Sets the function used to detect if an application setting with a given `key` exists.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static void SetDetectorMethod(
	Func<string, bool> detector
)
```
**F#**
``` F#
static member SetDetectorMethod : 
        detector : Func<string, bool> -> unit 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.func-2" target="_blank" rel="noopener noreferrer">Func</a>(<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>, <a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>)</dt><dd>The new function used to detect if an application setting exists.</dd></dl>

## Exceptions
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.argumentnullexception" target="_blank" rel="noopener noreferrer">ArgumentNullException</a></td>
<td>Thrown when one or more required arguments are null.</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SettingsHelper.md">SettingsHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
