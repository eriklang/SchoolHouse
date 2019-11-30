using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolHouse.DataAccess.Data.Repository.IRepository;

namespace SchoolHouse.Web.Areas.User.Controllers
{
    [Area("User")]
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
    }
}