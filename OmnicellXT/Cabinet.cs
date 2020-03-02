using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public class Cabinet
    {
        public Large LargeBin { get; set; }
        public Medium MediumBin { get; set; }
        public Small SmallBin { get; set; }

        public Cabinet(AppUser appUser)
        {
            this.LargeBin = new Large(appUser);
            this.MediumBin = new Medium(appUser);
            this.SmallBin = new Small(appUser);
        }
    }
}
