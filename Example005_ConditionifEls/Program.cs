Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()== "морти")
{
    Console.WriteLine("Опять ты, Морти!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
