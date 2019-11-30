using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolHouse.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository Student { get; }



        //IFrequencyRepository Frequency { get; }
        //IServiceRepository Service { get; }
        //IOrderHeaderRepository OrderHeader { get; }
        //IOrderDetailsRepository OrderDetails { get; }

        //ISP_Call SP_Call { get; }

        //IUserRepository User { get; }
        void Save();
    }
}
