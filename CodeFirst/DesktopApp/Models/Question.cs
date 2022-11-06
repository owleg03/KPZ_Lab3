using System.Collections.Generic;

namespace DesktopApp.Models;

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; } = null!;
    public string Description { get; set; } = null!;
    public virtual IList<Answer> Answers { get; set; } = null!;
    public double SuccessRate { get; set; }
    public bool IsMarkedDebatable { get; set; }
}