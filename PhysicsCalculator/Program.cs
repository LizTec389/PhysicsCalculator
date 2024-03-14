

namespace CalculatorPhysics
{
    class Program
       {
        static void Main(string[] args)
           {
       

        Console.Write("Enter the height (in meters): ");
        double height = Convert.ToDouble(Console.ReadLine());

            double gravity = 9.8; //Acceleration due to gravity in m / s²
            double speedFinal = Math.Sqrt(2 * gravity * height);
      
            Console.WriteLine($"Final velocity is: {speedFinal} m/s");
                    Console.ReadKey();
      }
   }
}

