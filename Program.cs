string[] FillArray(int n)
{
    string[] array = new string[4] {"1234", "15678", "-2", "computer science"};
    return array;
}


string[] array = FillArray(4);
for(int i=0; i<array.Length;i++)
{
    Console.WriteLine(array[i]);
}
Console.WriteLine();
Console.WriteLine("RESULT");
string[] PrintArray(string[] array)
{
    string[] array2 = new string[4];
    for(int i=0; i<array2.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            Console.Write(array[i]+" ");
        }
        else Console.Write("");

    }
    return array2;
}
string[] result = PrintArray(array);
