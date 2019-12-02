using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolHouse.DataAccess.Data.Repository.IRepository;
using SchoolHouse.Models;

namespace SchoolHouse.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Student student = new Student();
            if(id == null)
            {
                return View(student);
            }
            student = _unitOfWork.Student.Get(id.GetValueOrDefault());
            if(student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Student student)
        {
            if(ModelState.IsValid)
            {
                if(student.StudentId == 0)
                {
                    _unitOfWork.Student.Add(student);
                }
                else
                {
                    _unitOfWork.Student.Update(student);
                }

                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }


        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _unitOfWork.Student.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Student.Get(id);
            if(objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }

            _unitOfWork.Student.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful." });
        }

        #endregion

    }
}