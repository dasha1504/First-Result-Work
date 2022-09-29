string[] FillArray(int n)
{
    string[] array = new string[4] {"1234", "1567", "-2", "computer science"};
    return array;
}


string[] array = FillArray(4);
for(int i=0; i<array.Length;i++)
{
    Console.WriteLine(array[i]);
}
