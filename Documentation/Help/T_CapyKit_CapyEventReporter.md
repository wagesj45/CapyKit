# CapyEventReporter Class


The CapyEventReporter class is responsible for managing event subscriptions and emissions within CapyKit.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

**C#**
``` C#
public static class CapyEventReporter
```
**F#**
``` F#
[<AbstractClassAttribute>]
[<SealedAttribute>]
type CapyEventReporter = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  CapyEventReporter</td></tr>
</table>



## Remarks
Because consumers of CapyKit may have varied ways of handling logging, the CapyEventReporter provides a way for subscribers to recieve events for various "events" within the library. These can be thought of as a logging solution for CapyKit. Consumers are free to treat these events however they see fit.

## Methods
<table>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_Subscribe">Subscribe</a></td>
<td>Subscribes the specified event handler to the event with the given subscription level and origin.</td></tr>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_Unsubscribe">Unsubscribe</a></td>
<td>Unsubscribes the specified event handler from the event with the given origin.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit">CapyKit Namespace</a>  
