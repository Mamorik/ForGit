using System;

namespace ForGit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public  bool PassCheck(string pass)
        {
            if (pass.Length < 7 && pass.Length > 13)
            {
                return false;
            } else
            {
                for (int i = 0; i < pass.Length; i++)
                    if (char.IsUpper(pass[i]))
                    {
                        return true;
                    }
            }
            return false;

        }
    }
}
