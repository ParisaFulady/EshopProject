using AngularEshop.DataLayer.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AngularEshop.DataLayer.Entities.Access
{
    public class Role : BaseEntity
    {
        #region Properties
        [Display(Name = "نام سیستمی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Name { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = "تعداد کاراکتر های {0} نمیتواند بیشتر از {1} باشد")]
        public string Titel { get; set; }
        #endregion

        #region Relation
        public ICollection<UserRole> UserRoles { get; set; }
        #endregion
    }
}
