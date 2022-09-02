// данная программа показывает количество чётных чисел в массиве.
// создаем и заполняем массив
Console.WriteLine("введи размер массива");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];
int sum = 0; //для подсчета количества четных чисел
for(int i=0; i<N; i++)
   {
      array[i] = new Random().Next(100,1000);
      if(array[i] % 2 == 0)
         sum++;
      Console.WriteLine(array[i]);
   }
Console.WriteLine("количество четных чисел в массиве: " + sum);

