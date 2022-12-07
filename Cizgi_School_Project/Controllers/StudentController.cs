using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cizgi_School_Project.Models;

namespace Cizgi_School_Project.Controllers
{
    public class StudentController : Controller
    {
        CizgSchoolDbEntities db = new CizgSchoolDbEntities();
        public ActionResult Index()
        {
            var values = db.TblStudent.ToList();     
            return View(values);      
        }
        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStudent(TblStudent p)
        {
            db.TblStudent.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteStudent(int id)
        {
            var values = db.TblStudent.Find(id);
            db.TblStudent.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }


}