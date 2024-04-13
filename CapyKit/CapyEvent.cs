using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CapyKit.Attributes;
using CapyKit.Extensions;

namespace CapyKit
{
    /// <summary>
    /// The CapyEventReporter class is responsible for managing event subscriptions and emissions within CapyKit.
    /// </summary>
    /// <remarks>
    /// Because consumers of CapyKit may have varied ways of handling logging, the <see cref="CapyEventReporter"/> provides 
    /// a way for subscribers to recieve events for various "events" within the library. These can be thought of as 
    /// a logging solution for CapyKit. Consumers are free to treat these events however they see fit.
    /// </remarks>
    public static class CapyEventReporter
    {
        #region Members

        /// <summary>
        /// A dictionary storing event handlers and their corresponding origins for each subscription level.
        /// </summary>
        private static Dictionary<EventLevel, List<(CapyEventHandler Handler, string origin)>> subscribers = new Dictionary<EventLevel, List<(CapyEventHandler Handler, string origin)>>();

        /// <summary> A hash set storing unique identifiers for events intended to only be emitted once. </summary>
        /// <seealso cref="EmitEventOnce(EventLevel, string, string, string, object[])"/>
        private static HashSet<string> uniqueIdentifiers = new HashSet<string>();

        #endregion

        #region Methods

        /// <summary>
        /// Subscribes the specified event handler to the event with the given subscription level and
        /// origin.
        /// </summary>
        /// <remarks>
        /// If there is no existing list for the given subscription level, a new list is created and
        /// added to the dictionary.
        /// </remarks>
        /// <param name="callback">          The event handler to subscribe. </param>
        /// <param name="subscriptionLevel"> The severity level of the event to subscribe to. </param>
        /// <param name="origin">
        ///     (Optional) The name of the method or class where the subscription is made.
        /// </param>
        public static void Subscribe(CapyEventHandler callback, EventLevel subscriptionLevel, [CallerMemberName] string origin = null)
        {
            if (!subscribers[subscriptionLevel].Any())
            {
                subscribers.Add(subscriptionLevel, new List<(CapyEventHandler Handler, string origin)>());
            }

            subscribers[subscriptionLevel].Add((callback, origin ?? "[Unknown]"));
        }

        /// <summary>
        /// Unsubscribes the specified event handler from the event with the given origin.
        /// </summary>
        /// <param name="callback"> The event handler to unsubscribe. </param>
        /// <param name="origin">
        ///     The name of the method or class where the subscription was made.
        /// </param>
        public static void Unsubscribe(CapyEventHandler callback, string origin)
        {
            foreach (var value in Enum.GetValues(typeof(EventLevel)))
            {
                if (value is EventLevel)
                {
                    subscribers[(EventLevel)value].RemoveAll(c => c.Handler == callback && c.origin == origin);
                }
            }
        }

        /// <summary> Emits an event with the given severity level, message, and method name. </summary>
        /// <remarks>
        /// In order to allow for efficient calling member access via <see cref="CallerMemberNameAttribute"/>
        /// ,
        ///  it is suggested that <paramref name="args"/> is defined explicitly for formatted messages.
        /// </remarks>
        /// <param name="eventLevel"> The severity level of the event. </param>
        /// <param name="message">
        ///     The message describing the reason for the event. String formatting for <paramref name="args"/>
        ///     is accepted.
        /// </param>
        /// <param name="method">
        ///     (Optional) The name of the method where the event was raised.
        /// </param>
        /// <param name="args">
        ///     A variable-length parameters list containing arguments for formatting the message.
        /// </param>
        /// <example>
        /// CapyEventReporter.EmitEvent(EventLevel.Error, "Could not find the description for {0}.",
        /// args: new[] { enumeration });
        /// </example>
        /// <seealso cref="CallerMemberNameAttribute"/>
        internal static void EmitEvent(EventLevel eventLevel, string message, [CallerMemberName] string method = null, params object[] args)
        {
            if (!subscribers.ContainsKey(eventLevel))
            {
                return;
            }

            var formattedMessage = string.Format(message, args);

            var capyEventArgs = new CapyEventArgs(eventLevel, formattedMessage, method);

            foreach (var subscriber in subscribers[eventLevel])
            {
                subscriber.Handler(capyEventArgs);
            }
        }

