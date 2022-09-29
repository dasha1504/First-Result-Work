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
string[] FillArray2(string[] array)
{
    string[] array2 = new string[4];
    for(int i=0; i<array2.Length; i++)
    {
        if(array2[i].Length <= 3)
        {
            array2[i] = array[i];
        }

    }
}
string[] result = FillArray2(array);
