namespace HomeWork_17
{
    class Program
    {
        static string filePath = @"../../../exchange_rates.csv";
        static Dictionary<string, decimal> exchangeRates = new();

        static void Main(string[] args)
        {
            LoadExchangeRates();
            while (true)
            {
                Console.WriteLine("Currency Exchange Rate Menu");
                Console.WriteLine("1. Get exchange rate by currency code");
                Console.WriteLine("2. Show all exchange rates (sorted by code)");
                Console.WriteLine("3. Show all exchange rates (sorted by value)");
                Console.WriteLine("4. Add or update a currency");
                Console.WriteLine("5. Delete a currency");
                Console.WriteLine("6. Exit and save changes");
                Console.Write("Choose an option (1-6): ");
                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        GetExchangeRate();
                        break;
                    case "2":
                        ShowAllRates(sortByCode: true);
                        break;
                    case "3":
                        ShowAllRates(sortByCode: false);
                        break;
                    case "4":
                        AddOrUpdateCurrency();
                        break;
                    case "5":
                        DeleteCurrency();
                        break;
                    case "6":
                        SaveExchangeRates();
                        Console.WriteLine("Done!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                        break;
                }
            }
        }

        static void LoadExchangeRates()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Exchange rate file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath).Skip(1);
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 2 && decimal.TryParse(parts[1], out decimal rate))
                {
                    string currencyCode = parts[0].ToUpper();
                    exchangeRates[currencyCode] = rate;
                }
            }
        }
        static void SaveExchangeRates()
        {
            var lines = new List<string> { "CurrencyCode,Rate" }; 
            foreach (var fxRateInfo in exchangeRates)
            {
                lines.Add($"{fxRateInfo.Key},{fxRateInfo.Value}");
            }

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("All changes have been saved.");
        }

        static void GetExchangeRate()
        {
            Console.Write("Enter currency code (e.g. USD): ");
            string code = Console.ReadLine().ToUpper();

            if (exchangeRates.TryGetValue(code, out decimal rate))
            {
                Console.WriteLine($"The exchange rate for {code} is {rate} GEL.");
            }
            else
            {
                Console.WriteLine("This currency code does not exist.");
            }
        }

        static void ShowAllRates(bool sortByCode)
        {
            Console.WriteLine("All Exchange Rates");

            var sortedRates = sortByCode
                ? exchangeRates.OrderBy(x => x.Key)
                : exchangeRates.OrderBy(x => x.Value);

            foreach (var pair in sortedRates)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value} GEL");
            }
        }

        static void AddOrUpdateCurrency()
        {
            Console.Write("Enter the currency code (e.g. USD): ");
            string code = Console.ReadLine().ToUpper();

            Console.Write("Enter the exchange rate in GEL: ");
            string rateInput = Console.ReadLine();

            if (decimal.TryParse(rateInput, out decimal rate))
            {
                if (exchangeRates.ContainsKey(code))
                {
                    Console.WriteLine($"Updated {code} from {exchangeRates[code]} to {rate}");
                }
                else
                {
                    Console.WriteLine($"Added new currency: {code} = {rate}");
                }

                exchangeRates[code] = rate;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid decimal number for the rate.");
            }
        }

        static void DeleteCurrency()
        {
            Console.Write("Enter the currency code you want to delete: ");
            string code = Console.ReadLine().ToUpper();

            if (exchangeRates.Remove(code))
            {
                Console.WriteLine($"{code} has been removed.");
            }
            else
            {
                Console.WriteLine("Currency code not found.");
            }
        }
    }
}
