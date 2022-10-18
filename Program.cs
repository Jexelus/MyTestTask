using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;
using System.Text;

Random rnd = new Random();

void MassPrint(List<int> A)
{
    StringBuilder str = new StringBuilder();
    foreach (int i in A)
    {
        str.AppendFormat("{0} ", i);
    }
    Console.WriteLine(str);
}

//body
List<int> package = new List<int>();

int elementsCount = rnd.Next(20, 101);
int tempListElement;

do
{
    tempListElement = rnd.Next(-100, 101);
    if (package.Count == 0)
    {
        package.Add(tempListElement);
    }
    else
    {
        if (package.Contains(tempListElement))
        {
            continue;
        }
        else
        {
            package.Add(tempListElement);
        }
    }

} while (package.Count != elementsCount);

MassPrint(package);

int keySortChoise = rnd.Next(1, 3);

switch (keySortChoise)
{
    case 1:
        {
            Console.WriteLine("Сортировка методом Хоара");
            Sorting.SortHoara(package, 0, package.Count - 1);
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
