using System;

namespace template_csharp_class_of_your_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gobal variables
            ComputerParts PC = new ComputerParts();

             
            string CPU = "";
            string GPU = "";
            string MB = "";
            string RAM = "";
            string Storge = "";
            string power = "";
            string cooling = "";
            string pcCase = "";




            bool Menu = true;


           


            while (Menu == true)
            {
                Console.WriteLine("What parts are you buying");
                int menuInput = Convert.ToInt32(Console.ReadLine());
                switch (menuInput)
                {

                    case 1:
                        //Getting the customers cpu brand
                        Console.WriteLine("Do you perf Intel(1) or AMD(2)?");
                        string cpuBrand = PC.cpu_brand();

                        // Getting the customers cpu
                        if (cpuBrand == "Intel")
                        {
                            CPU = PC.Intel_CPUlist();

                        }
                        else
                        {

                            CPU = PC.AMD_CPUlist();

                        }

                        break;
                    case 2:

                        GPU = PC.GPU_List();

                        break;
                    case 3:
                        MB = PC.motherboard_list();
                        break;
                    case 4:
                        RAM = PC.Ram_list();
                        break;
                    case 5:
                        Storge = PC.SDD_or_HDD_list();
                        break;
                    case 6:
                        power = PC.PowerSupply_list();
                        break;
                    case 7:
                        cooling = PC.cooling_list();
                        break;
                    case 8:
                        pcCase = PC.pc_case_list();
                        break;
                    case 9:
                        //stop loop
                         Menu = false;
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("\nParts Receipt\n");
            Console.WriteLine($" CPU: {CPU} \n GPU: {GPU}\n Motherboard: {MB}\n Ram: {RAM}\n Storge: {Storge}\n Power Supply: {power}\n PC Cooling: {cooling}\n Case: {pcCase} ");

        }






    }
}
