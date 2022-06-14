using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore.Data.Classes
{
    public class Note
    {
        /// <summary>
        /// 게시물 번호
        /// </summary>
        [Key]  //PK설정
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
        public string NoteContents { get; set; }

        /// <summary>
        /// 작성자
        /// </summary>
        public int UserNo { get; set; }

        //조인?
        public virtual User User { get; set; }
    }
}
