using System;
using System.Collections.Generic;
using Dapper;
using WebApplication1.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WebApplication1.Data
{
    public class StudentRepository
    {
        const string ConnectionString = "Server=localhost;Database=SurveyTest;Trusted_Connection=True;";

        public Student AddStudent(string firstName, string lastName)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var addStudentInformation = db.QueryFirstOrDefault<Student>(@"
                    Insert into Student (firstName,lastName)
                    Output inserted.*
                    Values(@firstName,@lastName)",
                    new { firstName, lastName });


                if (addStudentInformation != null)
                {
                    return addStudentInformation;
                }
            }

            throw new Exception("No user created");
        }

    }
}
