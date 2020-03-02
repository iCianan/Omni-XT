using System;

namespace OmnicellXT
{
    class Program
    {
        static void Main(string[] args)
        {
            AppUser appUser = new AppUser();
            appUser.UserId  = 1;
            appUser.UserName = "admin";

            Cabinet LansingCabinet = new Cabinet(appUser);

            LansingCabinet.SmallBin.AddMedicationUnit("Advil");
            LansingCabinet.SmallBin.AddMedicationUnit("Ravicti");
            LansingCabinet.SmallBin.AddMedicationUnit("Takhzyro");
            LansingCabinet.SmallBin.AddMedicationUnit("Tegsedi");
            LansingCabinet.SmallBin.AddMedicationUnit("Kynamro");
            LansingCabinet.SmallBin.AddMedicationUnit("Chenodal");
            LansingCabinet.SmallBin.AddMedicationUnit("Tylenol");
            LansingCabinet.SmallBin.AddMedicationUnit("Claritin");
            LansingCabinet.SmallBin.AddMedicationUnit("Aleve");
            LansingCabinet.SmallBin.AddMedicationUnit("Dulcolax");
            LansingCabinet.SmallBin.AddMedicationUnit("Pepto-Bismol");
            LansingCabinet.SmallBin.AddMedicationUnit("Excedrin");
            LansingCabinet.SmallBin.AddMedicationUnit("Zantac");
            LansingCabinet.SmallBin.AddMedicationUnit("Midol");
            LansingCabinet.SmallBin.AddMedicationUnit("Cortaid");
            LansingCabinet.SmallBin.AddMedicationUnit("Rolaids");
            LansingCabinet.SmallBin.ResetBin();
            LansingCabinet.SmallBin.AddMedicationUnit("Rolaids");
            LansingCabinet.MediumBin.AddMedicationUnit("Nyquil");
            LansingCabinet.LargeBin.AddMedicationUnit("Myalept");


            
        }
    }
}
