using static System.Console;
using static System.Convert;
using static System.Math;


int n, counter = 0;

n = ToInt32(ReadLine());

for (int i = 0; i < n; i++)
{
    string str = ReadLine();
    var arr = str.Split(" ");
    int p = ToInt32(arr[0]);
    int q = ToInt32(arr[1]);
    if (q - p >= 2)
    {
        counter++;
    }
}

WriteLine(counter);

