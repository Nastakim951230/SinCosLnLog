using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public double Sinus(double x)
        {
            double sin2 = ((1 - Math.Cos(2 * x)) / 2);
            if (x <= 90)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 90 && x <= 180)
            {
                return Math.Sqrt(sin2);
            }
            else if (x > 180 && x <= 270)
            {
                return -Math.Sqrt(sin2);
            }
            else if (x > 270 && x <= 360)
            {
                return Math.Sqrt(sin2);
            }
            else
            {
                return 0;
            }
        }
        public double Cosinus(double x)
        {
            double cos2 = 1 - Math.Pow(Sinus(x), 2);
            if (x <= 90)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 90 && x <= 180)
            {
                return -Math.Sqrt(cos2);
            }
            else if (x > 180 && x <= 270)
            {
                return Math.Sqrt(cos2);
            }
            else if (x > 270 && x <= 360)
            {
                return -Math.Sqrt(cos2);
            }
            else
            {
                return 0;
            }

        }

        public double Logarifm_Natural(double x)
        {
            double ln2;
            return  ln2= Math.Log(x)/Math.Log(Math.E);
        }
        public double Logorifm(double ocn, double x)
        {
            {
                double stepen = 0.1;
                while (Math.Pow(ocn, stepen) <= x)
                    stepen += 0.001;
                return stepen;
            }
        }

        public double SinCos(double x)
        {
            Program program = new Program();
            double rez;
             rez = (Math.Pow(((program.Sinus(x) + program.Cosinus(x)) + program.Cosinus(x)), 2));
            Console.WriteLine("(((sin({0})+cos({0}))+cos({0}))^2) = {1}", x, rez);
            return 0;

        }
        public double LogLn(double x)
        {
            Program program =new Program();
            double rez;
            rez = (program.Logarifm_Natural(x) * program.Logorifm(5, x));
            Console.WriteLine("(ln({0})*log5({0})) = {1}", x, rez);
            return 0;
        }
        static void Main(string[] args)
        {
          try
            {
                Console.Write("Введите x: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Program program = new Program();
                double rez=0;
                
            
                if (x<=0)
                {
                    program.SinCos(x);
                   
                }
                else
                {
                    program.LogLn(x);
                }
            }
            catch
            {

            }
        }
    }
}
