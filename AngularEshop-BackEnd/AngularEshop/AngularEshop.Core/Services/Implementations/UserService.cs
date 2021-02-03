using AngularEshop.Core.Services.Interfaces;
using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AngularEshop.Core.Services.Implementations
{
    public class UserService : IUserService
    {
        #region constructor
        private IGenericRepository<User> userRepository;
        public  UserService(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;

        }
        #endregion

        public async Task<List<User>> GetAllUsers()
        {
            return await userRepository.GetEntitiesQuery().ToListAsync();
        }

        public void Dispose()
        {
            userRepository?.Dispose();
        }
    }
}
