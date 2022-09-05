//Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше
//либо равна 3 символам. Первоначальный массив можно задать с клавиатуры, либо задать на старте выполнения 
//алгоритма.

Console.WriteLine("Enter the massive size");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the elements of the massive via comma: ");

string[] massive = new string[size];
string test = Console.ReadLine();
string[] array = test.Split(',');

for(int i = 0; i < massive.Length; i++)
{
    massive[i] = array[i];
}

string[] massive2 = new string[size];

void FindStringInMass(string[] massive, string[] massive2)
{
    int j = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        string x = massive[i];
        if(x.Length <= 3)
        {
            massive2[j] = massive[i];
            j++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

FindStringInMass(massive, massive2);
Console.WriteLine("The result is: ");
PrintArray(massive2);

