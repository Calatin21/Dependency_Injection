namespace Dependency_Injection {
    internal class Loeffel : IGrabable {
        public void Buddel() {
            Console.Write("Löffelei: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(":(\t");
            Console.ForegroundColor= ConsoleColor.Gray;
            Console.WriteLine($"Lehrling Hashcode: {this.GetHashCode()}");
            Console.WriteLine("");
        }
    }
}
