using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Question;

namespace WebApplication1.Data
{
    public class QuestionRepository
    {
        const string ConnectionString = "Server=localhost;Database=SurveyTest;Trusted_Connection=True;";

        public Question AddQuestion(string questionText)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var addQuestion = db.QueryFirstOrDefault<Question>(@"
                    Insert into Question (questionText)
                    Output inserted.*
                    Values(@questionText)",
                    new { questionText });


                if (addQuestion != null)
                {
                    return addQuestion;
                }
            }

            throw new Exception("No user created");
        }
    }
}
