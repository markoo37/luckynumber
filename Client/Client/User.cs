using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class User
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int balance { get; set; }
        public int user_type_id { get; set; }
        public int how_many_wins { get; set; }
    }
}
