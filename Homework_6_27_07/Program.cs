namespace Homework_6_27_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, enter the string : ");
            string enterStr = Console.ReadLine();

            Console.Write("Enter second  string : ");
            string enterStr2 = Console.ReadLine();

            bool isEqual = true; 

            foreach(char i in enterStr)
            {
                if (enterStr2.Contains(i))
                {
                    enterStr2.Replace(i,'.');
                }
                else
                {
                    isEqual = false;
                }
            }
            Console.WriteLine("Is string 2 composed of letters in string 1? : " + isEqual);
        }
    }
}