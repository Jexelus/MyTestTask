using System.Text;

namespace TestTaskV2
{
    internal interface IPrintList
    {
        public static string PrintList(List<int> list)
        {
            StringBuilder sb = new StringBuilder();

            foreach(int item in list)
            {
                if (item != list[list.Count - 1])
                {
                    sb.AppendFormat("{0} ", item.ToString());
                }
                else
                {
                    sb.AppendFormat("{0}", item.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
