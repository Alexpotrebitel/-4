
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int GetSum (int num)
{
    int sum=0;
    for (int current=1;current<=num;current++)
        
      sum+=current;
      
     return sum;
     
}
Console.Write("INPUT A NUMBER");
int a=Convert.ToInt32(Console.ReadLine());

int result=GetSum(a);
Console.WriteLine(result);
*/
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*int faktarial (int N)
{
    int proizv=1;
    for (int current=1;current<=N;current++)
        
      proizv=proizv*current;
      
     return proizv;
     
}
Console.Write("INPUT A NUMBER");
int a=Convert.ToInt32(Console.ReadLine());
int result=faktarial(a);
Console.WriteLine(result);
*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.кроме 0.
/*int Number(int num)
{
int count=0;
    while(num!=0)
    {
        num=num/10;
        count++;
    }
    return  count;
}
Console.Write("INPUT A NUMBER");
int a=Convert.ToInt32(Console.ReadLine());
int result=Number(a);
Console.WriteLine(result);
*/

//массив
int [] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array=new int [size];
    for(int i=0; i<size;i++)
    {
        array[i]=new Random().Next(minValue,maxValue+1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.Write(array[i]+" ");
        Console.WriteLine();
    }
}
Console.Write("Input a Length array");
int Length=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a minimal value");
int min=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a maximal value");
int max=Convert.ToInt32(Console.ReadLine());

int [] newArray=CreateRandomArray(Length,min, max);
ShowArray(CreateRandomArray(Length,min, max));
