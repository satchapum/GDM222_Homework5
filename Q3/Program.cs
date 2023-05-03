class Program
{
    static void Main()
    {
        int letters = int.Parse(Console.ReadLine());

        int digits = int.Parse(Console.ReadLine());

        string lastCode = new string('A', letters) + new string('0', digits);


        int maximumProduct = (letters * 26) * (digits * 10);
        int count = 0;
        
        string product = Console.ReadLine();
        IDictionary<string, string> productID = new Dictionary<string, string>();
        productID.Add(lastCode,product);
        
        while (true)
        {
            product = Console.ReadLine();

            if (product.ToLower() == "stop")
            {
                break;
            }

            if (count >= maximumProduct)
            {
                count = 0;
                lastCode = new string('A', letters) + new string('0', digits);
                productID.Add(lastCode,product);
                continue;
            }

            string code = IncrementCode(lastCode, letters, digits);
            productID.Add(code,product);
            lastCode = code;
        }

        string searchCode = Console.ReadLine();

        bool found = false;
        foreach (KeyValuePair<string, string> kvp in productID)
        {
            if (searchCode == kvp.Key)
            {
                Console.WriteLine(kvp.Value);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Not found!");
        }
    }

    static string IncrementCode(string code, int letters, int digits)
    {
        char[] codeArray = code.ToCharArray();
        int lastIndex = letters + digits - 1;

        for (int i = lastIndex; i >= 0; i--)
        {
            char c = codeArray[i];

            if (char.IsDigit(c))
            {
                if (c == '9')
                {
                    codeArray[i] = '0';

                    if (i == 0)
                    {
                        return null;
                    }
                }
                else
                {
                    codeArray[i] = (char)(c + 1);
                    break;
                }
            }
            else if (char.IsLetter(c))
            {
                if (c == 'Z')
                {
                    codeArray[i] = 'A';
                }
                else
                {
                    codeArray[i] = (char)(c + 1);
                    break;
                }
            }
        }
        return new string(codeArray);
    }
}
