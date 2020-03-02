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

        public int GetCapacity()
        {
            return this.UnitCapacity * this.NumberOfUnits;
        }

        public void AddMedicationUnit(string medicationName)
        {
            MedicationUnit medicationUnit = new MedicationUnit
            {
                Name = medicationName,
                MedicationId = medicationName.Length
            };

            if (GetCapacity() > this.MedicationUnitStore.Count)
            {
                this.MedicationUnitStore.Add(medicationUnit.Name, medicationUnit);
            }
            else
            {
                throw new InvalidOperationException("Bin is full, please remove an item and try again");
            }
        }

        public void RemoveMedicationUnit(string name)        
        {            
            this.MedicationUnitStore.Remove(name);

            if (this.MedicationUnitStore.Count <= (GetCapacity() * 0.20))
            {
                Console.WriteLine("Inventory is under 20%, considering placing an order");
            }
        }

        public void ResetBin()
        {
            this.MedicationUnitStore = new Dictionary<string, MedicationUnit>();
        }
    }  
}

