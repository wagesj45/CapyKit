using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    public class EncryptionHelper
    {
        #region Members

        private string encryptionKey;

        #endregion

        #region Constructors

        public EncryptionHelper(string encryptionKey)
        {
            this.encryptionKey = encryptionKey;
        }

        #endregion
    }

    public interface IEncryptionAlgorithm
    {
        #region Properties

        string AlgorithmName { get; }

        #endregion

        #region Methods

        EncryptedValue<T> Encrypt<T>(object obj, params object[] args);

        T Decrypt<T>(EncryptedValue<T> encryptedValue, params object[] args);

        #endregion
    }
}
