using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        readonly QuestionRepository _questionRepository;

        public QuestionController()
        {
            _questionRepository = new QuestionRepository();
        }
        [HttpPost("")]
        public ActionResult AddStudent(CreateQuestionRequest createRequest)
        {

            var newQuestion = _questionRepository.AddQuestion(createRequest.QuestionText);
            return Created($"/api/student/{newQuestion.Id}", newQuestion);

        }
    }
}