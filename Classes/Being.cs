using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Classes
{
    public class Being
    {
        [Key]
        public int BeingId { get; set; }
        public int HP { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public SkinColor SkinColor { get; set; }
        public int BaseDamage { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public List<Item>? Inventory { get; set; }

    }
}
