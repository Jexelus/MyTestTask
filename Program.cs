using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;
using System.Text;

Random rnd = new Random();

void MassPrint(int[] A)
{
    StringBuilder str = new StringBuilder();
    foreach (int i in A)
    {
        str.Append(i);
        str.Append(" ");
    }
    Console.WriteLine(str);
}

//body

List<int> package = new List<int>();

int[] packageConv;

int elementsCount = rnd.Next(20, 101);
int temp;

do
{
    temp = rnd.Next(-100, 101);
    if(package.Count == 0)
    {
        package.Add(temp);
    }
    else
    {
        if (package.Contains(temp))
        {
            continue;
        }
        else
        {
            package.Add(temp);
        }
    }

}while(package.Count != elementsCount);

packageConv = package.ToArray();
MassPrint(packageConv);

int keySortChoise = rnd.Next(1, 3);

switch (keySortChoise) 
{
    case 1:
        { 
            Console.WriteLine("Сортировка методом Хоара");
            Sorting.SortHoara(packageConv, 0, packageConv.Length - 1);
            MassPrint(packageConv);
            package = packageConv.ToList();
            Postreq.PostReqGen(package);
            break;
        }
    case 2:
        { 
            Console.WriteLine("Сортировка методом пузырька");
            packageConv = Sorting.SortBubble(packageConv);
            MassPrint(packageConv);
            package = packageConv.ToList();
            Postreq.PostReqGen(package);
            break;
        }
}






