namespace Task_02;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        string[] menuOptions =
        {
            "P - Print numbers",
            "A - Add a number",
            "M - Display mean of the numbers",
            "S - Display the smallest number",
            "L - Display the largest number",
            "Q - Quit"
        };

        for (int i = 0; i < menuOptions.Length; i++)
            Console.WriteLine(menuOptions[i]);
        do
        {
            Console.WriteLine();

            Console.Write("Enter your choice: ");
            char choice = Console.ReadLine().ToUpper()[0];
            
            Console.WriteLine();

            switch (choice)
            {
                case 'P':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("Numbers in the list: [");
                        for (int i = 0; i < numbers.Count; i++)
                            if (i < numbers.Count - 1)
                                Console.Write(numbers[i] + ", ");
                            else
                                Console.Write(numbers[i]);
                        Console.Write("]");
                        Console.WriteLine();
                    }

                    break;
                case 'A':
                    Console.Write("Enter a number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == num)
                        {
                            Console.WriteLine("The number is already in the list.");
                            break;
                        }
                    }

                    numbers.Add(num);
                    Console.WriteLine($"{num} added to the list.");
                    break;
                case 'M':

                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data.");
                    }

                    int total = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        total += numbers[i];
                    }

                    double mean = Convert.ToDouble(total) / numbers.Count;

                    Console.WriteLine($"The mean of the numbers is: {mean}");
                    break;
                case 'S':
                    Console.WriteLine("Your Choice is  S");
                    break;
                case 'L':
                    Console.WriteLine("Your Choice is  L");
                    break;
                case 'Q':
                    Console.WriteLine("GoodBy");
                    break;
                default:
                    Console.WriteLine("Unknown selection, please try again.");
                    break;
            }
        } while (true);
    }
}