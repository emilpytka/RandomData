namespace RandomData.Helpers
{
    public class IdentityGenerator
    {
        private int _currentNum = 0;
        private static IdentityGenerator _instance;
        public static IdentityGenerator Instance { get { return _instance ?? (_instance = new IdentityGenerator()); } }

        private IdentityGenerator()
        {
        }

        public int GetNextNum(int step)
        {
            _currentNum += step;
            return _currentNum;
        }
    }
}