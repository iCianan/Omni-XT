using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public class Cabinet
    {
        public LargeBin LargeBin { get; set; }
        public MediumBin MediumBin { get; set; }
        public SmallBin SmallBin { get; set; }

        public Cabinet(AppUser appUser)
        {
            this.LargeBin = new LargeBin(appUser);
            this.MediumBin = new MediumBin(appUser);
            this.SmallBin = new SmallBin(appUser);
        }
    }
}
