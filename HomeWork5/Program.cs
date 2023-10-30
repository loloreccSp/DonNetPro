using HomeWork5;
using System.Text;

namespace Homework5
{
    public class Program
    {

        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            //                  Завдання 1

            //try
            //{
            //    Console.WriteLine("Choose a play: ");
            //    Console.WriteLine("1. 'Брехня'; 2. 'Наймичка'; 3. 'Лісова пісня' ");
            //    int choose = Convert.ToInt32(Console.ReadLine());

            //    switch (choose)
            //    {
            //        case 1:
            //            var playLie = new Play("Брехня", "Володимир Винниченко", "п'єса", 1910);
            //            playLie.ShowInfo();
            //            GC.Collect();
            //            //Console.Read();
            //            break;
            //        case 2:
            //            var playBiddy = new Play("Наймичка", "Іван Карпенко-Карий", "п'єса", 1885);
            //            playBiddy.ShowInfo();
            //            GC.Collect();
            //            //Console.Read();
            //            break;
            //        case 3:
            //            var playForestsong = new Play("Лісова пісня", "Леся Українка", "п'єса", 1911);
            //            playForestsong.ShowInfo();
            //            GC.Collect();
            //            //Console.Read();
            //            break;
            //    }
            //}
            //catch (FormatException z)
            //{
            //    Console.WriteLine(z.Message);
            //}
            //catch (Exception x)
            //{
            //    Console.WriteLine(x.Message);
            //}

            //                  Завдання 2

            //using (Store newStore = new Store("Шалена ковбаска", "Цаплине 56", "м'ясний"))
            //{
            //    newStore.ShowInfo();
            //}

            //                  Завдання 3

            //Console.WriteLine("1 - Store; 2 - a Play");
            //int choose = Convert.ToInt32(Console.ReadLine());

            //switch (choose) 
            //{
            //    case 1:
            //        Store newStore = new Store("Шалена ковбаска", "Цаплине 56", "м'ясний");
            //        newStore.ShowInfo();
            //        GC.Collect();
            //        //Console.Read();
            //        break;
            //    case 2:
            //        try
            //        {
            //            Console.WriteLine("Choose a play: ");
            //            Console.WriteLine("1. 'Брехня'; 2. 'Наймичка'; 3. 'Лісова пісня' ");
            //            int choosePlay = Convert.ToInt32(Console.ReadLine());

            //            switch (choosePlay)
            //            {
            //                case 1:
            //                    using (Play playLie = new Play("Брехня", "Володимир Винниченко", "п'єса", 1910))
            //                    {
            //                        playLie.ShowInfo();
            //                    }
            //                    break;
            //                case 2:
            //                    using (Play playBiddy = new Play("Наймичка", "Іван Карпенко-Карий", "п'єса", 1885))
            //                    {
            //                        playBiddy.ShowInfo();
            //                    }
            //                    break;
            //                case 3:
            //                    using (Play playForestsong = new Play("Лісова пісня", "Леся Українка", "п'єса", 1911))
            //                    {
            //                        playForestsong.ShowInfo();
            //                    }
            //                    break;
            //            }
            //        }
            //        catch (FormatException z)
            //        {
            //            Console.WriteLine(z.Message);
            //        }
            //        catch (Exception x)
            //        {
            //            Console.WriteLine(x.Message);
            //        }

            //        break;
            //}
        }
    }
}
