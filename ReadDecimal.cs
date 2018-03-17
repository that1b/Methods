static decimal ReadDecimal(string prompt)
        {
            bool valid;
            decimal input;

            do
            {
                Console.Write(prompt);
                valid = decimal.TryParse(Console.ReadLine(), out input);
                if (!valid)
                    Console.WriteLine("Моля въведете десетична дроб.");
            }
            while (!valid);
            return input;
}
