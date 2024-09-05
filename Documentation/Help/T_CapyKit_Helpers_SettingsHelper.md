# SettingsHelper Class


Static class containing helper methods for retrieving and setting application settings.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static class SettingsHelper
```
**F#**
``` F#
[<AbstractClassAttribute>]
[<SealedAttribute>]
type SettingsHelper = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  SettingsHelper</td></tr>
</table>



## Remarks
The specific means of accessing and storing the settings are determined by the consumer, allowing for flexibility in various environments such as `App.config` or `Web.config` .

## Example
This example demonstrates how to set up the SettingsHelper class with custom accessor and detector methods that read from an App.config file. The setup is done at the beginning of the application execution, before any other usage of the helper methods. 

**C#**  
``` C#
public int main(string[] args)
{
   // Set up SettingsHelper with custom accessor and detector methods
   Func<string, object> accessor = (key) =>
   {
       Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
       return config.AppSettings.Settings[key].Value;
   };

   Func<string, bool> detector = (key) =>
   {
       Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
       return config.AppSettings.Settings.AllKeys.Contains(key);
   };

   SettingsHelper.SetAccessorMethod(accessor);
   SettingsHelper.SetDetectorMethod(detector);

   // Use the helper to retrieve and set settings
   SettingsHelper.SetApplicationSetting<int>("MySettingKey", 42);
   int newSetting = SettingsHelper.GetApplicationSetting<int>("MySettingKey");
   Console.WriteLine("New setting: {0}", newSetting);

   int mySetting = SettingsHelper.GetApplicationSetting<int>("MySettingKey");
   Console.WriteLine("Retrieved setting: {0}", mySetting);
}
```


## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Helpers_SettingsHelper__cctor.md">SettingsHelper</a></td>
<td> </td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_Helpers_SettingsHelper_GetApplicationSetting__1.md">GetApplicationSetting(T)</a></td>
<td>Retrieves a setting with the given <code>key</code>.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SettingsHelper_SetAccessorMethod.md">SetAccessorMethod</a></td>
<td>Sets the function used to retrieve application settings.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SettingsHelper_SetDetectorMethod.md">SetDetectorMethod</a></td>
<td>Sets the function used to detect if an application setting with a given <code>key</code> exists.</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_Helpers_SettingsHelper_accessor.md">accessor</a></td>
<td>Private delegate function that retrieves a setting with the given <code>key</code>.</td></tr>
<tr>
<td><a href="F_CapyKit_Helpers_SettingsHelper_detector.md">detector</a></td>
<td>Private delegate function that detects if a setting with a given <code>key</code> exists. Returns true if the setting exists, false if not.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
