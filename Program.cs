using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                
                FileStream fs = new FileStream("Salestrans.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs);
                int nsales = 0;
                //input 1
                Class_1 obj_1 = new Class_1();
                Console.Write("Name:");
                obj_1.name = Console.ReadLine();

                Console.Write("Sales: ");
                obj_1.sales = Int32.Parse(Console.ReadLine());
                nosales.nosale(obj_1.sales, nsales);
                //2
                Class_1 obj_2 = new Class_1();
                Console.Write("Name:");
                obj_2.name = Console.ReadLine();

                Console.Write("Sales: ");
                obj_2.sales = Int32.Parse(Console.ReadLine());
                nosales.nosale(obj_2.sales, nsales);
                //3
                Class_1 obj_3 = new Class_1();
                Console.Write("Name:");
                obj_3.name = Console.ReadLine();


                Console.Write("Sales: ");
                obj_3.sales = Int32.Parse(Console.ReadLine());
                nosales.nosale(obj_3.sales, nsales);

                //4
                Class_1 obj_4 = new Class_1();
                Console.Write("Name:");
                obj_4.name = Console.ReadLine();

                Console.Write("Sales: ");
                obj_4.sales = Int32.Parse(Console.ReadLine());
                nosales.nosale(obj_4.sales, nsales);


                //5
                Class_1 obj_5 = new Class_1();
                Console.Write("Name:");
                obj_5.name = Console.ReadLine();


                Console.Write("Sales: ");
                obj_5.sales = Int32.Parse(Console.ReadLine());
                nosales.nosale(obj_5.sales, nsales);


                int total = obj_1.sales + obj_2.sales + obj_3.sales + obj_4.sales + obj_5.sales;
                int a = Add.Addsales(total);
                Console.WriteLine("Total Sales: {0}", a);

                double b = ave.Average(total);
                Console.WriteLine("Average: {0}",b);

                Console.WriteLine("No Sales: "+nsales);
                
                //file handling
                sw.WriteLine("FirstName: " + obj_1.name);
                sw.WriteLine("sales: " + obj_1.sales);
                sw.WriteLine("SecondName: " + obj_2.name);
                sw.WriteLine("sales: " + obj_2.sales);
                sw.WriteLine("ThirdName: " + obj_3.name);
                sw.WriteLine("sales: " + obj_3.sales);
                sw.WriteLine("FourthName: " + obj_4.name);
                sw.WriteLine("sales: " + obj_4.sales);
                sw.WriteLine("FifthName: " + obj_5.name);
                sw.WriteLine("sales: " + obj_5.sales);

                sw.WriteLine("Total Sales: " + a);
                sw.WriteLine("Total Average: " + b);
                sw.WriteLine("No Sales: " + nsales);



                sw.Close();
                fs.Close();
                


            }
            catch
            {
                Console.WriteLine("Error");


            }

            Console.ReadKey();

        }
    }
}
