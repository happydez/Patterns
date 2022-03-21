using System.Collections;

namespace Pattern.Iterator
{
    public class Program
    {
        public static void Main()
        {
            var wrs = new ServerRecords(5);

            wrs[0] = new RecordData("bhop_badges", "client_1", "ID:0:0001", 138, new TimeSpan(0, 10, 38));
            wrs[1] = new RecordData("bhop_badges", "client_2", "ID:0:0002", 74, new TimeSpan(0, 9, 42));
            wrs[2] = new RecordData("bhop_badges", "client_3", "ID:0:0003", 521, new TimeSpan(0, 13, 11));
            wrs[3] = new RecordData("bhop_badges", "client_4", "ID:0:0004", 13, new TimeSpan(0, 7, 52));
            wrs[4] = new RecordData("bhop_badges", "client_5", "ID:0:0005", 22, new TimeSpan(0, 15, 21));

            IEnumerable records = wrs as IEnumerable;
            IEnumerator serverManagment = records.GetEnumerator();

            while (serverManagment.MoveNext())
            {
                #nullable disable
                RecordData recordData = serverManagment.Current as RecordData;

                Console.WriteLine($"Client {recordData.Client} [{recordData.ID}] has a rank of {recordData.Rank}");
                Console.WriteLine($"The {recordData.Map} map is completed in {recordData.Time}");
                
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}