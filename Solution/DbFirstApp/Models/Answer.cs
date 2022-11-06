using System;
using System.Collections.Generic;

namespace DbFirstApp.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public string Key { get; set; } = null!;
        public string Content { get; set; } = null!;
        public int QuestionId { get; set; }

        public virtual Question Question { get; set; } = null!;
    }
}
