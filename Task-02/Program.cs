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
            "C - Clear the numbers",
            "F - Search for the value of the specified number",
            "X - Display the number of occurrences of the specified number",
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
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data.");
                    }

                    int smallest = numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        if (numbers[i] < smallest)
                            smallest = numbers[i];
                    }

                    Console.WriteLine($"The smallest number in the list is: {smallest}");
                    break;
                case 'L':
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data.");
                    }

                    int largest = numbers[0];
                    for (int i = 1; i < numbers.Count; i++)
                    {
                        if (numbers[i] > largest)
                            largest = numbers[i];
                    }

                    Console.WriteLine($"The largest number in the list is: {largest}");
                    break;
                case 'C':
                    numbers.Clear();
                    Console.WriteLine("The list has been cleared.");
                    break;
                case 'F':
                    Console.Write("Enter a number to search for: ");
                    int searchNum = Convert.ToInt32(Console.ReadLine());

                    bool found = false;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == searchNum)
                        {
                            Console.WriteLine($"{searchNum} is found in the list.");
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                        Console.WriteLine($"{searchNum} is not found in the list.");
                    break;
                case 'X':
                    Console.Write("Enter a number to search for occurrences: ");
                    int countNum = Convert.ToInt32(Console.ReadLine());

                    int occurrences = 0;
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == countNum)
                            occurrences++;
                    }

                    Console.WriteLine($"{countNum} occurs {occurrences} times in the list.");
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