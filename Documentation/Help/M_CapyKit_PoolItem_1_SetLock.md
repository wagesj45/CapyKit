# SetLock Method


Sets the lock on the item indicating that it is in use.



## Definition
**Namespace:** <a href="N_CapyKit">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public bool SetLock()
```
**VB**
``` VB
Public Function SetLock As Boolean
```
**C++**
``` C++
public:
bool SetLock()
```
**F#**
``` F#
member SetLock : unit -> bool 
```



#### Return Value
<a href="https://learn.microsoft.com/dotnet/api/system.boolean" target="_blank" rel="noopener noreferrer">Boolean</a>  
true if the item is locked successfully, false if it fails.

## Remarks
If the item is already locked, an error event is emitted.

## See Also


#### Reference
<a href="T_CapyKit_PoolItem_1">PoolItem(T) Class</a>  
<a href="N_CapyKit">CapyKit Namespace</a>  