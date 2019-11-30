using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolHouse.DataAccess.Data.Repository.IRepository;
using SchoolHouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace SchoolHouse.DataAccess.Data.Repository
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetStudentListForDropDown()
        {
            return _db.Student.Select(i => new SelectListItem()
            {
                Text = i.FirstName + ' ' + i.LastName,
                Value = i.StudentId.ToString()
            });
        }

        public void Update(Student student)
        {
            var objFromDb = _db.Student.FirstOrDefault(s => s.StudentId == student.StudentId);
            objFromDb.FirstName = student.FirstName;
            objFromDb.LastName = student.LastName;
            objFromDb.DOB = student.DOB;

            _db.SaveChanges();

        }
    }
}
