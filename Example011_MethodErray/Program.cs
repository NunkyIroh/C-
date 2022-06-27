int[] array = { 1, 29, 38, 47, 56, 92, 65, 74, 843, 92 };

int n = array.Length;
int find = 92;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++; 
}