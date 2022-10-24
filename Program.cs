bool loop = true;

while (loop == true)
{
    Console.WriteLine("Which method would you like to call?\nShowCharacter\nCalculateRetail\nCelsius\nIsPrime\n");
    string method = Console.ReadLine();
    
    switch (method)
    {
        case "ShowCharacter":
            Console.Write("What is the word?: ");
            string word = Console.ReadLine();
            Console.Write("What character position would you like to find?: ");
            int position = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Character: {ShowCharacter(word, position)}");
            loop = false;
            break;

        case "CalculateRetail":
            Console.Write("What is the wholesale cost?: ");
            double wholesale = Convert.ToDouble(Console.ReadLine());
            Console.Write("What is the markup percentage: ");
            double markup = Convert.ToDouble(Console.ReadLine());
            
            Console.Write($"Retail price: ${CalculateRetail(wholesale, markup)}");
            loop = false;
            break;

        case "Celsius":
            for (double f = 80; f <= 100; f++)
            {
                Console.Write($"\nFahrenheit: {f} degrees   Celsius: {Celsius(f)} degrees");
            }
            loop = false;
            break;

        case "IsPrime":
            Console.Write("What number would you like to test: ");
            int integer = Convert.ToInt32(Console.ReadLine());
            Console.Write(IsPrime(integer));
            loop = false;
            break;
        
        default:
            Console.Write("\nThat is not a method here. Try again.\n");
            break;
    }
}

static char ShowCharacter(string word, int position)
{
    int csPosition = position - 1;
    char character = word[csPosition];
    return character;
}

static double CalculateRetail(double wholesale, double markup)
{
    double newMarkup = markup / 100;
    double retail = wholesale * (1 + newMarkup);
    return retail;
}

static double Celsius(double fahrenheit)
{
    double c = Math.Round((5.0 / 9.0) * (fahrenheit - 32.0), 3);
    return c;
}

static bool IsPrime(int integer)
{
    //Found this solution at https://www.tutorialspoint.com/Chash-Program-to-check-if-a-number-is-prime-or-not#:~:text=To%20calculate%20whether%20a%20number,0%2C%20between%20the%20number%20itself.&text=A%20counter%20a%20is%20also,1%20and%20the%20number%20itself.
    int n = integer, a = 0;
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            a++;
        }
    }
    
    bool answer;

    if (a == 2)
    {
        answer = true;
    }
    else
    {
        answer = false;
    }
    return answer;
}
