namespace EventManagementAdmin.Models
{
    public class Feedback
    {
        public string EventId { get; set; } = "";
        public string EventTitle { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string StudentEmail { get; set; } = "";
        public int Rating { get; set; }
        public string Comments { get; set; } = "";
        public string SubmissionDate { get; set; } = "";
    }
}