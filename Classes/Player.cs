using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Classes
{
    public class Player : Being
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int InventorySize { get; set; }

        public Item? HeadGearId { get; set; }
        public Item? HeadGear { get; set; }
        public Item? Necklace { get; set; }
        public Item? Body {  get; set; }
        public Item? Bracelet { get; set; }
        public Item? Ring { get; set; }
        public Item? Legs { get; set; }
        public Item? Boots { get; set; }
    }
}
