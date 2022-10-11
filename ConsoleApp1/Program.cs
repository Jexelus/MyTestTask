using System.Collections.Generic;
using System.Text.Json;
using System.Net.Http;

Random rnd = new Random();

void MassPrint(int[] A)
{
    string str =" ";
    for (int i = 0; i < A.Length; i++)
    {
        str += A[i].ToString() + " ";
    }
    Console.WriteLine(str);
}

//body

List<int> temp = new List<int>();
List<int> package = new List<int>();  
List<int> trash = new List<int>();

int[] packageConv;


for (int i = 0; i < rnd.Next(35, 100); i++)
{
    temp.Add(rnd.Next(-100,100));
}

foreach (int unq in temp)
{
    if (package.Contains(unq)) 
    {
        trash.Add(unq);
    }
    else
    {
        package.Add(unq);
    }
}

var anyDuplicate = package.GroupBy(x => x).Any(g => g.Count() > 1);
if (anyDuplicate == false)
{
    packageConv = package.ToArray();
    MassPrint(packageConv);

    int keySortChoise = rnd.Next(-100, 100);
    if (keySortChoise > 0)
    {
        Console.WriteLine("Сортировка методом Хоара");
        Sorting.Sort1(packageConv, 0, packageConv.Length - 1);
        MassPrint(packageConv);
        package = packageConv.ToList();
        Postreq.PostReqGen(package);
    }
    if (keySortChoise < 1)
    {
        Console.WriteLine("Сортировка методом пузырька");
        packageConv = Sorting.Sort2(packageConv);
        MassPrint(packageConv);
        package = packageConv.ToList();
        Postreq.PostReqGen(package);
    }

}
 



