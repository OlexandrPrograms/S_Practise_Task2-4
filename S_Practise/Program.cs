using System.Text.Json;

namespace S_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            List<Album> albums = new List<Album>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(
                    "============================\n" +
                    " 1. Додати альбом\n" +
                    " 2. Показати всі альбоми\n" +
                    " 3. Зберегти альбоми\n" +
                    " 4. Завантажити альбоми\n" +
                    " 0. Вийти\n" +
                    "============================");
                string choice = Console.ReadLine() ?? string.Empty;
                
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("============================");
                        Console.Write("Введіть назву альбому: ");
                        string title = Console.ReadLine() ?? string.Empty;
                        Console.Write("Введіть виконавця: ");
                        string artist = Console.ReadLine() ?? string.Empty;
                        Console.Write("Введіть рік випуску: ");
                        int year = int.TryParse(Console.ReadLine(), out int y) ? y : 0;
                        Console.Write("Введіть тривалість (у хвилинах): ");
                        int duration = int.TryParse(Console.ReadLine(), out int d) ? d : 0;
                        Console.Write("Введіть студію: ");
                        string studio = Console.ReadLine() ?? string.Empty;

                        albums.Add(new Album(title, artist, year, duration, studio));
                        Console.WriteLine("Альбом додано успішно.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("============================");
                        foreach (var album in albums)
                            Console.WriteLine(album);
                        Console.WriteLine("============================");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                    case "3":
                        string jsonString = JsonSerializer.Serialize(albums);
                        File.WriteAllText("albums.json", jsonString);
                        Console.WriteLine("Альбоми збережено успішно.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                    case "4":
                        string jsonFromFile = File.ReadAllText("albums.json");
                        albums = JsonSerializer.Deserialize<List<Album>>(jsonFromFile) ?? new List<Album>();
                        Console.WriteLine("Альбоми завантажено успішно.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                        Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
