# Password Class


Represents a password with its hash, salt and algorithm used for encryption.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public class Password
```
**F#**
``` F#
type Password = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  Password</td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Password__cctor.md">Password</a></td>
<td> </td></tr>
<tr>
<td><a href="M_CapyKit_Password__ctor.md">Password</a></td>
<td>Constructor.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_CapyKit_Password_Algorithm.md">Algorithm</a></td>
<td>Gets or sets the algorithm used for password encryption.</td></tr>
<tr>
<td><a href="P_CapyKit_Password_Hash.md">Hash</a></td>
<td>Gets or sets the hash of the password.</td></tr>
<tr>
<td><a href="P_CapyKit_Password_Pbkdf2Algorithm.md">Pbkdf2Algorithm</a></td>
<td>Gets the preconfigured PBKDF2 algorithm.</td></tr>
<tr>
<td><a href="P_CapyKit_Password_Salt.md">Salt</a></td>
<td>Gets or sets the salt used for encryption.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_Password_Equals.md">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Object.Equals(Object)</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gethashcode" target="_blank" rel="noopener noreferrer">GetHashCode</a></td>
<td>Serves as the default hash function.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Password_ToString.md">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Overrides <a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">Object.ToString()</a>)</td></tr>
</table>

## Operators
<table>
<tr>
<td><a href="M_CapyKit_Password_op_Equality.md">Equality(Password, Password)</a></td>
<td> </td></tr>
<tr>
<td><a href="M_CapyKit_Password_op_Inequality.md">Inequality(Password, Password)</a></td>
<td> </td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_Password_pbkdf2Algorithm.md">pbkdf2Algorithm</a></td>
<td> </td></tr>
</table>

## Extension Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties</a></td>
<td>An object extension method that updates the properties of a given <em>target</em> object with the values from a given <em>source</em> object.<br />(Defined by <a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
