namespace ReportPageMock.Models
{
    public class Staff
    {
        public string StaffId { get; set; }//
        public string StaffName { get; set; }//
        public string role { get; set; }//
        public string BranchName { get; set; }//
        public string BranchCode { get; set; }//
    }
    public class FeedbackModels
    {
        public int StaffId { get; set; }//
        public string StaffName { get; set;}//
        public Staff Staff { get; set; }
        public string BranchName { get; set; }//
        public int TotalTransactions { get; set; }//
        public int Excellent { get; set; }//
        public int VeryGood { get; set; }//
        public int Good { get; set; }//
        public int Average { get; set; }//
        public int Poor { get; set; }//
        public int Percentage { get; set; }///
        public int AverageRating { get; set; }//
        public int TotalRatedTransaction { get; set; }//

    }
}
