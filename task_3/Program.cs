// Найдите разницу между максимальным и минимальным элементами массива.
Console.WriteLine("введите количество элементов в массиве ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

// заполняем массив случайными натуральными числами
for(int i=0; i<N; i++)
{
   array[i] = new Random().Next(1,1000000);
   Console.Write("  " + array[i]);
}

// находим минимальный и максимальный элементы в массиве
int min = array[0];
int max = array[0];
for(int i=0; i<N; i++)
{
   if(array[i] < min)
      min = array[i];
   if(array[i] > max)
      max = array[i];
}
int difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);