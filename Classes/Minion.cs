using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGame.Classes
{
    public class Minion : Being
    {
        public MinionType MinionType { get; set; }
    }
}
