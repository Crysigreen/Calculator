namespace Calculator_client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var client = new HttpClient();
            var url = "https://localhost:7126/calculator";

            while (true)
            {
                Console.WriteLine("Available operations:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Select an operation (1-5): ");
                var operationChoice = Console.ReadLine();

                if (operationChoice == "5")
                {
                    break;
                }

                Console.WriteLine("First number:");
                var num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Second number:");
                var num2 = double.Parse(Console.ReadLine());

                string operation;
                switch (operationChoice)
                {
                    case "1":
                        operation = "addition";
                        break;
                    case "2":
                        operation = "subtraction";
                        break;
                    case "3":
                        operation = "multiplication";
                        break;
                    case "4":
                        operation = "divide";
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid operation choice");
                        continue;
                }

                var response = await client.GetAsync($"{url}/{operation}?x={num1}&y={num2}");
                var result = await response.Content.ReadAsStringAsync();

                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
