namespace TestTaskV2
{
    class ListGenerator
    {

        public List<int> GenList()
        {
            List<int> list = new List<int>();
            Random rnd = new Random();
            do
            {
                int temp = rnd.Next(-100, 101);
                if (list.Contains(temp) == false)
                {
                    list.Add(temp);
                }
            } while (rnd.Next(20, 100) != list.Count);
            return list;
        }
    }
}
