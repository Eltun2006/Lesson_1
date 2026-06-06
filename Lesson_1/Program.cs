namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task 1 
            ///Istifadəçi klaviaturadan 1 ilə 100 arasında bir ədəd daxil edir.
            //Əgər ədəd 3-ə bölünürsə, ekrana Fizz sözü çıxarılmalıdır. Əgər
            //ədəd 5-ə bölünürsə , ekrana Buzz sözü çıxarılmalıdır. Əgər ədəd
            //həm 3-ə bölünürsə, həm də 5-ə bölünürsə, ekrana Fizz və Buzz
            //çıxarılmalıdır. Əgər ədəd nə 3-ə, nə də 5-ə bölünürsə, ədədin özü
            //çıxarılmalıdır.
            Console.WriteLine("Zehmet olmasa, 1-100 arasi eded daxil edin: ");
            int eded = int.Parse(Console.ReadLine());

            if (eded % 3 == 0 && eded % 5 == 0)
                Console.WriteLine("Fizz ve Buzz");
            else if (eded % 3 == 0)
                Console.WriteLine("Fizz");
            else if (eded % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(eded);
            #endregion

            #region Task 2
            //İstifadəçi klaviaturadan iki ədəd daxil edir. Birinci ədəd dəyər,
            //ikinci ədəd isə
            //hesablanması tələb olunan faizdir.Məsələn, klaviaturadan 90 və 10
            //daxil edilib. 90 - ın 10 faizini göstərmək lazımdır.Nəticə 9 - dur.

            Console.WriteLine("Zehmet olmasa, Birinci ededi daxil edin: ");
            int eded1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Zehmet olmasa, faizi daxil edin: ");
            int eded2 = int.Parse(Console.ReadLine());

            int netice = (eded1 * eded2) / 100;
            Console.WriteLine(netice);
            #endregion

            #region Task 3
            //İstifadəçi klaviaturadan temperatur göstəricilərini daxil edir.
            //İstifadəçinin seçiminə əsasən proqram temperaturu Fahrenheit-dən
            //Celsius - a və ya əksinə çevirməlidir.

            Console.WriteLine("1) Celsius," +
                              "2) Fahrenheit");

            int secim = int.Parse(Console.ReadLine());

            Console.WriteLine("Zehmet olmasa, temperaturu daxil edin: ");
            int temp = int.Parse(Console.ReadLine());

            if(secim == 1)
            {
                int farenhait = (temp * 9 / 5) + 32;
                Console.WriteLine($"{temp} celsius {farenhait} farenhaite beraberdir");
            }
            else if(secim == 2)
            {
                int selsi = (temp - 32) * 5 / 9;
                Console.WriteLine($"{temp} farenhait {selsi} selsiye beraberdir");
            }
            else
                Console.WriteLine("Bele bir secim yoxdur");
            #endregion

        }
    }
}
