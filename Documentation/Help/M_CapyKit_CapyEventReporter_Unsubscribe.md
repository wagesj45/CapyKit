# Unsubscribe Method


Unsubscribes the specified event handler from the event with the given origin.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public static void Unsubscribe(
	CapyEventHandler callback,
	string origin
)
```
**F#**
``` F#
static member Unsubscribe : 
        callback : CapyEventHandler * 
        origin : string -> unit 
```



#### Parameters
<dl><dt>  <a href="T_CapyKit_CapyEventHandler.md">CapyEventHandler</a></dt><dd>The event handler to unsubscribe.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The name of the method or class where the subscription was made.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
