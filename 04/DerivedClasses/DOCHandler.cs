using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class DOCHandler : AbstractHandler
    {
        public string name;
        private string content;
        public override void Open()
        {
            Console.WriteLine("Вы открыли файл {0}\n", name);
            if (content != null)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(content);
                Console.WriteLine();
                Console.ResetColor();
            }
            Console.WriteLine("1. изменить файл 2. Сохранить файл");

            switch (Console.ReadLine())
            {
                case "1":
                    Change();
                    break;
                case "2":
                    Save();
                    break;
                default:
                    break;
            }
        }

        public override void Create(string fileName)
        {
            name = fileName;
            Console.WriteLine($"Файл {name}.doc успешно создан\n");
            Console.WriteLine("1. изменить файл 2. Сохранить файл");

            switch (Console.ReadLine())
            {
                case "1":
                    Change();
                    break;
                case "2":
                    Save();
                    break;
                default:
                    break;
            }
        }

        public override void Change()
        {
            Console.WriteLine("Введите текст:");
            content = Console.ReadLine();
            Console.WriteLine($"Файл {name}.doc успешно изменен\n");
        }

        public override void Save()
        {
            Console.WriteLine($"Файл {name}.doc успешно сохранен\n");
        }

        public void main()
        {
            while (true)
            {
                if (name != null)
                {
                    Console.Write("1. Создать новый файл 2. Открыть файл 3. Вернуться в главное меню\n");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("Введите имя файла - ");
                            Create(Console.ReadLine());
                            break;
                        case "2":                            
                            Open();
                            break;
                        case "3":
                            goto Exit;
                        default:
                            Console.WriteLine("Вы ввели неверно");
                            break;
                    }
                }
                else
                {
                    Console.Write("Введите имя файла - ");
                    Create(Console.ReadLine());
                }
            }
            Exit:;
        }
    }
}
