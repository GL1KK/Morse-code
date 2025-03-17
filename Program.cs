using System;
using System.Collections.Generic;

    namespace Program
    {
        internal class Program
        {
            // ⁡⁢⁢⁣создаем словарь для английского алфавита⁡
            private static Dictionary<string, string> EnglishMorse = new Dictionary<string, string>{
                    {"A", ".-"}, {"B", "-..."}, {"C", "-.-."}, {"D", "-.."}, {"E", "."},
                    {"F", "..-."}, {"G", "--."}, {"H", "...."}, {"I", ".."}, {"J", ".---"},
                    {"K", "-.-"}, {"L", ".-.."}, {"M", "--"}, {"N", "-."}, {"O", "---"},
                    {"P", ".--."}, {"Q", "--.-"}, {"R", ".-."}, {"S", "..."}, {"T", "-"},
                    {"U", "..-"}, {"V", "...-"}, {"W", ".--"}, {"X", "-..-"}, {"Y", "-.--"},
                    {"Z", "--.."}
            };
            // ⁡⁢⁢⁣создаем словарь для русского алфавита⁡
            private static Dictionary<string, string> RussiaMorse = new Dictionary<string, string>{
                    {"А", ".-"}, {"Б", "-..."}, {"В", ".--"}, {"Г", "--."}, {"Д", "-..-"},
                    {"Е", "."}, {"Ё", "."}, {"Ж", "...-."}, {"З", "--.."}, {"И", ".."},
                    {"Й", ".---"}, {"К", "-.-"}, {"Л", ".-.."}, {"М", "--"}, {"Н", "-."},
                    {"О", "---"}, {"П", ".--."}, {"Р", ".-."}, {"С", "..."}, {"Т", "-"},
                    {"У", "..-"}, {"Ф", "..-."}, {"Х", "...."}, {"Ц", "-.-."}, {"Ч", "---."},
                    {"Ш", "----"}, {"Щ", "--.-."}, {"Ъ", "--.--"}, {"Ы", "-.--"}, {"Ь", "-..-"},
                    {"Э", "..-.."}, {"Ю", "..--"}, {"Я", ".-.-"}
            };

            static void Main(string[] args)
                {   
                    // ⁡⁢⁢⁣выьираем действие⁡
                    Console.WriteLine("Выберите действие: 1 - из морзе в текст, 2 - из текста в морзе");
                    int action = Convert.ToInt32(Console.ReadLine());
                    // ⁡⁢⁢⁡⁢⁢⁣выьираем алфавит⁡
                    Console.WriteLine("Выберите алфавит: 1 - английский, 2 - русский");
                    int alphabet = Convert.ToInt32(Console.ReadLine());
                    // ⁡⁢⁢⁡⁢⁢⁣если выбрано действие 1⁡
                    if(action == 1)
                    {
                        Console.WriteLine("Введите текст в морзе");
                        string morse = Console.ReadLine()!;
                        if(alphabet == 1)
                        {
                            Console.WriteLine(MorseToText(morse, EnglishMorse));
                        }
                        if(alphabet == 2)
                        {
                            Console.WriteLine(MorseToText(morse, RussiaMorse));
                        }

                    }
                    if(action == 2)
                    {
                        Console.WriteLine("Введите текст");
                        string text = Console.ReadLine()!;
                        if(alphabet == 1)
                        {
                            Console.WriteLine(TextToMorse(text, EnglishMorse));
                        }
                        if(alphabet == 2)
                        {
                            Console.WriteLine(TextToMorse(text, RussiaMorse));
                        }
                    }
                }   
                // ⁡⁢⁢⁡⁢⁢⁣функция для перевода текста в морзе⁡
               private static string TextToMorse(string text, Dictionary<string, string> morse)
                {
                    string result = "";
                    foreach (char c in text)
                    {
                        string upper = c.ToString().ToUpper();
                        if (morse.ContainsKey(upper))
                        {
                            result += morse[upper] + " ";
                        }
                        else if (c == ' ')
                        {
                            result += " ";
                        }
                    }
                    return result;
                }
                // ⁡⁢⁢⁡⁢⁢⁡⁢⁢⁣функция для перевода морзе в текст⁡⁡
                private static string MorseToText(string morse, Dictionary<string, string> alphabet)
                {
                    string result = "";
                    string[] words = morse.Split(new[] {"  "}, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (alphabet.ContainsValue(word))
                        {
                            foreach (var item in alphabet)

                            {
                                if (item.Value == word)
                                {
                                    result += item.Key;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                    // ⁡⁢⁢⁣удаляем лишние пробелы⁡
                    return result.Trim();
                }
        
            
        }
     }
    
    
    