        /// <summary>
        /// Emits an event with the given severity level, message, unique identifier, and method name one
        /// time.
        /// </summary>
        /// <remarks>
        /// This method is similar to <see cref="EmitEvent(EventLevel, string, string, string, object[])"/>
        /// , but requires a unique identifier (such as a <see cref="Guid"/>) to prevent duplicate
        /// emissions.
        /// </remarks>
        /// <param name="eventLevel">       The severity level of the event. </param>
        /// <param name="message">
        ///     The message describing the reason for the event. String formatting for <paramref name="args"/>
        ///     is accepted.
        /// </param>
        /// <param name="uniqueIdentifier"> A unique identifier for the event emission. </param>
        /// <param name="method">
        ///     (Optional) The name of the method where the event was raised.
        /// </param>
        /// <param name="args">
        ///     A variable-length parameters list containing arguments for formatting the message.
        /// </param>
        /// <seealso cref="CallerMemberNameAttribute"/>
        /// <seealso cref="Guid"/>
        internal static void EmitEventOnce(EventLevel eventLevel, string message, string uniqueIdentifier, [CallerMemberName] string method = null, params object[] args)
        {
            if(uniqueIdentifiers.Contains(uniqueIdentifier))
            {
                return;
            }

            uniqueIdentifiers.Add(uniqueIdentifier);
            EmitEvent(eventLevel, message, method: method, args: args);
        }

        #endregion
    }

    /// <summary>
    /// A delegate representing an event handler that accepts a <see cref="CapyEventArgs"/> instance.
    /// </summary>
    /// <param name="e">The CapyEventArgs instance containing event data.</param>
    public delegate void CapyEventHandler(CapyEventArgs e);

    /// <summary>
    /// The CapyEventArgs class represents an event argument instance with event level, message, and
    /// method name information.
    /// </summary>
    public class CapyEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// Gets the severity level of the event.
        /// </summary>
        public EventLevel Level { get; private set; }

        /// <summary>
        /// Gets the message describing the reason for the event.
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Gets the name of the method where the event was raised.
        /// </summary>
        public string MethodName { get; private set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the CapyEventArgs class with the specified event level, message, and method name.
        /// </summary>
        /// <param name="level">The severity level of the event.</param>
        /// <param name="message">A descriptive message explaining the reason for the event.</param>
        /// <param name="method">The name of the method where the event was raised.</param>
        public CapyEventArgs(EventLevel level, string message, string method = null)
        {
            this.Level = level;
            this.Message = message;
            this.MethodName = method ?? "[Unknown]";
        }

        #endregion
    }


    /// <summary> Enumeration representing different event level severity values. </summary>
    public enum EventLevel
    {
        /// <summary> Represents a critical error that requires immediate attention. </summary>
        [EnumerationDescription("Represents a critical error that requires immediate attention.")]
        Critical = 0,
        /// <summary> Represents an error that prevents the normal execution of the application.  </summary>
        [EnumerationDescription("Represents an error that prevents the normal execution of the application.")]
        Error = 1,
        /// <summary> Represents a warning indicating a non-critical issue that should be addressed. </summary>
        [EnumerationDescription("Represents a warning indicating a non-critical issue that should be addressed.")]
        Warning = 2,
        /// <summary> Represents informational messages that provide useful context to the consumer. </summary>
        [EnumerationDescription("Represents informational messages that provide useful context to the consumer.")]
        Information = 3,
        /// <summary> Represents detailed messages that are typically used for debugging purposes. </summary>
        [EnumerationDescription("Represents detailed messages that are typically used for debugging purposes.")]
        Debug = 4
    }
}
