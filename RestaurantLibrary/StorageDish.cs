using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RestaurantLibrary
{
    public class StorageDish : IDish
    {
        private string filePath;
        private char separator = ';';

        public StorageDish() : this("data2.csv") { }

        public StorageDish(string path)
        {
            filePath = path;
        }
        public List<Dish> LoadAllDish()
        {
            List<Dish> allDish = new List<Dish>();

            // Проверяем существование файла
            if (!File.Exists(filePath))
            {
                // Пробуем найти файл в папке приложения
                string appPath = Path.Combine(Application.StartupPath, "data2.csv");
                if (File.Exists(appPath))
                {
                    filePath = appPath;
                }
                else
                {
                    throw new FileNotFoundException($"Файл данных не найден: {filePath}");
                }
            }

            try
            {
                using (StreamReader info = new StreamReader(filePath))
                {
                    string line;
                    int lineNumber = 0;

                    while ((line = info.ReadLine()) != null)
                    {
                        lineNumber++;

                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] lines = line.Split(separator);

                        if (lines.Length < 6)
                        {
                            throw new DishDataException(
                                $"Строка {lineNumber}: Недостаточно полей (ожидалось 6, получено {lines.Length})",
                                lineNumber);
                        }

                        try
                        {
                            Dish dish = new Dish(
                                lines[1].Trim(),           // Название
                                Convert.ToInt32(lines[2]), // Цена
                                lines[3].Trim(),           // Описание
                                lines[4].Trim(),           // Ингредиенты
                                lines[5].Trim(),           // Фото
                                lines[0].Trim()            // Группа
                            );

                            allDish.Add(dish);
                        }
                        catch (FormatException ex)
                        {
                            throw new DishDataException(
                                $"Строка {lineNumber}: Ошибка преобразования цены '{lines[2]}'",
                                lineNumber, ex);
                        }
                        catch (Exception ex)
                        {
                            throw new DishDataException(
                                $"Строка {lineNumber}: {ex.Message}",
                                lineNumber, ex);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                throw new DishDataException($"Ошибка чтения файла: {ex.Message}", 0, ex);
            }

            return allDish;
        }

        /// <summary>
        /// Сохранение тестовых данных в файл
        /// </summary>
        public void CreateTestData()
        {
            string[] testData = new string[]
            {
                "Закуски;Салат Цезарь;450;Классический салат с курицей;Курица, салат, соус, сухари;ceasar.jpg",
                "Закуски;Гренки с чесноком;150;Хрустящие ржаные гренки;Хлеб, чеснок, соль;grenki.jpg",
                "Закуски;Брускетта с томатами;280;Итальянская закуска;Хлеб, томаты, базилик, оливковое масло;bruschetta.jpg",
                "Горячее;Котлета по-киевски;350;Нежное куриное филе с маслом;Курица, масло, зелень;kiev.jpg"
            };

            File.WriteAllLines(filePath, testData);
        }
    }
}

