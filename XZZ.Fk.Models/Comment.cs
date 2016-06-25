using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.Models
{
    /// <summary>
    /// 博客评论
    /// </summary>
    public partial class Comment:Entity
    {
        public string Body { get; set; }
        public DateTime CreationTime { get; set; }
        public int? BlogId { get; set; }
        public int? PosterId { get; set; }
        public virtual Blog Blog { get; set; }
        public virtual User User { get; set; }
    }
}
