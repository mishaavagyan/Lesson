using ConsoleApp1.Servises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.Models
{
    public class LoginResponseModel
    {
        public bool Success { get; set; }
        public string Massege { get; set; }

        public User User { get; set; }

    }
}
