namespace Dependency_Injection {
    internal class Meister {
        public void GibAnweisung() {
            Lehrling l = new();
            Schaufel schaufel = new();
            Loeffel loeffel = new();
            Bagger bagger = new();
            Random rnd = new Random();
            int x = rnd.Next(1, 4);
            switch (x) {
                case 1:
                l.GrabeLoch(schaufel);
                break;
                case 2:
                l.GrabeLoch(loeffel);
                break;
                case 3:
                l.GrabeLoch(bagger);
                break;
                default:
                break;
            }       
        }
    }
}
