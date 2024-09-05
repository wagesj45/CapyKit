# IPasswordAlgorithm Interface


Defines the contract for password encryption algorithms.



## Definition
**Namespace:** <a href="N_CapyKit.md">CapyKit</a>  
**Assembly:** CapyKit (in CapyKit.dll) Version: 1.0.2

**C#**
``` C#
public interface IPasswordAlgorithm
```
**F#**
``` F#
type IPasswordAlgorithm = interface end
```



## Properties
<table>
<tr>
<td><a href="P_CapyKit_IPasswordAlgorithm_AlgorithmName.md">AlgorithmName</a></td>
<td>Gets the name of the algorithm.</td></tr>
</table>

## Methods
<table>
<tr>
<td><a href="M_CapyKit_IPasswordAlgorithm_Compare.md">Compare</a></td>
<td>Compares the given plaintext password with an encrypted value using PBKDF2 algorithm.</td></tr>
<tr>
<td><a href="M_CapyKit_IPasswordAlgorithm_Encrypt.md">Encrypt</a></td>
<td>Encrypts the given password using a defined algorithm.</td></tr>
</table>

## See Also


#### Reference
<a href="N_CapyKit.md">CapyKit Namespace</a>  
