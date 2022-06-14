using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.Classes
{
    public class User
    {
        /// <summary>
        /// 사용자 번호
        /// </summary>
        [Key]  // PK설정
        public int UserNo { get; set; }

        /// <summary>
        /// 사용자 이름
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 사용자 ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 사용자 Password
        /// </summary>
        public string UserPassword { get; set; }
    }
}
