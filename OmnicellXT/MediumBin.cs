using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public class MediumBin : Bin
    {
        public override int UnitCapacity => 10;

        public override int NumberOfUnits => 5;

        public MediumBin(AppUser user)
        {
            this.MedicationUnitStore = new Dictionary<string, MedicationUnit>();
            this.ModifiedDate = DateTime.Now;
            this.ModifiedBy = user;
        }
    }
}
