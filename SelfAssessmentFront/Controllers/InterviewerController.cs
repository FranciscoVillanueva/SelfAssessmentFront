using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using InterviewFront.Models;
using Microsoft.AspNetCore.Mvc;

namespace SelfAssessmentFront.Controllers
{
    public class InterviewerController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Interview()
        {
            return View();
        }

        public IActionResult SearchCandidate()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult SelfAssessment()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}