using System.Collections;

namespace Pattern.Iterator
{
    public class ServerRecords : IEnumerable
    {
        private List<RecordData> records = new List<RecordData>();

        public ServerRecords()
        {

        }

        public ServerRecords(int count)
        {
            records = new List<RecordData>(count);
        }

        public RecordData this[int index]
        {
            get => records[index] ?? throw new IndexOutOfRangeException();
            set => records.Insert(index, value);
        }

        public int Count
        {
            get => records.Count;
        }

        public IEnumerator GetEnumerator() => new ServerManagment(this);
    }
}
