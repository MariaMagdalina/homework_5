// программа находит сумму четных элементов одномерного массива, стоящих на нечётных позициях 
Console.Write("Введите размер массива ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N]; 
int sum = 0;
for(int i=0; i<N; i++)
 {
   array[i] = new Random().Next(0,1000000);
   Console.WriteLine(array[i]);
   if((array[i] % 2 == 0) && (i % 2) != 0)
      sum = sum + array[i];
 }
Console.WriteLine("сумма четных элементов массива, стоящих на нечётных позициях, равна " + sum);