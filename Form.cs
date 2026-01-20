namespace Rasul
{
    class Form
    {
        public static void GetForm()
        {
            System.Console.WriteLine("Enter login: ");
            string login = Console.ReadLine()!;
            System.Console.WriteLine("Enter email");
            string email = Console.ReadLine()!;
            System.Console.WriteLine($"Your name {login}\nE-mail: {email}");
        }
    }
}