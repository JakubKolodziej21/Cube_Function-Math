using System;

namespace Funkcja_Sześcienna
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przyjmowanie wartości
            Console.WriteLine("Dana jest funkcja sześcienna");
            Console.Write("Podaj a:  ");
            string A = Console.ReadLine();

            Console.Write("Podaj b:  ");
            string B = Console.ReadLine();

            Console.Write("Podaj c:  ");
            string C = Console.ReadLine();

            Console.Write("Podaj d:  ");
            string D = Console.ReadLine();


            //Konwertujemy zmienną tekstową na zmienno-przecinkową

            double a = Convert.ToDouble(A);
            double b = Convert.ToDouble(B);
            double c = Convert.ToDouble(C);
            double d = Convert.ToDouble(D);


            //Obliczamy argumenty w,p,q,Delta

            double w = (-b) / (3 * a);

            double p = ((3 * a * (Math.Pow(w, 2))) + (2 * b * w) + c) / a;

            double q = ((a * (Math.Pow(w, 3))) + (b * (Math.Pow(w, 2))) + (c * w) + d) / a;

            double delta = ((Math.Pow(q, 2)) / 4) + ((Math.Pow(p, 3)) / 27);

            //Za pomocą "if else" dokonujemy obliczeń w zależności od wyniku delty
            Console.WriteLine("w = "+w);
            Console.WriteLine("p = "+p);
            Console.WriteLine("q = "+q);
            Console.WriteLine("delta = "+delta);




            if (delta > 0)//Test -2,1,0,7
            {
                double u = Math.Cbrt((-q / 2) + Math.Sqrt(delta));
                double v = Math.Cbrt((-q / 2) - Math.Sqrt(delta));
                double rzeczywista = (-0.5) * (u + v) + w;
                double urojona = (Math.Sqrt(3)) / 2 * (u - v);
                
                
                double x1 = u + v + w; //Pierwiastek rzeczywisty 

                
                Console.WriteLine("Wartość pierwiastka rzeczywistego wynosi: " + x1);
                Console.WriteLine("Liczby zespolone sprzężone:");

                Console.WriteLine("x2=" + rzeczywista+"+"+urojona+"i");
                Console.WriteLine("x3=" + rzeczywista + "-" + urojona + "i");

            }
            else if (delta == 0)//Test 1 ,3 ,0 ,-4
            {
                double x1 = w - (2 * (Math.Cbrt(q / 2)));
                double x23 = w + (Math.Cbrt(q / 2));
                Console.WriteLine("Wynikiem równania są dwa pierwiastki rzeczywiste: " + x1 + " oraz drugi-podwójny: " + x23); 


            }
            else// Test 3, -3,-2, 1
            {
                double fi = Math.Acos((3*q/(2*p*Math.Sqrt(-p / 3))));
                double pi = 3.1415926535;

                double x1 = w + (2 * Math.Sqrt(-p / 3.0) * Math.Cos(fi / 3.0));
                double x2 = w + 2 * Math.Sqrt(-p / 3.0) * Math.Cos((fi / 3.0) + ((2 / 3.0) * pi));
                double x3 = w + (2 * Math.Sqrt(-p / 3.0) * Math.Cos((fi / 3.0) + (4 / 3.0 * pi)));

                Console.WriteLine("pi = " + pi);
                Console.WriteLine("fi = " + fi);
                


                Console.WriteLine("Trzy pierwiastki rzeczywiste:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
                Console.WriteLine("x3 = " + x3);



            }





        }
    }
}

