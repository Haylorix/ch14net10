namespace HotReloading
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while (true) 
            {
                WriteLine("Goodbye, Hot Reload.");
                await Task.Delay(2000);
            }
        }
    }
}
