void FillArray(int[] collection)
{
    int Lenght= collection.Lenght;
    int index = 0;
    while (index < Lenght)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collectioin, int find)
{
    int count = collectioin.Length;
    int index = 0;
    int position = 0;// -1
    while (index < count)
    {
        if(Collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;

PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);