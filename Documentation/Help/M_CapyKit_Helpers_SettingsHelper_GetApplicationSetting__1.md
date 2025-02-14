# GetApplicationSetting&lt;T&gt; Method


Retrieves a setting with the given `key`.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public static T GetApplicationSetting<T>(
	string settingName
)

```
**F#**
``` F#
static member GetApplicationSetting : 
        settingName : string -> 'T 
```



#### Parameters
<dl><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The name of the setting to retrieve.</dd></dl>

#### Type Parameters
<dl><dt /><dd>The type of the setting to be retrieved.</dd></dl>

#### Return Value
T  
The value of the setting as an uncast *T*.

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SettingsHelper.md">SettingsHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
