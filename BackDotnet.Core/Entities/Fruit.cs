using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackDotnet.Core.Entities
{
    public class Fruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HealthScore { get; set; }
    }

    //TODO: add baseentity with created on by odified etc
}
