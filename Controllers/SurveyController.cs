using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models.Survey;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        readonly SurveyRepository _surveyRepository;
        readonly QuestionRepository _questionRepository;

        public SurveyController()
        {
            _surveyRepository = new SurveyRepository();
            _questionRepository = new QuestionRepository();
        }
        [HttpPost("")]
        public ActionResult AddSurvey(CreateSurveyRequest createRequest)
        {

            var newSurvey = _surveyRepository.AddSurvey(createRequest.Date);
            foreach (var question in createRequest.Questions)
            {
                Console.WriteLine(question);
            }
            //_questionRepository.AddQuestion(createRequest.Questions);
            return Created($"/api/student/{newSurvey.Id}", newSurvey);

        }
    }
}