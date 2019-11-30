using SchoolHouse.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHouse.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            Student = new StudentRepository(_db);
        }


        public IStudentRepository Student { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
