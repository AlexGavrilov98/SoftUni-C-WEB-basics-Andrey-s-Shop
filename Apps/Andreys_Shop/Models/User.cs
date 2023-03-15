using SUS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andreys.Models
{
    public class User : IdentityUser<string>
    {
        public User()
        {
            Id = Guid.NewGuid().ToString();
            Role = IdentityRole.User;
        }
    }
}
