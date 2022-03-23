namespace Singleton
{
    [Serializable]
    public class MaxSingletonObjects : Exception
    {
        public MaxSingletonObjects() { }
        public MaxSingletonObjects(string message) : base(message) { }
        public MaxSingletonObjects(string message, Exception inner) { }
    }

    public class ServerConsole
    {
        private static int _maxObjects = 1;

        #nullable disable
        [NonSerialized]
        private static ServerConsole _console = null;

        public bool ConsoleState { get; private set; } = false;

        protected ServerConsole() { }

        public static ServerConsole CreateServerConsole()
        {
            if (_console == null)
            {
                _console = new ServerConsole();
                _maxObjects--;
            }

            if (_maxObjects == -1)
                throw new MaxSingletonObjects();

            return _console;
        }

        public void PrintToServer(params string[] args)
        {
            if (ConsoleState)
            {
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }
        }

        public void StopConsole()
        {
            ConsoleState = false;
        }
        
        public void StartConsole()
        {
            ConsoleState = true;
        }
    }
}
