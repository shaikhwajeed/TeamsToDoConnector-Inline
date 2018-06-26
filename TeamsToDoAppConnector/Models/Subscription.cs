
namespace TeamsToDoAppConnector.Models
{
    /// <summary>
    /// Represents the model to store channel subscriptions.
    /// </summary>
    public class Subscription
    {
        public string WebHookUri { get; set; }
        public EventType EventType { get; set; }
    }

    public enum EventType
    {
        Create,
        Update
    }

}