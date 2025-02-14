# Pbkdf2Algorithm Class


Implements the PBKDF2 algorithm for password encryption.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.4

**C#**
``` C#
public class Pbkdf2Algorithm : IPasswordAlgorithm
```
**F#**
``` F#
type Pbkdf2Algorithm = 
    class
        interface IPasswordAlgorithm
    end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  Pbkdf2Algorithm</td></tr>
<tr><td><strong>Implements</strong></td><td><a href="T_CapyKit_IPasswordAlgorithm.md">IPasswordAlgorithm</a></td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_CapyKit_Pbkdf2Algorithm__ctor.md">Pbkdf2Algorithm</a></td>
<td>Default constructor.</td></tr>
</table>

## Properties
<table>
<tr>
<td><a href="P_CapyKit_Pbkdf2Algorithm_AlgorithmName.md">AlgorithmName</a></td>
<td>Gets the name of the algorithm.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_Pbkdf2Algorithm_Encrypt.md">Encrypt</a></td>
<td>Encrypts the given password using a PBKDF2 algorithm.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
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
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_Pbkdf2Algorithm_ITERATIONS.md">ITERATIONS</a></td>
<td>The default number of iterations.</td></tr>
<tr>
<td><a href="F_CapyKit_Pbkdf2Algorithm_LENGTH.md">LENGTH</a></td>
<td>(Immutable) The default length.</td></tr>
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
