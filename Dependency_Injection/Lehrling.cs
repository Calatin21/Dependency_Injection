namespace Dependency_Injection {
    internal class Lehrling {
        public void GrabeLoch(IGrabable grabwerkzeug) {
            if (grabwerkzeug is Bagger) {
                Console.WriteLine("Lehrling sagt: Nice mit dem bagger wollte ich schon immer baggern!");
            } else if (grabwerkzeug is Loeffel) {
                Console.WriteLine("Lehrling sagt: Nein, mit nem Löffel, Meister was soll dass denn?");
            }
            grabwerkzeug.Buddel();
        }
    }
}
