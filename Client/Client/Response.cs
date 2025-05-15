using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Response
    {
        public int error { get; set; }
        public string message { get; set; }
        public List<User> Users { get; set; }
    }
}
