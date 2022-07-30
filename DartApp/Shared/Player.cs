using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartApp.Shared
{
    public class Player
    {
        public string Id { get; private set; }
        public string Name { get; set; }

        public Player()
        {
            Id = new Guid().ToString();
        }
    }
}
