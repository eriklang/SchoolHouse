using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolHouse.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHouse.DataAccess.Data.Repository.IRepository
{
    public interface IStudentRepository : IRepository<Student>
    {
        void Update(Student student);

        IEnumerable<SelectListItem> GetStudentListForDropDown();

    }
}
