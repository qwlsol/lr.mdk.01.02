using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantLibrary;

namespace UnitTestLR3
{
    public partial class MainForm : Form
    {
        private List<Dish> allDishes = new List<Dish>();
        private Dictionary<string, int> orderStatistics = new Dictionary<string, int>();
        private StorageDish storageDish;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
            LoadData();
        }

        private void InitializeCustomComponents()
        {
            this.Text = "Тестирование библиотеки DishLibrary";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создаем тестовые кнопки
            CreateTestButtons();

            // Инициализируем статистику
            orderStatistics["Закуски"] = 0;
            orderStatistics["Горячее"] = 0;
            orderStatistics["Десерты"] = 0;
            orderStatistics["Напитки"] = 0;
        }

        private void CreateTestButtons()
        {
            // Кнопка создания тестовых данных
            Button btnCreateTestData = new Button
            {
                Text = "Создать тестовые данные",
                Location = new Point(650, 50),
                Size = new Size(200, 30)
            };
            btnCreateTestData.Click += BtnCreateTestData_Click;
            this.Controls.Add(btnCreateTestData);

            // Кнопка тестирования исключений
            Button btnTestExceptions = new Button
            {
                Text = "Тест исключений",
                Location = new Point(650, 90),
                Size = new Size(200, 30)
            };
            btnTestExceptions.Click += BtnTestExceptions_Click;
            this.Controls.Add(btnTestExceptions);

            // Кнопка статистики
            Button btnShowStats = new Button
            {
                Text = "Показать статистику",
                Location = new Point(650, 130),
                Size = new Size(200, 30)
            };
            btnShowStats.Click += BtnShowStats_Click;
            this.Controls.Add(btnShowStats);
        }

        private void LoadData()
        {
            try
            {
                storageDish = new StorageDish();
                allDishes = storageDish.LoadAllDish();

                // Заполняем группы
                var groups = allDishes.Select(d => d.Group).Distinct().OrderBy(g => g).ToList();
                listBoxGroups.Items.Clear();
                foreach (var group in groups)
                {
                    listBoxGroups.Items.Add(group);
                }

                lblStatus.Text = $"Загружено блюд: {allDishes.Count}";
                lblStatus.ForeColor = Color.Green;
            }
            catch (FileNotFoundException)
            {
                lblStatus.Text = "Файл данных не найден. Создайте тестовые данные!";
                lblStatus.ForeColor = Color.Red;
            }
            catch (DishDataException ex)
            {
                lblStatus.Text = $"Ошибка в данных: {ex.Message}";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show(ex.Message, "Ошибка загрузки",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Ошибка: {ex.Message}";
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItem == null) return;

            string selectedGroup = listBoxGroups.SelectedItem.ToString();
            var dishesInGroup = allDishes.Where(d => d.Group == selectedGroup).ToList();

            comboBoxDishes.Items.Clear();
            foreach (var dish in dishesInGroup)
            {
                comboBoxDishes.Items.Add(dish);
            }

            if (comboBoxDishes.Items.Count > 0)
            {
                comboBoxDishes.SelectedIndex = 0;
            }

            // Обновляем информацию о группе
            lblGroupInfo.Text = $"Блюд в группе: {dishesInGroup.Count}";
        }

        private void comboBoxDishes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDishes.SelectedItem is Dish selectedDish)
            {
                // Отображаем информацию
                textBoxInfo.Text = selectedDish.GetInfo();

                // Пытаемся загрузить изображение
                try
                {
                    if (!string.IsNullOrEmpty(selectedDish.Photo) && File.Exists(selectedDish.Photo))
                    {
                        pictureBoxDish.ImageLocation = selectedDish.Photo;
                        pictureBoxDish.Load();
                    }
                    else
                    {
                        // Создаем заглушку для изображения
                        Bitmap bmp = new Bitmap(200, 150);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.Clear(Color.LightGray);
                            g.DrawString("Нет изображения",
                                new Font("Arial", 12),
                                Brushes.Black,
                                new PointF(40, 60));
                        }
                        pictureBoxDish.Image = bmp;
                    }
                }
                catch (Exception ex)
                {
                    lblStatus.Text = $"Ошибка загрузки изображения: {ex.Message}";
                }
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxDishes.SelectedItem is Dish selectedDish &&
                listBoxGroups.SelectedItem != null)
            {
                int quantity = (int)numericUpDownQuantity.Value;

                // Обновляем статистику
                if (orderStatistics.ContainsKey(selectedDish.Group))
                {
                    orderStatistics[selectedDish.Group] += quantity;
                }

                // Добавляем информацию о заказе
                string orderInfo = $"[{DateTime.Now.ToShortTimeString()}] " +
                                  $"Заказано: {selectedDish.Name} x{quantity} " +
                                  $"на сумму {selectedDish.Price * quantity} руб.\n";

                textBoxOrderLog.AppendText(orderInfo);

                // Обновляем общую информацию
                textBoxInfo.AppendText($"\n\nЗАКАЗ:\n" +
                                      $"Количество: {quantity}\n" +
                                      $"Сумма: {selectedDish.Price * quantity} руб.");
            }
            else
            {
                MessageBox.Show("Выберите группу и блюдо!", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            textBoxOrderLog.Clear();
        }

        private void BtnCreateTestData_Click(object sender, EventArgs e)
        {
            try
            {
                storageDish.CreateTestData();
                MessageBox.Show("Тестовые данные успешно созданы!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Перезагружаем данные
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка создания тестовых данных: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTestExceptions_Click(object sender, EventArgs e)
        {
            // Тестируем создание блюда с некорректными данными
            try
            {
                Dish invalidDish = new Dish("", -100, "", "", "", "");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Поймано исключение: {ex.Message}\n\n" +
                               $"Тип: {ex.GetType().Name}\n" +
                               $"Параметр: {ex.ParamName}",
                               "Тест исключений",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }

            // Тестируем загрузку несуществующего файла
            try
            {
                StorageDish badStorage = new StorageDish("несуществующий_файл.csv");
                badStorage.LoadAllDish();
            }
            catch (DishDataException ex)
            {
                MessageBox.Show($"Поймано специализированное исключение:\n\n" +
                               $"Сообщение: {ex.Message}\n" +
                               $"Строка: {ex.LineNumber}\n" +
                               $"Внутреннее исключение: {ex.InnerException?.GetType().Name}",
                               "Тест DishDataException",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
        }

        private void BtnShowStats_Click(object sender, EventArgs e)
        {
            string stats = "СТАТИСТИКА ЗАКАЗОВ:\n\n";
            int total = 0;

            foreach (var kvp in orderStatistics)
            {
                stats += $"{kvp.Key}: {kvp.Value} порций\n";
                total += kvp.Value;
            }

            stats += $"\nВсего заказано порций: {total}";

            // Добавляем финансовую статистику
            int totalRevenue = allDishes.Sum(d => d.Price);
            stats += $"\n\nФИНАНСОВАЯ ИНФОРМАЦИЯ:\n";
            stats += $"Средняя цена блюда: {allDishes.Average(d => d.Price):F0} руб.\n";
            stats += $"Минимальная цена: {allDishes.Min(d => d.Price)} руб.\n";
            stats += $"Максимальная цена: {allDishes.Max(d => d.Price)} руб.";

            MessageBox.Show(stats, "Статистика",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
