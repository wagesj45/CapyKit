# SecurityHelper Methods




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
<td><a href="M_CapyKit_Helpers_SecurityHelper_GetSalt.md">GetSalt</a></td>
<td>Generates a random byte array that can act as a salt.</td></tr>
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

## Extension Methods
<table>
<tr>
<td><a href="M_CapyKit_Extensions_ObjectExtensions_UpdateProperties.md">UpdateProperties</a></td>
<td>An object extension method that updates the properties of a given <em>target</em> object with the values from a given <em>source</em> object.<br />(Defined by <a href="T_CapyKit_Extensions_ObjectExtensions.md">ObjectExtensions</a>)</td></tr>
</table>

## See Also


#### Reference
<a href="T_CapyKit_Helpers_SecurityHelper.md">SecurityHelper Class</a>  
<a href="N_CapyKit_Helpers.md">CapyKit.Helpers Namespace</a>  
