

namespace SleepingBarber
{
    public class Hairdresser_s
    {
        static Semaphore barber = new Semaphore(1, 1);
        Thread hairThread;
        public Hairdresser_s(int amout)
        {
            hairThread = new Thread(Room);
            hairThread.Name = $"Visitor {amout}";
            Console.WriteLine($"{hairThread.Name} going to barber");
            hairThread.Start();
        }

        public void Room()
        {
            while (true)
            {
                barber.WaitOne();

                Console.WriteLine($"{Thread.CurrentThread.Name} пришел");
                Thread.Sleep(1000);

                Console.WriteLine($"{Thread.CurrentThread.Name} разбудил парикмахера");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} стрижется");
                Thread.Sleep(1000);
                Console.WriteLine($"{Thread.CurrentThread.Name} Покидает парикмахера");



                Console.WriteLine($"Парикмахер засипает");
                Thread.Sleep(1000);

                barber.Release();

                Thread.CurrentThread.Join();

            }

        }
    }
}
