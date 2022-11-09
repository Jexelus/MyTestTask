namespace TestTaskV2 
{
    class Program : ListGenerator, IPrintList, IListSorting, IDataSendToServer
    {
        static void Main()
        {
            Random ChoiseSwitcher = new Random();
            ListGenerator ListGendrator = new ListGenerator();
            List<int> SendingData = ListGendrator.GenList();
            Console.WriteLine(IPrintList.PrintList(SendingData));
            switch (ChoiseSwitcher.Next(1, 3))
            {
                case 1:
                    {
                        Console.WriteLine("Сортировка методом Хоара");
                        IListSorting.SortHoara(SendingData, 0, SendingData.Count-1);
                        Console.WriteLine(IPrintList.PrintList(SendingData));
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Сортировка методом Пузырька");
                        SendingData = IListSorting.SortBubble(SendingData);
                        Console.WriteLine(IPrintList.PrintList(SendingData));
                        break;
                    }
            }
            IDataSendToServer.DataSender(SendingData);
            Console.ReadLine();
        }
    }
}