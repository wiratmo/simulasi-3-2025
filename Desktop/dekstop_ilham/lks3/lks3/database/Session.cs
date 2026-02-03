using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lks2.Database
{
    internal class Session
    {
        public static string Username { get; set; }

        public void Logout()
        {
            Username = null;
        }
    }
}
