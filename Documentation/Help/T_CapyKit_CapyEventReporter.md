# CapyEventReporter Class


The CapyEventReporter class is responsible for managing event subscriptions and emissions within CapyKit.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

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

## Constructors
<table>
<tr>
<td><a href="M_CapyKit_CapyEventReporter__cctor.md">CapyEventReporter</a></td>
<td> </td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_EmitEvent.md">EmitEvent</a></td>
<td>Emits an event with the given severity level, message, and method name.</td></tr>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_EmitEventOnce.md">EmitEventOnce</a></td>
<td>Emits an event with the given severity level, message, unique identifier, and method name one time.</td></tr>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_Subscribe.md">Subscribe</a></td>
<td>Subscribes the specified event handler to the event with the given subscription level and origin.</td></tr>
<tr>
<td><a href="M_CapyKit_CapyEventReporter_Unsubscribe.md">Unsubscribe</a></td>
<td>Unsubscribes the specified event handler from the event with the given origin.</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_CapyEventReporter_uniqueIdentifiers.md">uniqueIdentifiers</a></td>
<td>A hash set storing unique identifiers for events intended to only be emitted once.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
