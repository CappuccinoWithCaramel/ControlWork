string[] Array(int size)
{
    string[] Array= new string[size];
    for (int i=0; i< size; i++)
    {
        Array[i]=Convert.ToString(Console.ReadLine())!;   
    }
    return Array;
}
void ShowArray(string[]Array)
{

    for (int i=0; i< Array.Length; i++)
    {
        Console.Write(Array[i] + ", ");
    }
    Console.WriteLine();
}

Console.WriteLine("Input Value of array");
int size=Convert.ToInt32(Console.ReadLine());


string[] myArray = Array(size);
ShowArray(myArray);
Console.WriteLine();
Searching(myArray);
