using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.Models
{
    /// <summary>
    /// 博客
    /// </summary>
    public partial class Blog:Entity
    {
        public Blog()
        {
            Comments = new HashSet<Comment>();
        }
        public string Title { get; set; }       
        [DisplayName("正文")]
        public string Body { get; set; }
        [DisplayName("创建时间")]
        public DateTime CreationTime { get; set; }
        [DisplayName("更新时间")]
        public DateTime UpdateTime { get; set; }
        [DisplayName("选择类别")]
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

    }
}
