//Вариант1 

//int numberA = 3; // ввели целое int число
//int numberB = 5;
//Console.WriteLine(numberA+numberB); 

// int numberA = 3; // ввели целое int число
// int numberB = 5;
// int result = numberA+numberB; // ввели новыю переменную для суммы чисел
// Console.WriteLine(result); 

// счет случайных чисел
int numberA = new Random(). Next(1,10); // любое число от 1 до 9
Console.WriteLine(numberA); // показывает какое число выбралось
int numberB = new Random(). Next(1,10);
Console.WriteLine(numberB); 
int result = numberA+numberB; // ввели новыю переменную для суммы чисел
Console.WriteLine(result); 