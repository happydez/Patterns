using System.Collections;

namespace Pattern.Iterator
{
    public class ServerManagment : IEnumerator
    {
        private ServerRecords records;
        private int current = -1;

        public ServerManagment(ServerRecords records)
        {
            this.records = records;   
        }

        public bool MoveNext()
        {
            if (current < records.Count - 1)
            {
                current++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            current = -1;
        }

        public object Current
        {
            get => records[current];
        }
    }
}
