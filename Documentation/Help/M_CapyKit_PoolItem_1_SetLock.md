# SetLock Method


Sets the lock on the item indicating that it is in use.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
public bool SetLock()
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
<a href="T_CapyKit_PoolItem_1.md">PoolItem(T) Class</a>  
<a href="N_CapyKit.md">CapyKit Namespace</a>  
