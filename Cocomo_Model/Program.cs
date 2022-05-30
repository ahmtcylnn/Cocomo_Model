using System;

namespace Cocomo_Model
{
    public class Program
    {
        static void Main(string[] args)
        {

            discrete_project_model();
            semi_embedded_project_model();
            embedded_project();
          
            void discrete_project_model()
            {
                // Getting Input
                Console.WriteLine("Enter the number of lines of code");
                double s;
                s = Convert.ToDouble(Console.ReadLine());
                // Definition
                double a,b,c,d;
                a = 2.4;
                b=1.05;
                c = 2.5;
                d = 0.38;
                // workforce calculation
                double usAlma = Math.Pow(s, b);
                var isGucu = a * usAlma;
                // Development Process Calculation
                double usAlma2 = Math.Pow(isGucu, d);
                var gelistirmeSureci = c * usAlma2;
                // Average Number of Personnel Calculation
                var personelSayisi = isGucu / gelistirmeSureci;
                // Productivity
                var Verimlilik = s / isGucu;
                Console.WriteLine("Values ​​for the Discrete Project Model...");
                Console.WriteLine("Workforce: {0}", isGucu.ToString());
                Console.WriteLine("Development Process: {0}", gelistirmeSureci.ToString());
                Console.WriteLine("Average Number of Staff: {0}", personelSayisi.ToString());
                Console.WriteLine("Productivity: {0}", Verimlilik.ToString());
            }
            void semi_embedded_project_model()
            {
                // Getting Input
                Console.WriteLine("Enter the number of lines of code");
                double s;
                s = Convert.ToDouble(Console.ReadLine());
                // Definition
                double a, b, c, d;
                a = 3.0;
                b = 1.12;
                c = 2.5;
                d = 0.35;
                // workforce calculation
                double usAlma = Math.Pow(s, b);
                var isGucu = a * usAlma;
                // Development Process Calculation
                double usAlma2 = Math.Pow(isGucu, d);
                var gelistirmeSureci = c * usAlma2;
                // Average Number of Personnel Calculation
                var personelSayisi = isGucu / gelistirmeSureci;
                // Productivity
                var Verimlilik = s / isGucu;
                Console.WriteLine("Values ​​for the Semi-Embedded Project Model...");
                Console.WriteLine("Workforce: {0}", isGucu.ToString());
                Console.WriteLine("Development Process: {0}", gelistirmeSureci.ToString());
                Console.WriteLine("Average Number of Staff: {0}", personelSayisi.ToString());
                Console.WriteLine("Productivity: {0}", Verimlilik.ToString());
            }
            void embedded_project()
            {

                // Getting Input
                Console.WriteLine("Enter the number of lines of code");
                double s;
                s = Convert.ToDouble(Console.ReadLine());
                // Definition
                double a, b, c, d;
                a = 3.6;
                b = 1.20;
                c = 2.5;
                d = 0.32;
                // Workforce calculation
                double usAlma = Math.Pow(s, b);
                var isGucu = a * usAlma;
                // Development Process Calculation
                double usAlma2 = Math.Pow(isGucu, d);
                var gelistirmeSureci = c * usAlma2;
                // Average Number of Personnel Calculation
                var personelSayisi = isGucu / gelistirmeSureci;
                // Productivity
                var Verimlilik = s / isGucu;
                Console.WriteLine("Values ​​for Embedded Projects...");
                Console.WriteLine("Workforce: {0}", isGucu.ToString());
                Console.WriteLine("Development Process: {0}", gelistirmeSureci.ToString());
                Console.WriteLine("Average Number of Staff: {0}", personelSayisi.ToString());
                Console.WriteLine("Productivity: {0}", Verimlilik.ToString());


            }

            
        }
    }
}
