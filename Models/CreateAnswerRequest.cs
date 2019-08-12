using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CreateAnswerRequest
    {
        public int Id { get; set; }
        public string AnswerText { get; set; }
        public int SurveyId { get; set; }
        public int StudentId { get; set; }
        public int QuestionId { get; set; }
    }
}
