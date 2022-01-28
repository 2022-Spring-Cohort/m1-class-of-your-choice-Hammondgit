using System;

namespace template_csharp_class_of_your_choice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gobal variables
            ComputerParts PC = new ComputerParts();

            string m0 = "Do you perf Intel(1) or AMD(2)?";


            string CPU = "";
            string GPU = "";
            string MB = "";
            string RAM = "";
            string Storge = "";
            string power = "";
            string cooling = "";
            string pcCase = "";

            //Getting the customers cpu brand
            Console.WriteLine(m0);
            string cpuBrand = PC.cpu_brand();
            Console.WriteLine(cpuBrand);// x - test done 


            // Getting the customers cpu
            if (cpuBrand == "Intel")
            {
                CPU = PC.Intel_CPUlist();
                
            }
            else
            {
                CPU = PC.AMD_CPUlist();
               
            }



            //-----------------------------------

            GPU = PC.GPU_List();
           


            //------------------------------------

            MB = PC.motherboard_list();
           

            //------------------------------------

            RAM = PC.Ram_list();
            

            //------------------------------------

            Storge = PC.SDD_or_HDD_list();
           

            //-------------------------------------

            power = PC.PowerSupply_list();
          

            //-------------------------------------

            cooling = PC.cooling_list();
          

            //-------------------------------------

            pcCase = PC.pc_case_list();

            //-------------------------------------



            Console.Clear();
            Console.WriteLine("\nParts Receipt\n");
            Console.WriteLine($" CPU: {CPU}\n GPU: {GPU}\n Motherboard: {MB}\n Ram: {RAM}\n Storge: {Storge}\n Power Supply: {power}\n PC Cooling: {cooling}\n Case: {pcCase} ");

        }






    }
}
