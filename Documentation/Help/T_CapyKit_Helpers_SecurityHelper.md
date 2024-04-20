# SecurityHelper Class


A class that contains methods for managing secure data processing and cryptography.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0+6cdd805be49c3b769a116584ea6904955ecd820d

**C#**
``` C#
public class SecurityHelper
```
**VB**
``` VB
Public Class SecurityHelper
```
**C++**
``` C++
public ref class SecurityHelper
```
**F#**
``` F#
type SecurityHelper = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  SecurityHelper</td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper__ctor">SecurityHelper</a></td>
<td>Initializes a new instance of the SecurityHelper class</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareHashedPassword">CompareHashedPassword</a></td>
<td>Compares an unencrypted <em>providedPassword</em> with a stored, encrypted <em>existingPassword</em>.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareSessionID">CompareSessionID</a></td>
<td>Compares two session identifiers.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetCalendarKey">GetCalendarKey</a></td>
<td>Gets a calendar key that is <code>32</code> characters long.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetRandomPassword">GetRandomPassword</a></td>
<td>Gets a cryptographically strong random password.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_HashPassword">HashPassword</a></td>
<td>Hashes an unencrypted password.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_Pbkdf2">Pbkdf2</a></td>
<td> </td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_SHA256Hash">SHA256Hash</a></td>
<td>Produces a <a href="https://en.wikipedia.org/wiki/SHA-2">SHA256</a> hash from a given <em>value</em>.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Helpers">CapyKit.Helpers Namespace</a>  