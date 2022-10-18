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
        str.AppendFormat("{0} ", i);
    }
    Console.WriteLine(str);
}

//body

List<int> packageTempList = new List<int>();
int[] package;

int elementsCount = rnd.Next(20, 101);
int tempListElement;

do
{
    tempListElement = rnd.Next(-100, 101);
    if (packageTempList.Count == 0)
    {
        packageTempList.Add(tempListElement);
    }
    else
    {
        if (packageTempList.Contains(tempListElement))
        {
            continue;
        }
        else
        {
            packageTempList.Add(tempListElement);
        }
    }

} while (packageTempList.Count != elementsCount);
package = packageTempList.ToArray();

MassPrint(package);

int keySortChoise = rnd.Next(1, 3);

switch (keySortChoise)
{
    case 1:
        {
            Console.WriteLine("Сортировка методом Хоара");
            Sorting.SortHoara(package, 0, package.Length - 1);
            MassPrint(package);
            Postreq.PostReqGen(package);
            break;
        }
    case 2:
        {
            Console.WriteLine("Сортировка методом пузырька");
            package = Sorting.SortBubble(package);
            MassPrint(package);
            Postreq.PostReqGen(package);
            break;
        }
}






