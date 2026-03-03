namespace EventManagementAdmin.Models
{
    public class RSVP
    {
        public string EventId { get; set; } = "";
        public string EventTitle { get; set; } = "";
        public string StudentName { get; set; } = "";
        public string StudentEmail { get; set; } = "";
        public string StudentId { get; set; } = "";
        public string RegistrationDate { get; set; } = "";
        public string Status { get; set; } = "Confirmed";
    }
}