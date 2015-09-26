using System;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            ConfigureCUI();
            ShowEnvironmentDetails();
            Console.ReadKey();
        }
        private static void ConfigureCUI() {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.CursorSize = 100;
            Console.Title = "Console Magic";
        }

        static void ShowEnvironmentDetails() {
            foreach (string drive in Environment.GetLogicalDrives()) {
                Console.WriteLine("Drive: {0}", drive);
            }
            Console.WriteLine(" O S : {0}", Environment.OSVersion); 
            Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount); 
            Console.WriteLine(".Net version {0}", Environment.Version); 
        }
    }
}
