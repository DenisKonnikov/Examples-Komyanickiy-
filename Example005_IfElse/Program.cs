Console.Write("Введите имя пользователя: ");// выводится на терминале 
string username = Console.ReadLine();// вводится в терминале
if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша!");
} 
else 
{
    Console.Write("Привет ");
    Console.WriteLine(username);
    
}