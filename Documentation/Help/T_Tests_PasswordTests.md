# PasswordTests Class


\[Missing &lt;summary&gt; documentation for "T:Tests.PasswordTests"\]



## Definition
**Namespace:** <a href="N_Tests.md">Tests</a>  
**Assembly:** Tests (in Tests.exe) Version: 1.0.0

**C#**
``` C#
[TestFixtureAttribute]
internal class PasswordTests
```
**F#**
``` F#
[<TestFixtureAttribute>]
type PasswordTests = class end
```

<table><tr><td><strong>Inheritance</strong></td><td><a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>  →  PasswordTests</td></tr>
</table>



## Constructors
<table>
<tr>
<td><a href="M_Tests_PasswordTests__ctor.md">PasswordTests</a></td>
<td>Initializes a new instance of the PasswordTests class</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.equals#system-object-equals(system-object)" target="_blank" rel="noopener noreferrer">Equals</a></td>
<td>Determines whether the specified object is equal to the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.finalize" target="_blank" rel="noopener noreferrer">Finalize</a></td>
<td>Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_GenerateSalt.md">GenerateSalt</a></td>
<td> </td></tr>
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
<td><a href="M_Tests_PasswordTests_PasswordCreation_WithInvalidSalt_ReturnsEmptyHash.md">PasswordCreation_WithInvalidSalt_ReturnsEmptyHash</a></td>
<td> </td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_PasswordCreation_WithPbkdf2Algorithm_CreatesValidHash.md">PasswordCreation_WithPbkdf2Algorithm_CreatesValidHash</a></td>
<td> </td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_PasswordEquality_DifferentPasswords_AreNotEqual.md">PasswordEquality_DifferentPasswords_AreNotEqual</a></td>
<td> </td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_PasswordEquality_DifferentSalts_AreNotEqual.md">PasswordEquality_DifferentSalts_AreNotEqual</a></td>
<td> </td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_PasswordEquality_SamePasswordAndSalt_AreEqual.md">PasswordEquality_SamePasswordAndSalt_AreEqual</a></td>
<td> </td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_Tests_PasswordTests_ToString_ReturnsCorrectFormat.md">ToString_ReturnsCorrectFormat</a></td>
<td> </td></tr>
</table>

## See Also


#### Reference
<a href="N_Tests.md">Tests Namespace</a>  
