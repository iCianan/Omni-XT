using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmnicellXT
{
    public abstract class Bin
    {
        public abstract int UnitCapacity { get; }
        public abstract int NumberOfUnits { get; }
        public DateTime ModifiedDate { get; set; }
        public AppUser ModifiedBy { get; set; }
        public Dictionary<string, MedicationUnit> MedicationUnitStore { get; set; }


        public void AddMedicationUnit(string medicationName)
        {
            int capacity = this.UnitCapacity * this.NumberOfUnits;
            MedicationUnit medicationUnit = new MedicationUnit
            {
                Name = medicationName,
                MedicationId = medicationName.Length

            };


            if (capacity > this.MedicationUnitStore.Count)
            {
                this.MedicationUnitStore.Add(medicationUnit.Name, medicationUnit);
            }
            else
            {
                throw new InvalidOperationException("Bin is full, please remove an item and try again");
            }
        }

        public bool RemoveMedicationUnit(string name)
        {
            return this.MedicationUnitStore.Remove(name);
        }

        public void ResetBin()
        {
            this.MedicationUnitStore = new Dictionary<string, MedicationUnit>();
        }
    }

  
}

