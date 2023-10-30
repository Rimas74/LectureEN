namespace Task_6
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string vardas = "Vardenis Pavardenis";
            int age = 28;
            string pareigos = "Software Developer";
            string email = "E. Pastas: johndoe@example.com";
            string telefonas = "Tel.: +1 123-456-7890";
            Console.WriteLine($"Vardas:{vardas}\n" +
                $"Amzius:{age}\n" +
                $"Emailas:{email}\n" +
                $"Telefonas:{telefonas}\n" +
                $"Pareigos:{pareigos}");
            }
        }
    }