static int ReadInt(string prompt)
        {
            bool valid;
            int input;

            do
            {
                Console.Write(prompt);
                valid = int.TryParse(Console.ReadLine(), out input);
                if (!valid)
                    Console.WriteLine("Моля въведете цяло число.");
            }
            while (!valid);
return input;
