namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            var console = ServerConsole.CreateServerConsole();

            console.StartConsole();

            console.PrintToServer("Hello", $"Time: {DateTime.Now}", $"New Year in {(new DateTime(DateTime.Now.Year, 12, 31) - DateTime.Now).Days} days!");

            console.StopConsole();
        }
    }
}