namespace EventManagementAdmin.Models
{
    /// <summary>
    /// Event with Firestore document ID
    /// </summary>
    public class EventViewModel : Event
    {
        public string Id { get; set; } = "";
    }

    /// <summary>
    /// RSVP with Firestore document ID
    /// </summary>
    public class RSVPViewModel : RSVP
    {
        public string Id { get; set; } = "";
    }

    /// <summary>
    /// Feedback with Firestore document ID
    /// </summary>
    public class FeedbackViewModel : Feedback
    {
        public string Id { get; set; } = "";
    }

    /// <summary>
    /// Firebase operation result
    /// </summary>
    public class FirebaseResult
    {
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }
    }

    /// <summary>
    /// Firebase authentication result
    /// </summary>
    public class AuthResult
    {
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "student";

        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string Uid { get; set; } = "";
    }

    /// <summary>
    /// User role information from Firestore
    /// </summary>
    public class UserRoleInfo
    {
        [System.Text.Json.Serialization.JsonPropertyName("email")]
        public string Email { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string Uid { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "student";

        [System.Text.Json.Serialization.JsonPropertyName("profileImageUrl")]
        public string ProfileImageUrl { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("displayName")]
        public string DisplayName { get; set; } = "";
    }

    /// <summary>
    /// Dashboard statistics from Firebase
    /// </summary>
    public class DashboardStats
    {
        [System.Text.Json.Serialization.JsonPropertyName("TotalEvents")]
        public int TotalEvents { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("TotalRSVPs")]
        public int TotalRSVPs { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("TotalFeedback")]
        public int TotalFeedback { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("AverageRating")]
        public double AverageRating { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("ConfirmedRSVPs")]
        public int ConfirmedRSVPs { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("CancelledRSVPs")]
        public int CancelledRSVPs { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("PendingRSVPs")]
        public int PendingRSVPs { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("UpcomingEvents")]
        public int UpcomingEvents { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("OngoingEvents")]
        public int OngoingEvents { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("CompletedEvents")]
        public int CompletedEvents { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("CancelledEvents")]
        public int CancelledEvents { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("PositiveFeedback")]
        public int PositiveFeedback { get; set; }
    }

    /// <summary>
    /// Image upload result
    /// </summary>
    public class UploadResult
    {
        [System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        [System.Text.Json.Serialization.JsonPropertyName("url")]
        public string Url { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("error")]
        public string Error { get; set; } = "";
    }

    /// <summary>
    /// Calendar event item for display
    /// </summary>
    public class CalendarEvent
    {
        [System.Text.Json.Serialization.JsonPropertyName("id")]
        public string Id { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("title")]
        public string Title { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("date")]
        public string Date { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("time")]
        public string Time { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("category")]
        public string Category { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("status")]
        public string Status { get; set; } = "";

        [System.Text.Json.Serialization.JsonPropertyName("location")]
        public string Location { get; set; } = "";
    }
}