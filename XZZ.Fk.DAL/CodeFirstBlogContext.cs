using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XZZ.Fk.DAL.ModelConfigurations;
using XZZ.Fk.Models;

namespace XZZ.Fk.DAL
{
    public class CodeFirstBlogContext:DbContext
    {
        public CodeFirstBlogContext() : base("name=BlogConnection")
        {
            this.Configuration.AutoDetectChangesEnabled = true;
        }
        static CodeFirstBlogContext()
        {
            Database.SetInitializer<CodeFirstBlogContext>(null);
        }

        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*也可以使用EntityTypeConfiguration来做配置*/
            //modelBuilder.Configurations.Add(new UserTypeConfiguration());
            
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Blogs)
                .WithRequired(b => b.Category)
                .HasForeignKey(b => b.CategoryId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Blog>()
                .HasMany(b => b.Comments)
                .WithRequired(c=>c.Blog)
                .HasForeignKey(c => c.BlogId)
                .WillCascadeOnDelete(false);

            //User和Blog之间的一对多关系
            modelBuilder.Entity<User>()
                .HasMany(u => u.Blogs)
                .WithRequired(b => b.User)
                .HasForeignKey(b => b.AuthorId)
                .WillCascadeOnDelete(false);

            //User和Comment之间的一对多关系
            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOptional(c => c.User)
                .HasForeignKey(c => c.PosterId);

            //User和Role之间的多对多关系
            modelBuilder.Entity<User>()
                .HasMany(u => u.Roles)
                .WithMany(r => r.Users)
                .Map(act => act.ToTable("UserRoles")
                .MapLeftKey("UserId")
                .MapRightKey("RoleId"));
            
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
