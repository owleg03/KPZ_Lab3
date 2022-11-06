using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeFirstApp.Models;

public class Question
{
    public int Id { get; set; }
    public string Content { get; set; } = null!;
    public string Description { get; set; } = null!;
    public virtual ICollection<Answer> Answers { get; set; } = new ObservableCollection<Answer>();
    public double SuccessRate { get; set; }
    public bool IsMarkedDebatable { get; set; }
}