using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    public static class SerializationHelper
    {
        #region Members

        //

        #endregion Members

        #region Methods

        /// <summary> Serializes an object to a byte array. </summary>
        /// <param name="obj"> The object. </param>
        /// <returns> A <c>JSON</c> encoded string. </returns>
        public static byte[] SerializeToBytes(object obj)
        {
            return JsonSerializer.SerializeToUtf8Bytes(obj);
        }

        /// <summary> Serializes an object to a <c>JSON</c> encoded string. </summary>
        /// <param name="obj"> The object. </param>
        /// <returns> A <c>JSON</c> encoded string. </returns>
        public static string SerializeToString(object obj)
        {
            return JsonSerializer.Serialize(obj);
        }

        /// <summary> Deserializes an object to a given <typeparamref name="T"/> type. </summary>
        /// <exception cref="FormatException"> Thrown when the format of the byte array is incorrect. </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="bytes"> The byte array representing a <typeparamref name="T"/> object. </param>
        /// <returns> A <typeparamref name="T"/> object. </returns>
        public static T Deserialize<T>(byte[] bytes)
        {
            var stream = new MemoryStream(bytes);

            return Deserialize<T>(stream);
        }

        /// <summary> Deserializes an object to a given <typeparamref name="T"/> type. </summary>
        /// <exception cref="FormatException">
        ///     Thrown when the format of an input is incorrect.
        /// </exception>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="stream"> The steam. </param>
        /// <returns> A <typeparamref name="T"/> object. </returns>
        public static T Deserialize<T>(Stream stream)
        {
            try
            {
                var obj = JsonSerializer.Deserialize<T>(stream);

                if(obj == null)
                {
                    CapyEventReporter.EmitEvent(EventLevel.Error, "The deserialized object was null.");
                    throw new ArgumentNullException(nameof(stream));
                }

                return (T)obj;
            }
            catch (JsonException ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "JSON formatting error detected during deserialization of byte array for {0}.", args: new[] { typeof(T).Name });
                throw new FormatException(string.Format("JSON formatting error detected during deserialization of byte array for {0}.", typeof(T).Name), ex);
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not deserialize object of type {0}.", args: new[] { typeof(T).Name });
                throw;
            }
        }

        /// <summary> Deserializes a <c>JSON</c> encoded string to the given <typeparamref name="T"/>. </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="str"> The <c>JSON</c> encoded string representing a <typeparamref name="T"/> object. </param>
        /// <returns> A <typeparamref name="T"/> object. </returns>
        public static T Deserialize<T>(string str)
        {
            if (typeof(T) == typeof(string))
            {
                return (T)Convert.ChangeType(str, typeof(T));
            }
            else if(string.IsNullOrWhiteSpace(str))
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not deserialize an empty string.");
                return default(T);
            }

            return JsonSerializer.Deserialize<T>(str);
        }

        #endregion Methods
    }
}
