namespace Caesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your key: ");

            if (!int.TryParse(Console.ReadLine(), out int key))
            {
                Console.WriteLine("Enter a valid integer key.");
                return;
            }

            Console.Write("plaintext:  ");
            string? text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                return;
            }

            string cipherText = Encrypt(text, key);


            Console.WriteLine($"ciphertext: {cipherText}");
        }

        static string Encrypt(string text, int key)
        {
            char[] buffer = text.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];

                if (char.IsLetter(letter))
                {
                    char offset = char.IsUpper(letter) ? 'A' : 'a';

                    buffer[i] = (char)((((letter + key - offset) % 26) + 26) % 26 + offset);
                }
            }
            return new string(buffer);
        }
    }
}