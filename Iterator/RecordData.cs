namespace Pattern.Iterator
{
    public class RecordData
    {
        public string Map { get; private set; }
        public string Client { get; private set; }
        public string ID { get; private set; }
        public int Rank { get; private set; }
        public TimeSpan Time { get; private set; }

        public RecordData(string map, string client, string id, int rank, TimeSpan time)
        {
            this.Map = map;
            this.Client = client;
            this.ID = id;
            this.Rank = rank;
            this.Time = time;
        }

    }
}
