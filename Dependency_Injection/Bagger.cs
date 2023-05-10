namespace Dependency_Injection {
    internal class Bagger : IGrabable {
        public void Buddel() {
            Console.Write("Baggerei: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(":)\t");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine($"Lehrling Hashcode: {this.GetHashCode()}");
            Console.WriteLine("");
        }
    }
}
