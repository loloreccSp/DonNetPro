

namespace HomeWork5
{
    public class Play : IDisposable
    {
        public string TitlePlay { get; set; }
        public string FullName { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Play(string titlePlay, string fullName, string genre, int year)
        {
            TitlePlay = titlePlay;
            FullName = fullName;
            Genre = genre;
            Year = year;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"This play is called '{TitlePlay}', genre of {Genre}. The play was written in {Year}, tt`s author was {FullName}");
        }

        //v2
        public void Dispose()
        {    
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nA play was disposed!");
            Console.ForegroundColor = ConsoleColor.White;           
        }
        //v2
        ~Play() 
        {
            Dispose();
        }

        //v1
        //~Play()
        //{
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("\nA play was disposed!");
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }
}
