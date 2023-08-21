using Final___Magix.DataContext;

namespace DebugTestingEviro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testc = CardContext.Test();
            foreach (var i in testc)
            {
                Console.WriteLine(i);
            }
        }
    }
}