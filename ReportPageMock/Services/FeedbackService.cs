using RandomNameGeneratorLibrary;
using ReportPageMock.Models;

namespace ReportPageMock.Services
{
    public class FeedbackService
    {

        private string GenerateRandomRoles()
        {
            string[] roles = { "Bank teller", "Banker", "Loan processor", "Mortgage consultant", "Credit analyst" };
            Random rand = new Random();
            var role = rand.Next(roles.Length);
            return roles[role];
        }

        private string GenerateRandomBranchCode()
        { 
            string[] branchCode = { "Bank teller", "Banker", "Loan processor", "Mortgage consultant", "Credit analyst" };

            Random rand = new Random();
            var branch = rand.Next(branchCode.Length);
            return  branchCode[branch];
        }

        private string GenerateBranchName()
        {        
            string[] BranchNames = { "Bank teller", "Banker", "Loan processor", "Mortgage consultant", "Credit analyst" };

            Random rand = new Random();
            var branchNameId = rand.Next(BranchNames.Length);
            return BranchNames[branchNameId];
        }

        private Staff GenerateStaffDetails()
        {
            var staff = new Staff();
            IPersonNameGenerator personNameGenerator = new PersonNameGenerator();
            staff.StaffId = GenerateRandomIntForRating().ToString();
            staff.StaffName = personNameGenerator.GenerateRandomFirstAndLastName();
            staff.role = GenerateRandomRoles();
            staff.BranchCode = GenerateRandomBranchCode();
            staff.BranchName = GenerateBranchName();
            return staff;
        }
        private FeedbackModels GenerateFeedbackModels()
        {
            IPersonNameGenerator personNameGenerator = new PersonNameGenerator();
            FeedbackModels feedbackModels = new FeedbackModels();

            var staff = GenerateStaffDetails();
            feedbackModels.StaffId = int.Parse(staff.StaffId);
            feedbackModels.StaffName = staff.StaffName;
            feedbackModels.BranchName = staff.BranchName;
            feedbackModels.TotalTransactions = GenerateRandomIntForRating();
            feedbackModels.Excellent = GenerateRandomIntForRating();
            feedbackModels.VeryGood = GenerateRandomIntForRating();
            feedbackModels.Good = GenerateRandomIntForRating();
            feedbackModels.Average = GenerateRandomIntForRating();
            feedbackModels.Poor = GenerateRandomIntForRating();
            feedbackModels.Percentage = GenerateRandomIntForRating();
            feedbackModels.AverageRating = GenerateRandomIntForRating();
            feedbackModels.TotalRatedTransaction = GenerateRandomIntForRating();


            return feedbackModels;
        }

        public List<ReturnBodyRelay> GetData()
        {
            List<ReturnBodyRelay> values = new List<ReturnBodyRelay>();
            for (int i = 0; i < 30; i++)
            {
                var generator = GenerateFeedbackModels();

                var returnbodyrelay = new ReturnBodyRelay();
                returnbodyrelay.FeedbackModels = generator;
                returnbodyrelay.Staffs = generator.Staff;
                
                values.Add(returnbodyrelay);
                
            }
            return values;
        }
        private int GenerateRandomIntForRating()
        {
            var rating = 0;
            Random random = new Random();
            rating = random.Next(1, 100);
            return rating;
        }
    

    }
}
