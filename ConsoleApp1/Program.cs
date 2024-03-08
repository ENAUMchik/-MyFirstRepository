using System.Drawing;
using System.Security.Cryptography.X509Certificates;

class MainClass
{


    public static void Main(string[] args)
    {
        int k = 0;
        while (k < 3)
        {
            (string name, string lastname, string login, bool havePet, double age, string[] favcolors) users;
            Console.WriteLine("Введите имя");
            users.name = Console.ReadLine();
            Console.WriteLine("Введите фамилию");
            users.lastname = Console.ReadLine();
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Количество символов в логине:");
            string[] loginLength = new string[login.Length];
            Console.WriteLine(login.Length);
            Console.WriteLine("Есть ли у Вас питомец?Да или нет?");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                users.havePet = true;
            }
            else
            {
                users.havePet = false;
            }
            Console.WriteLine("Укажите Ваш возраст");
            users.age = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите три Ваших любимых цвета");
            string[] favcolors = new string[3];
            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = Console.ReadLine();
            }
            k++;
        }
        
    }


    


}






