using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolHouse.DataAccess.Data.Repository.IRepository;

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