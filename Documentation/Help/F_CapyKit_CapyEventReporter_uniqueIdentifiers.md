# uniqueIdentifiers Field


A hash set storing unique identifiers for events intended to only be emitted once.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
private static HashSet<string> uniqueIdentifiers
```
**F#**
``` F#
static val mutable private uniqueIdentifiers: HashSet<string>
```



#### Field Value
<a href="https://learn.microsoft.com/dotnet/api/system.collections.generic.hashset-1" target="_blank" rel="noopener noreferrer">HashSet</a>(<a href="https://learn.microsoft.com/dotnet/api/system.string" target="_blank" rel="noopener noreferrer">String</a>)

## See Also


#### Reference
<a href="T_CapyKit_CapyEventReporter.md">CapyEventReporter Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
<a href="M_CapyKit_CapyEventReporter_EmitEventOnce.md">EmitEventOnce(EventLevel, String, String, String, Object[])</a>  
