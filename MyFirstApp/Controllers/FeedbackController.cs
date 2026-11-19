using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class FeedbackController : Controller
    {

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Submit(

            
            string StudentNameId,
            string Month,
            string FacultyBatch,
            string Subject,
            string Remarks
            )
        {
            ViewBag.Nameid = StudentNameId;
            ViewBag.month = Month;
            ViewBag.facultybatch= FacultyBatch;
            ViewBag.subject = Subject;
            ViewBag.remarks= Remarks;



            return View("~/Views/Pages/Result.cshtml");
        }
    }
}