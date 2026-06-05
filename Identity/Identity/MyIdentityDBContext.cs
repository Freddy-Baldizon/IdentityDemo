using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdentityDemo.Identity
{
    public class MyIdentityDBContext : IdentityDbContext<MyUser, MyRol , string>
    {
        public MyIdentityDBContext(DbContextOptions<MyIdentityDBContext> options) : base(options)
        {
            
        }
    }
}
