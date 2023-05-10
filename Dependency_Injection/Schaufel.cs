namespace Dependency_Injection {
    internal class Schaufel : IGrabable {
        public void Buddel() {
            Console.Write("Schaufelei: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(":I\t");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine($"Lehrling Hashcode: {this.GetHashCode()}");
            Console.WriteLine("");
        }
    }
}
