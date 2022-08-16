using System;

namespace SedBANK
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository repo = new Repository();
            repo.InitializeData();
            repo.Run();
        }
    }
}
