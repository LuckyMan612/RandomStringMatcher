using System;
using System.Text;

class Program
{
    static void Main()
    {
        int proby = 0;
        Console.WriteLine("Write your words.");
        string longText = Console.ReadLine();
        bool dalej = true;
        var watch = System.Diagnostics.Stopwatch.StartNew();
        while (dalej)
        {
            string randomString = GenerateRandomString(longText.Length);
            Console.WriteLine(randomString + $" | {proby}");
            proby++;
            if (randomString == longText)
            {
                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                float elapsedMinutes = elapsedMs / 60000;
                Console.WriteLine($"Po {proby} probach, udalo sie. Po {elapsedMinutes} minutach.");
                dalej = false; break;
            }
        }
    }

    static string GenerateRandomString(int length)
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";
        StringBuilder result = new StringBuilder(length);
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            result.Append(chars[random.Next(chars.Length)]);
        }

        return result.ToString();
    }
}
