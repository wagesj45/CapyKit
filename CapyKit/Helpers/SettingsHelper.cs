using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapyKit.Helpers
{
    /// <summary>
    /// Static class containing helper methods for retrieving and setting application settings.
    /// </summary>
    /// <remarks>
    /// The specific means of accessing and storing the settings are determined by the consumer,
    /// allowing for flexibility in various environments such as <c>App.config</c> or <c>Web.config</c>
    /// .
    /// </remarks>
    /// <example>
    /// This example demonstrates how to set up the SettingsHelper class with custom accessor and
    /// detector methods that read from an App.config file. The setup is done at the beginning of the
    /// application execution, before any other usage of the helper methods.
    /// <code>
    /// public int main(string[] args)
    /// {
    ///    // Set up SettingsHelper with custom accessor and detector methods
    ///    Func&lt;string, object&gt; accessor = (key) =&gt;
    ///    {
    ///        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    ///        return config.AppSettings.Settings[key].Value;
    ///    };
    /// 
    ///    Func&lt;string, bool&gt; detector = (key) =&gt;
    ///    {
    ///        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
    ///        return config.AppSettings.Settings.AllKeys.Contains(key);
    ///    };
    /// 
    ///    SettingsHelper.SetAccessorMethod(accessor);
    ///    SettingsHelper.SetDetectorMethod(detector);
    /// 
    ///    // Use the helper to retrieve and set settings
    ///    SettingsHelper.SetApplicationSetting&lt;int&gt;("MySettingKey", 42);
    ///    int newSetting = SettingsHelper.GetApplicationSetting&lt;int&gt;("MySettingKey");
    ///    Console.WriteLine("New setting: {0}", newSetting);
    /// 
    ///    int mySetting = SettingsHelper.GetApplicationSetting&lt;int&gt;("MySettingKey");
    ///    Console.WriteLine("Retrieved setting: {0}", mySetting);
    /// }
    /// </code>
    /// </example>
    public static class SettingsHelper
    {
        #region Members

        /// <summary>
        /// Private delegate function that retrieves a setting with the given <c>key</c>. Returns the
        /// setting as an uncast <see cref="object"/>.
        /// </summary>
        private static Func<string, object> accessor = (key) => default(object);

        /// <summary>
        /// Private delegate function that detects if a setting with a given <c>key</c> exists. Returns <see langword="true"/>
        /// if the setting exists, <see langword="false"/> if not.
        /// </summary>
        private static Func<string, bool> detector = (key) => false;

        #endregion Members

        #region Methods

        /// <summary>
        /// Retrieves a setting with the given <c>key</c>. Returns the setting as an uncast <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T"> The type of the setting to be retrieved. </typeparam>
        /// <param name="settingName"> The name of the setting to retrieve. </param>
        /// <returns> The value of the setting as an uncast <typeparamref name="T"/>. </returns>
        public static T GetApplicationSetting<T>(string settingName)
        {
            if (SettingsHelper.detector(settingName))
            {
                var result = Convert.ChangeType(SettingsHelper.accessor(settingName), typeof(T));
                if (result is T)
                {
                    return (T)result;
                }

                return default(T);
            }

            return default(T);
        }

        /// <summary> Sets the function used to retrieve application settings. </summary>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when one or more required arguments are null.
        /// </exception>
        /// <param name="accessor"> The new function used to retrieve application settings. </param>
        public static void SetAccessorMethod(Func<string, object> accessor)
        {
            if (accessor != null)
            {
                SettingsHelper.accessor = accessor;
            }
            else
            {
                var error = "Cannot set the ApplicationSettingsHelper accessor method to a null function.";
                CapyEventReporter.EmitEvent(EventLevel.Error, error);
                throw new ArgumentNullException(error);
            }
        }

        /// <summary>
        /// Sets the function used to detect if an application setting with a given <c>key</c> exists.
        /// </summary>
        /// <exception cref="ArgumentNullException">
        ///     Thrown when one or more required arguments are null.
        /// </exception>
        /// <param name="detector">
        ///     The new function used to detect if an application setting exists.
        /// </param>
        public static void SetDetectorMethod(Func<string, bool> detector)
        {
            if (detector != null)
            {
                SettingsHelper.detector = detector;
            }
            else
            {
                var error = "Cannot set the ApplicationSettingsHelper detector method to a null function.";
                CapyEventReporter.EmitEvent(EventLevel.Error, error);
                throw new ArgumentNullException(error);
            }
        }

        #endregion Methods
    }
}
