using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class CurrentGame
    {
        public static int ID { get; set; }
        public static string Name { get; set; }
        public static int PriceToPlay { get; set; }
        public static int Reward { get; set; }
    }
}
