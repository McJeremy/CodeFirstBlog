using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.Models;

namespace XZZ.Fk.DAL.ModelConfigurations
{
    public class UserTypeConfiguration:EntityTypeConfiguration<User>
    {
        public UserTypeConfiguration()
        {
            HasKey(u => u.Id);            
        }
    }
}
