int[] array = { 11, 12, 31, 141, 51, 16, 17, 81, 91 };

int n = array.Length;
int find = 141;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    // index=index+1;
    index++;
}
 Console.WriteLine();