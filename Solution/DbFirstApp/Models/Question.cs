using System;
using System.Collections.Generic;

namespace DbFirstApp.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
        }

        public int Id { get; set; }
        public string Content { get; set; } = null!;
        public double SuccessRate { get; set; }
        public bool IsMarkedDebatable { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
