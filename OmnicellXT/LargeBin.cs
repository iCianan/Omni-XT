using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public class LargeBin : Bin
    {
        public override int UnitCapacity => 15;
        public override int NumberOfUnits => 2;

        public LargeBin(AppUser user)
        {
            this.MedicationUnitStore = new Dictionary<string, MedicationUnit>();
            this.ModifiedDate = DateTime.Now;
            this.ModifiedBy = user;
        }

    }
}
