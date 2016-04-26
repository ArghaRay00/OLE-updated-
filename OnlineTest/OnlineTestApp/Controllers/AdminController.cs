﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using OnlineTestApp.Models;
using OnlineTestBL;
using OnlineTestEntities;
using Question = OnlineTestEntities.Question;

namespace OnlineTestApp.Controllers
{
    public class AdminController : Controller
    {
       
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Panel()
        {
            return View();
        }
        // [HttpPost]
        //public ActionResult panel(Technicalpanel panel)
        //{
        //    var pManager = new PanelManager();
        //    pManager.CreatePanel(panel);
        //    return View("Details");
        //}

        public ActionResult RegisterCollege()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterCollege(College College)
        {
            var cManager = new CollegeManager();
            cManager.CreateCollege(College);
            return View("Index");
        }
        public ActionResult RegisterExamination()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RegisterExamination(Examination Examination)
        {
            Examination.LocationId = Examination.College.LocationId; //Exam location would be same as College - Assumption
            var eManager = new ExaminationManager();
            eManager.CreateExamination(Examination);
            return View("Index");

        }
        public ActionResult AssignQuestionSet()
        {
            return View();
        }

        public ActionResult CreateQuestion()
        {
            return View();
        }
          
        [HttpPost]
        public ActionResult CreateQuestion(Question questionModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionModel, Question>());
            var mapper = config.CreateMapper();
            Question question = mapper.Map<Question>(questionModel);
            var qManager = new QuestionSetManager();
            qManager.CreateQuestion(question);

            return View("Index");
        }
        public ActionResult DeleteQuestion()
        {
            return View();
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteQuestion(Question questionModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionModel, Question>());
            var mapper = config.CreateMapper();
            Question question = mapper.Map<Question>(questionModel);
            var qManager = new QuestionSetManager();
            qManager.DeleteQuestion(question);

            return View("Index");
        }

        public ActionResult ModifyQuestion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ModifyQuestion(Question questionModel) {



            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionModel, Question>());
            var mapper = config.CreateMapper();
            Question question = mapper.Map<Question>(questionModel);
            var qManager = new QuestionSetManager();
            qManager.ModifyQuestion(question);

            return View("Index");
        }
    
       

       

       

       
        public ActionResult CreateQuestionSet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateQuestionSet(QuestionSet questionSetModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionSet, Questionset>());
            var mapper = config.CreateMapper();
            Questionset questionset = mapper.Map<Questionset>(questionSetModel);
            var qManager = new QuestionSetManager();
            qManager.CreateQuestionSet(questionset);
            return View("Index");
        }
        public ActionResult ModifyQuestionset()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ModifyQuestionSet(QuestionSet questionSetModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionSet, Questionset>());
            var mapper = config.CreateMapper();
            Questionset questionset = mapper.Map<Questionset>(questionSetModel); 
            var qManager = new QuestionSetManager();
           
            qManager.ModifyQuestionSet(questionset);
           
            return View("Index");
        }
        public ActionResult DeleteQuestionset()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteQuestionSet(QuestionSet questionSetModel)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<QuestionSet, Questionset>());
            var mapper = config.CreateMapper();
            Questionset questionset = mapper.Map<Questionset>(questionSetModel);
            var qManager = new QuestionSetManager();
           
           
            qManager.DeleteQuestionSet(questionset);
            return View("Index");
        }

        public ActionResult Exam() {

            return View();

        }

        //public ActionResult Exam()
        //{
        //    QuestionSetManager questions = new QuestionSetManager();
        //    Question question = new Question();
        //    question = questions.GetAllQuestions().FirstOrDefault();
        //   return View(question);
        //}

        //[HttpPost]
        //public ActionResult Exam(int id, int Options)
        //{
        //    QuestionSetManager questions = new QuestionSetManager();
        //    Question quest = questions.GetallQuestion(id);
        //    StudentQuestions sq = new StudentQuestions();
        //    sq.Questions = new Question();
        //    sq.Students = new Student();
        //    sq.StudentId = 1;
        //    sq.StudentQuestionID = 1;
        //    sq.QuestionId = id;
        //    sq.IsAnswered = Options;
        //    questions.UpdateStudentQuestionsList(sq);
        //    return RedirectToAction("PreviousQuestion");
        //}

        //public ActionResult PreviousQuestion()
        //{
        //    QuestionSetManager questions = new QuestionSetManager();
        //    Question question = questions.GetAllQuestions().OrderBy(x=>x.QuestionId).FirstOrDefault();
        //    return View("Exam",question);
        //}

        public ActionResult QuestionOperation()
        {
            return View();
        }
        public ActionResult QuestionSetOperation()
        {
            return View();
        }
       


        public ActionResult CreateLocation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateLocation(Location location)
        {
            var manager = new LocationManager();
            manager.CreateLocation(location);

            return View("Index");
        }

        
    }
}