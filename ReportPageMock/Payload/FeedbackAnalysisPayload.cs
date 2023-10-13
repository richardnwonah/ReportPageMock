namespace ReportPageMock.Payload
{
    public class FeedbackAnalysisPayload
    {
       public FilterType Filter { get; set; }
        public string FilterValue { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
    public enum FilterType
    {
        ByStaff, ByBranch, ByTransaction
    }
}
