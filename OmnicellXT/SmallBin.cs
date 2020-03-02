using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public class SmallBin : Bin
    {
        public override int UnitCapacity => 5;

        public override int NumberOfUnits => 3;

        public SmallBin(AppUser user)
        {
            this.MedicationUnitStore = new Dictionary<string, MedicationUnit>();
            this.ModifiedDate = DateTime.Now;
            this.ModifiedBy = user;
        }
    }
}
