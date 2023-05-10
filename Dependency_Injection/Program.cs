namespace Dependency_Injection {
    internal class Program {
        static void Main(string[] args) {
            Meister m = new();
            for (int i = 0; i < 10; i++) {
                m.GibAnweisung();
            }
        }
    }
}