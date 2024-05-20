namespace Assignment_3._1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a string");
            string userInput = Console.ReadLine();
            Console.WriteLine($"\"{userInput}\" contains {NumberOfSpaces(userInput)} spaces");
        }

        static int NumberOfSpaces(string userInput) 
        {
            int spaces = 0;
            for(int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == ' ') 
                {
                    spaces++;
                }
            }
            return spaces;
        }
    }
}
