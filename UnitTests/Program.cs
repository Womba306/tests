using System;
using NUnitLite;

namespace ConsoleApp6.Tests
{
    public class Program
    {
        public static int Main(string[] args)
        {
            // AutoRun запускает все тесты, обнаруженные в этом сборке.
            return new AutoRun().Execute(args);
        }
    }
}
