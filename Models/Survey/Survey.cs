using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Survey
{
    public class Survey
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<Survey> Questions { get; set; }
    }
}
