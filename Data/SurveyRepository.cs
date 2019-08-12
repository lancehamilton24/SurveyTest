using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Survey;

namespace WebApplication1.Data
{
    public class SurveyRepository
    {
        const string ConnectionString = "Server=localhost;Database=SurveyTest;Trusted_Connection=True;";

        public Survey AddSurvey(DateTime date)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var addQuestion = db.QueryFirstOrDefault<Survey>(@"
                    Insert into Survey (date)
                    Output inserted.*
                    Values(@date)",
                    new { date });


                if (addQuestion != null)
                {
                    return addQuestion;
                }
            }

            throw new Exception("No user created");
        }
    }
}
