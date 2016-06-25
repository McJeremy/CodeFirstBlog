using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Core;

namespace XZZ.Fk.Models
{
    /// <summary>
    /// 角色表
    /// </summary>
    public partial class Role:Entity
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
