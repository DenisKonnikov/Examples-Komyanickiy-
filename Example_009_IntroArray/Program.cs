// Найти максмимум из 9 числел

// int Max(int arg1, int arg2, int arg3)
// {
//     int result = arg1; // определяем result как один из аргументов
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return (result);
// }
//     int[] array = { 1, 4, 6, 12, 54, 63, 3, 2, 64 };

// int result = Max(
//     Max(array[0], array[1], array[2],
//     Max(array[3], array[4], array[5],
//     Max(array[6], array[7], array[8])
// );

// Console.WriteLine(max);


int[] array = {1,32,37,7,55,4,27,8};

int n = array.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if(array[index]==find)
    {
        Console.WriteLine(index);
    }
    index=index+1;
}
