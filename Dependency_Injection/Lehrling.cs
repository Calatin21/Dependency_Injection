namespace Dependency_Injection {
    internal class Lehrling {
        public void GrabeLoch(IGrabable grabwerkzeug) {
            grabwerkzeug.Buddel();
        }
    }
}
