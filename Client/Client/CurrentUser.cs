using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class CurrentUser
    {
        public static int Id { get; set; }
        public static string username { get; set; }
        public static string password { get; set; }
        public static int balance { get; set; }
        public static int user_type_id { get; set; }
        public static int how_many_wins { get; set; }
    }
}
