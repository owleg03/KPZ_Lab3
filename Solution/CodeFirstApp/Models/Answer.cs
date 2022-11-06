namespace DesktopApp.Models;

public class Answer
{
    public int Id { get; set; }
    public string Key { get; set; } = null!;
    public string Content { get; set; } = null!;
    public int QuestionId { get; set; }
}