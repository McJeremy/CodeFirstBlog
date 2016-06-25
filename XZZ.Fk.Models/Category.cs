using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.Models
{
    /// <summary>
    /// 博客分类
    /// </summary>
    public partial class Category:Entity
    {
        public Category()
        {
            Blogs = new HashSet<Blog>();
        }

        public string CategoryName { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
