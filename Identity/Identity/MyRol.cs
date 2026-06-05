using Microsoft.AspNetCore.Identity;

namespace IdentityDemo.Identity
{
    public class MyRol : IdentityRole
    {
        public string Seccion { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
