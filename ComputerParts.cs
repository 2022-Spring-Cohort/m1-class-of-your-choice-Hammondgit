using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_class_of_your_choice
{
    class ComputerParts
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string MotherBoard { get; set; }
        public string RAM { get; set; }
        public string SDD { get; set; }
        public string HDD { get; set; }
        public string PowerSupply { get; set; }
        public string Cooling { get; set; }
        public string PCcase { get; set; }


        public ComputerParts()
        {
        }

    

        public string cpu_brand()
        {


            int userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput == 1)
            {
                return "Intel";
            }
            else
            {
                return "AMD";     // I know doing it this way can cause problems however I do error checking later
            }

        }


        public void Intel_CPUlist()
        {
            Console.Clear();
            string[] cpulist = new string[4] { "\n1.Intel Core i3-12100", "2.Intel Core i5-12400", "3.Intel Core i7-8700K", "4.Intel Core i9-9900K" };

            Console.WriteLine("\nHere a list of available CPUs in are store:\n\nChoose the number");

            for (int count = 0; count < 4; count++)
            {
                Console.WriteLine(cpulist[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());


            this.CPU = cpulist[i - 1]; 
        }


        public void AMD_CPU_list()
        {

            Console.Clear();
            string[] cpulist = new string[4] { "\n1.AMD Ryzen 3 2200G", "2.AMD Ryzen 3 3300X", "3.AMD Ryzen 5 2600X", "4.AMD Ryzen 7 5800X" };

            Console.WriteLine("\nHere a list of available CPUs in are store.\n\nChoose the number");

            for (int count = 0; count < 4; count++)
            {
                Console.WriteLine(cpulist[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.CPU = cpulist[i - 1];
        }




        public void GPU_List()
        {

            Console.Clear();
            string[] gpulist = new string[8] { "\n1.GTX 980", "2.GTX 1060", "3.GTX 1660", "4.GTX 3080 - Good luck finding one with your kidneys intact ", "5.RX 570", "6.RX 590", "7.RX 5600 ", "8.RX 6900 - Good luck finding one with your kidneys intact " };

            Console.WriteLine("\nHere a list of available CPUs in are store:\n\nChoose the number");

            for (int count = 0; count < 8; count++) // Switching 8 with the list somehow. I think it possible but its a string
            {
                Console.WriteLine(gpulist[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.GPU = gpulist[i - 1];

        }


        public void motherboard_list()
        {
            Console.Clear();
            string[] MBList = new string[4] { "\n1.Bear minimum to run", "2.Standard motherboard ", "3.Look at that more usb slots and features :)", "4.Rainbow colors EVERWHERE!!!!" };

            Console.WriteLine("\nHere a list of available motherboards in the store:\nChoose the number");

            for (int count = 0; count < 4; count++)
            {
                Console.WriteLine(MBList[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.MotherBoard = MBList[i - 1];

        }


        public void Ram_list()
        {
            Console.Clear();
            string[] RamList = new string[6] { "\n1.2GB of ram - If you hate yourself get this one", "2.4GB of ram - ok its usable   ", "3.8GB or ram - you looking good", "4.16GB - you wont have any problems", "5.32GB of ram -overkill", "6.64GB of ram...NASA called they want there ram back " };

            Console.WriteLine("\nHere a list of available RAM in the store:\nChoose the number");

            Console.WriteLine("How much memory does your Ram have?");


            for (int count = 0; count < 6; count++)
            {
                Console.WriteLine(RamList[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.RAM = RamList[i - 1];

        }


        public void SDD_or_HDD_list()
        {

            Console.Clear();
            Console.WriteLine("Do you want a SDD(1) or HDD(2)? ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if (userInput == 1)
            {
                Console.WriteLine("\nHere a list of available SDD in the store:\nChoose the number");
                string[] SDDlist = new string[4] { "1.250GB of storge", "2.500GB of storge", "3.1TB of storge", "4.2TB of storge" };

                for (int count = 0; count < 4; count++)
                {
                    Console.WriteLine(SDDlist[count]);
                }

                int i = Convert.ToInt32(Console.ReadLine());

                this.SDD = SDDlist[i - 1];

            }
            else
            {

                Console.WriteLine("\nHere a list of available SDD in the store:\nChoose the number");
                string[] HDDlist = new string[4] { "1.250GB of storge", "2.500GB of storge", "3.1TB of storge", "4.2TB of storge" };

                for (int count = 0; count < 4; count++)
                {
                    Console.WriteLine(HDDlist[count]);
                }

                int i = Convert.ToInt32(Console.ReadLine());

                this.HDD = HDDlist[i - 1];

            }

        }




        public void cooling_list()
        {
            Console.Clear();
            Console.WriteLine("\nHere your two options. \nChoose the number");
            string[] Coolinglist = new string[2] { "1.The chad liquad cooling", "2.Not so chad fan cooling..." };
            for (int count = 0; count < 2; count++)
            {
                Console.WriteLine(Coolinglist[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.Cooling = Coolinglist[i - 1];
        }

        public void PowerSupply_list()
        {
            Console.Clear();
            Console.WriteLine("\nHere a list of available SDD in the store:\nChoose the number");
            string[] PSlist = new string[4] { "1.450 watts - Waste of money if your going to upgrade the pc in the future.", "2.600 watts", "3.750 watts", "4.1000 watts - future proof maybe..." };

            for (int count = 0; count < 4; count++)
            {
                Console.WriteLine(PSlist[count]);
            }

            int i = Convert.ToInt32(Console.ReadLine());

            this.PowerSupply = PSlist[i - 1];

        }

        public void pc_case_list()
        {
            Console.Clear();
            Console.WriteLine("\nHere your options. \nChoose the number\n\nWe are not responsible for parts not fitting inside the case. ");
            string[] Caselist = new string[3] { "1.Small", "2,Medium", "3.Large" };

            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine(Caselist[count]);
            }
            int i = Convert.ToInt32(Console.ReadLine());

            this.PCcase = Caselist[i - 1];
        }


        public override string ToString()
        {

            return $" CPU: {this.CPU}\n GPU: {this.GPU}\n Motherboard: {this.MotherBoard}\n Ram: {RAM}\n Storge: {this.RAM}\n Power Supply: {this.PowerSupply}\n PC Cooling: {this.Cooling}\n Case: {this.PCcase} ";

        }



    }
}


