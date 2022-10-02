Console.WriteLine("Введите имя пользователя");
string UserName = Console.ReadLine();

if (UserName.ToLower() == "маша")
{
    Console.Write("Ура, это же веселая Маша!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(UserName);
}