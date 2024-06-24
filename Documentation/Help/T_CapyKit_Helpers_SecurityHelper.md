# SecurityHelper Class


A class that contains methods for managing secure data processing and cryptography.



## Definition
**Namespace:** <a href="N_CapyKit_Helpers.md">CapyKit.Helpers</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.0

**C#**
``` C#
public class SecurityHelper
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
<td><a href="M_CapyKit_Helpers_SecurityHelper__ctor.md">SecurityHelper</a></td>
<td>Initializes a new instance of the SecurityHelper class</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareHashedPassword.md">CompareHashedPassword(Password, String, Byte[], IPasswordAlgorithm, Object[])</a></td>
<td>Compares an unencrypted <em>password</em> with a stored, encrypted <em>existingPassword</em>. This method uses the specified <em>algorithm</em> to retrieve the hashed version of the <em>password</em> and then compares it with the <em>existingPassword</em>.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareHashedPassword__1.md">CompareHashedPassword(T)(Password, String, Byte[], Object[])</a></td>
<td>Compares an unencrypted <em>password</em> with a stored, encrypted <em>existingPassword</em>. This method uses the specified password algorithm type <em>T</em> to retrieve the hashed version of the <em>password</em> and then compares it with the <em>existingPassword</em>.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareSessionID.md">CompareSessionID</a></td>
<td>Compares two session identifiers.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_CompareStrings.md">CompareStrings</a></td>
<td>Compare two strings as case sensative.</td></tr>
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
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetPassword__1_1.md">GetPassword(T)(String, Object[])</a></td>
<td>Retrieves a <a href="T_CapyKit_Password.md">Password</a> object using the specified password and generates a random salt value. Then it uses that salt to call the overloaded <a href="M_CapyKit_Helpers_SecurityHelper_GetPassword__1.md">GetPassword(T)(String, Byte[], Object[])</a> method with the given password and the generated salt as arguments.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetPassword__1.md">GetPassword(T)(String, Byte[], Object[])</a></td>
<td>Retrieves a <a href="T_CapyKit_Password.md">Password</a> object using the specified password, salt, and optional constructor arguments.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetRandomBytes.md">GetRandomBytes</a></td>
<td>Generates a new byte array of the specified length with random values.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetRandomPassword.md">GetRandomPassword</a></td>
<td>Gets a cryptographically strong random password.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetRandomString.md">GetRandomString(Int32)</a></td>
<td>A convenience method to generate a random string of the specified length using all character sets.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetRandomString_1.md">GetRandomString(Int32, ValidCharacterCollection[])</a></td>
<td>Gets a cryptographically strong random string using the character values found in [!:VALID_CHARACTERS].</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.gettype" target="_blank" rel="noopener noreferrer">GetType</a></td>
<td>Gets the <a href="https://learn.microsoft.com/dotnet/api/system.type" target="_blank" rel="noopener noreferrer">Type</a> of the current instance.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetValidCharacterComposition.md">GetValidCharacterComposition</a></td>
<td>Static method that returns a valid character composition based on the given ValidCharacterCollection parameters.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone" target="_blank" rel="noopener noreferrer">MemberwiseClone</a></td>
<td>Creates a shallow copy of the current <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_Pbkdf2.md">Pbkdf2(String)</a></td>
<td>Generates a new <a href="T_CapyKit_Password.md">Password</a> object using the PBKDF2 algorithm with the provided <em>password</em>. This overload of the method generates a random salt value for added security.</td></tr>
<tr>
<td><a href="M_CapyKit_Helpers_SecurityHelper_Pbkdf2_1.md">Pbkdf2(String, Byte[])</a></td>
<td>Generates a new <a href="T_CapyKit_Password.md">Password</a> object using the PBKDF2 algorithm with the provided <em>password</em> and <em>salt</em>.</td></tr>
<tr>
<td><a href="https://learn.microsoft.com/dotnet/api/system.object.tostring" target="_blank" rel="noopener noreferrer">ToString</a></td>
<td>Returns a string that represents the current object.<br />(Inherited from <a href="https://learn.microsoft.com/dotnet/api/system.object" target="_blank" rel="noopener noreferrer">Object</a>)</td></tr>
</table>

## Fields
<table>
<tr>
<td><a href="F_CapyKit_Helpers_SecurityHelper_LOWER_CASE_CHARACTERS.md">LOWER_CASE_CHARACTERS</a></td>
<td>A string of all the lower case characters.</td></tr>
<tr>
<td><a href="F_CapyKit_Helpers_SecurityHelper_NUMBER_CHARACTERS.md">NUMBER_CHARACTERS</a></td>
<td>A string of all the numeric characters.</td></tr>
<tr>
<td><a href="F_CapyKit_Helpers_SecurityHelper_SALT_SIZE.md">SALT_SIZE</a></td>
<td>Default size to use when generating a new salt.</td></tr>
<tr>
<td><a href="F_CapyKit_Helpers_SecurityHelper_SPECIAL_CHARACTERS.md">SPECIAL_CHARACTERS</a></td>
<td>A string of the most common non-alphanumeric characters.</td></tr>
<tr>
<td><a href="F_CapyKit_Helpers_SecurityHelper_UPPER_CASE_CHARACTERS.md">UPPER_CASE_CHARACTERS</a></td>
<td>A string of all the upper case characters.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
