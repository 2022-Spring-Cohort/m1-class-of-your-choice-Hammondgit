using System;

namespace template_csharp_class_of_your_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gobal variables
            ComputerParts PC = new ComputerParts();

            bool Menu = true;



            while (Menu == true)
            {
                Console.Clear();
                //menu
                Console.WriteLine("Welcome to bulding your own PC!\nChoose the numbers on the screen for your parts\nGO DOWN in order though 1-9 for a compatible build\nWE ARE NOT RESPOBISBLE for incompatible parts\n ");

                Console.WriteLine("1.CPU\n2.GPU\n3.Motherboard\n4.RAM\n5.Storge\n6.cooling\n7.power Supply\n8.Case\n9.Print your build ");

              
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
                             PC.Intel_CPUlist();

                        }
                        else
                        {

                            PC.AMD_CPU_list();

                        }

                        break;
                    case 2:

                        PC.GPU_List();

                        break;
                    case 3:
                        PC.motherboard_list();
                        break;
                    case 4:
                         PC.Ram_list();
                        break;
                    case 5:
                        PC.SDD_or_HDD_list();
                        break;
                    case 6:
                        PC.cooling_list();
                        break;
                    case 7:
                        PC.PowerSupply_list();
                        break;
                    case 8:
                        PC.pc_case_list();
                        break;
                    case 9:
                        
                        Menu = false;
                        break;
                }
       
            }

            Console.Clear();
            Console.WriteLine("\nParts Receipt\n");
            Console.WriteLine(PC.ToString());

        }






    }
}
