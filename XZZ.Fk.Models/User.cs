using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.Models
{
    /// <summary>
    /// 用户
    /// </summary>
    public partial class User:Entity
    {
        public User()
        {
            Roles = new HashSet<Role>();
            Blogs = new HashSet<Blog>();
            Comments = new HashSet<Comment>();
        }

        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }

        /// <summary>
        /// 用户具有的角色
        /// </summary>
        public virtual ICollection<Role> Roles { get; set; }

        /// <summary>
        /// 用户发表过的博客
        /// </summary>
        public virtual ICollection<Blog> Blogs { get; set; }

        /// <summary>
        /// 用户发表过的评论
        /// </summary>
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
