using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.ViewModels
{
    public class LoginInfo
    {
        [Required(ErrorMessage = "사용자 아이디를 입력하세요.")]
        [MinLength(6, ErrorMessage = "사용자 아이디는 6자 이상으로 입력하세요.")]
        [Display(Name = "사용자 아이디")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "사용자 비밀번호를 입력하세요.")]
        [MinLength(6, ErrorMessage = "사용자 비밀번호는 6자 이상으로 입력하세요.")]
        [Display(Name = "사용자 비밀번호")]
        public string UserPassword { get; set; }
    }
}
