using System;
 
namespace vtoraya_cifra
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите трехзначное число: ");
            int chislo = Convert.ToInt32(Console.ReadLine());
            string chislo_string = Convert.ToString(chislo);
            Console.WriteLine("Вторая цифра этого числа: " + chislo_string[1]);
        }
    }
}


