using AngularEshop.DataLayer.Entities.Account;
using AngularEshop.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace AngularEshop.DataLayer.Entities.Access
{
  public  class UserRole : BaseEntity
    {
        #region Properties
        public int UserId { get; set; }
        public int RoleId { get; set; }
        #endregion

        #region Relation
        public User User { get; set; }
        public Role Role { get; set; }
        #endregion
    }
}
