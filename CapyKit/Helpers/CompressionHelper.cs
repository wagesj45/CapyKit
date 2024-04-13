using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary> A class that contains methods for managing data compression. </summary>
    public static class CompressionHelper
    {
        #region Members

        //

        #endregion Members

        #region Methods

        /// <summary> Compresses a given object using the <c>gzip</c> algorithm. </summary>
        /// <param name="obj"> The object. </param>
        /// <returns> A byte array representing the compressed object in <c>gzip</c> format. </returns>
        public static byte[] Compress(object obj)
        {
            var bytes = SerializationHelper.SerializeToBytes(obj);

            try
            {
                using (var inputStream = new MemoryStream(bytes))
                using (var outputStream = new MemoryStream())
                {
                    using (var gzipStream = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        inputStream.Position = 0;
                        inputStream.CopyTo(gzipStream);
                        gzipStream.Flush();
                    }
                    return outputStream.ToArray();
                }
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not compress the object.");
                throw;
            }
        }

        /// <summary> Compresses a given object to a string using <c>base64</c> encoding of <c>gzip</c> format. </summary>
        /// <param name="obj"> The object. </param>
        /// <returns> A string in <c>base64</c> encoding. </returns>
        public static string CompressToString(object obj)
        {
            var bytes = Compress(obj);
            return Convert.ToBase64String(bytes);
        }

        /// <summary> Decompresses a given <c>base64</c> encoded string of <c>gzip</c> format. </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="encodedString"> The <c>base64</c> encoded <c>gzip</c> string. </param>
        /// <returns> A <typeparamref name="T"/> typed object. </returns>
        public static T Decompress<T>(string encodedString)
        {
            var bytes = Convert.FromBase64String(encodedString);
            return Decompress<T>(bytes);
        }

        /// <summary> Decompresses a given compressed <c>gzip</c> byte stream. </summary>
        /// <typeparam name="T"> Generic type parameter. </typeparam>
        /// <param name="byteStream"> The compressed byte stream. </param>
        /// <returns> A <typeparamref name="T"/> typed object. </returns>
        public static T Decompress<T>(byte[] byteStream)
        {
            try
            {
                using (var inputStream = new MemoryStream(byteStream))
                using (var outputStream = new MemoryStream())
                {
                    using (var gzipStream = new GZipStream(inputStream, CompressionMode.Decompress))
                    {
                        gzipStream.CopyTo(outputStream);
                    }
                    var bytes = outputStream.ToArray();
                    return SerializationHelper.Deserialize<T>(bytes);
                }
            }
            catch (Exception ex)
            {
                CapyEventReporter.EmitEvent(EventLevel.Error, "Could not decompress the deflated object.");
                throw;
            }
        }

        /// <summary> Decompresses the given <c>base64</c> string in <c>gzip</c> format. </summary>
        /// <param name="compressed"> The compressed string. </param>
        /// <returns> A decomressed string. </returns>
        public static string DecompressToString(string compressed)
        {
            var bytes = Convert.FromBase64String(compressed);

            return Decompress<string>(bytes);
        }

        #endregion Methods
    }
}
