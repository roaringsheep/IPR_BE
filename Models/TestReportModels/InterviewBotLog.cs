namespace IPR_BE.Models.TestReport;

public class InterviewBotLog {
    public int logId { get; set; }
    public DateTime created { get; set; } = DateTime.UtcNow;

    public string message { get; set; } = "";
}