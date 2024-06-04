namespace MessageAnalysisSampleApp.Models
{
    public class EventsReceived
    {
        public static IList<EventReceived> EventReceivedListStatic { get; set; } = new List<EventReceived>();
    }

    public class EventReceived
    {
        public AdvancedMessageReceivedEventData Text { get; set; } = null;
        public AdvancedMessageAnalysisCompletedEventData? Analysis { get; set; } = null;
    }
}