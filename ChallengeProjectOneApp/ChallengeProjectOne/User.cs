using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeProjectOne
{
    class User
    {
        //private string name;
        public string name{ get; set; }
        public string password { get; set; }
        //private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
    }
}
