namespace EventManagementAdmin.Models
{
    public class Event
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string Date { get; set; } = "";
        public string Time { get; set; } = "";
        public string Location { get; set; } = "";
        public string Category { get; set; } = "";
        public string Organizer { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public int MaxAttendees { get; set; }
        public string Status { get; set; } = "Upcoming";
    }
}