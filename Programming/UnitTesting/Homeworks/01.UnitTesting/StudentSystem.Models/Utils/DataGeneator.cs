namespace StudentSystem.Models.Utils
{
    using System.Threading;

    public static class DataGenerator
    {
        private static int idCounter;

        static DataGenerator()
        {
            idCounter = 10000;
        }

        public static int GenerateId()
        {
            return Interlocked.Increment(ref idCounter);
        }
    }
}
