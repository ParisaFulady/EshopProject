using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularEshop.Core.Services.Interfaces
{
   public interface IUserService : IDisposable
    {
        Task<List<User>> GetAllUsers();
    }
}
