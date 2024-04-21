# Unsubscribe Method


Unsubscribes the specified event handler from the event with the given origin.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+735d7c4c91a8ae04c2d8cae4ce85ddf4909e5b7d

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
<dl><dt>  <a href="T_CapyKit_CapyEventHandler">CapyEventHandler</a></dt><dd>The event handler to unsubscribe.</dd><dt>  <a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a></dt><dd>The name of the method or class where the subscription was made.</dd></dl>

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter">CapyEventReporter Class</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  
