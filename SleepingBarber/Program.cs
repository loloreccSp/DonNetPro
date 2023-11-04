using SleepingBarber;
using System.Text;

namespace HomeWork7
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;


            for (int i = 1; i < 6; i++)
            {
                Hairdresser_s barber = new Hairdresser_s(i);
            }


        }
    }
}