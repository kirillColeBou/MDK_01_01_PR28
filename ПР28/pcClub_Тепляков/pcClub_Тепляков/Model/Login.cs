using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcClub_Тепляков.Model
{
    public class Login
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public Login() { }

        public Login(int Id, string Login, string Password, string Role)
        {
            this.id = Id;
            this.login = Login;
            this.password = Password;
            this.role = Role;
        }
    }
}
