namespace _007_ClasseSingleton
{
    class EsSingleton
    {
        public int val = 0;
        private static EsSingleton instace = null;

        private EsSingleton()
        {

        }

        private EsSingleton(int val)
        {
            this.val = val;
        }

        public static EsSingleton GetEsSingleton(int valore)
        {
            if (instace == null)
            {
                instace = new EsSingleton(valore);
            }
            else
            {
                instace.val = valore;
            }
            return instace;
        }
    }
}
