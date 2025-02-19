using System.Text;

namespace InformationTheoryLab1
{
    public partial class MainForm : Form
    {
        public string action = "";
        public string algorithm = "";
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem editMenuItem;
        private ToolStripMenuItem helpMenuItem;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        public MainForm()
        {
            InitializeComponent();
            chooseActionBox.Items.Add("Шифрование");
            chooseActionBox.Items.Add("Дешифрование");
            chooseAlgorithmBox.Items.Add("«Столбцовый метод» улучшенный");
            chooseAlgorithmBox.Items.Add("«Виженера, самогенерирующийся ключ");
            // Подключение обработчика событий
            chooseActionBox.SelectedIndexChanged += new EventHandler(chooseActionBox_SelectedIndexChanged);
            chooseAlgorithmBox.SelectedIndexChanged += new EventHandler(chooseAlgorithmBox_SelectedIndexChanged);
            
            fileMenuItem = new ToolStripMenuItem("Файл");
            fileMenuItem.DropDownItems.Add("Открыть", null, OpenMenuItem_Click);
            fileMenuItem.DropDownItems.Add("Сохранить(резутьтат)", null, SaveMenuItem_Click);
            menuStrip1.Items.Add(fileMenuItem);
            openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
            saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };
        }
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Открытие диалогового окна для выбора файла
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получение текста из resultBox
                    string textToSave = resultBox.Text;

                    // Запись текста в выбранный файл
                    File.WriteAllText(saveFileDialog.FileName, textToSave, System.Text.Encoding.UTF8);

                    MessageBox.Show("Файл успешно сохранен!");
                }
            }
            catch (Exception ex)
            {
                // Обработка возможных исключений
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }
        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Открытие диалогового окна для выбора файла
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Чтение содержимого файла
                    string fileContent = File.ReadAllText(openFileDialog.FileName, Encoding.UTF8);

                    // Проверка наличия русских букв
                    
                    string russianLetters = new string(fileContent.Where(c => (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё').ToArray());
                    string englishLetters = new string(fileContent.Where(c => (c >= 'A' && c <= 'z')).ToArray());
                    // Запись русских букв в текстовое поле
                    if (algorithm == "«Столбцовый метод» улучшенный")
                    {
                        dataBox.Text = englishLetters;
                    }
                    else if (algorithm == "«Виженера, самогенерирующийся ключ")
                    {
                        dataBox.Text = russianLetters;
                    }
                    else
                    {
                        MessageBox.Show($"Выберите алгоритм для шифрования (дешифрирования)");
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка возможных исключений
                MessageBox.Show($"Ошибка при открытии файла: {ex.Message}");
            }
        }
        private void chooseActionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Делаем кнопку доступной, если выбрана хотя бы одна опция
                actionButton.Enabled = chooseActionBox.SelectedIndex != -1 && (chooseAlgorithmBox.SelectedIndex != -1);
                // Проверяем, выбран ли элемент в ComboBox
                if (chooseActionBox.SelectedItem == null)
                {
                    throw new InvalidOperationException("Не выбрано действие в ComboBox.");
                }

                // Получение выбранного действия из ComboBox
                action = chooseActionBox.SelectedItem.ToString();

                if (action == "Шифрование")
                {
                    dataLabel.Text = "Исходный текст";
                    actionButton.Text = "Шифровать";
                }
                else if (action == "Дешифрование")
                {
                    dataLabel.Text = "Шифротекст";
                    actionButton.Text = "Дешифрировать";
                }
                else
                {
                    MessageBox.Show($"Ошибка");
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Логирование и сообщение об ошибке
                MessageBox.Show($"Произошло исключение: {ex.Message}");
            }
        }

        private void chooseAlgorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Делаем кнопку доступной, если выбрана хотя бы одна опция
                algorithm = chooseAlgorithmBox.SelectedItem.ToString();
                actionButton.Enabled =
                    (chooseActionBox.SelectedIndex != -1) && (chooseAlgorithmBox.SelectedIndex != -1);
                // Проверяем, выбран ли элемент в ComboBox
                if (chooseActionBox.SelectedItem == null)
                {
                    throw new InvalidOperationException("Не выбрано действие (шифрование или дешифрирование)");
                }

                // Получение выбранного действия из ComboBox
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Логирование и сообщение об ошибке
                MessageBox.Show($"Произошло исключение: {ex.Message}");
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            try
            {
                string key = keyBox.Text;
                string plaintext = dataBox.Text;
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Пожалуйста, введите ключ.");
                    return;
                }

                if (string.IsNullOrEmpty(plaintext))
                {
                    MessageBox.Show("Пожалуйста, введите текст для шифрования или дешифрования.");
                    return;
                }
                
                if (algorithm == "«Столбцовый метод» улучшенный")
                {
                    string englishLettersKey = new string(key.Where(c => (c >= 'A' && c <= 'z')).ToArray());
                    string englishLettersData = new string(plaintext.Where(c => (c >= 'A' && c <= 'z')).ToArray());
                    key = englishLettersKey;
                    plaintext = englishLettersData;
                }
                else if (algorithm == "«Виженера, самогенерирующийся ключ")
                {
                    string russianLettersKey = new string(key.Where(c => (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё').ToArray());
                    string russianLettersData = new string(plaintext.Where(c => (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё').ToArray());
                    key = russianLettersKey;
                    plaintext = russianLettersData;
                }
                else
                {
                    MessageBox.Show($"Выберите алгоритм для шифрования (дешифрирования)");
                }
                if (string.IsNullOrEmpty(key))
                {
                    MessageBox.Show("Пожалуйста, введите КОРРЕКТНЫЙ ключ для ВЫБРАННОГО алгоритма.");
                    return;
                }

                if (string.IsNullOrEmpty(plaintext))
                {
                    MessageBox.Show("Пожалуйста, введите КОРРЕКТНЫЙ текст для ВЫБРАННОГО алгоритма.");
                    return;
                }
                
                string res = "";
                if (action == "Шифрование" && algorithm == "«Столбцовый метод» улучшенный")
                {
                    res = ColumnarTranspositionEncrypt(plaintext, key);
                }

                if (action == "Дешифрование" && algorithm == "«Столбцовый метод» улучшенный")
                {
                    res = ColumnarTranspositionDecrypt(plaintext, key);
                }

                if (action == "Шифрование" && algorithm == "«Виженера, самогенерирующийся ключ")
                {
                    res = VigenereEncrypt(plaintext, key);
                }

                if (action == "Дешифрование" && algorithm == "«Виженера, самогенерирующийся ключ")
                {
                    res = VigenereDecrypt(plaintext, key);
                }

                resultBox.Text = res;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошло исключение: {ex.Message}");
            }
        }

        //дешифрирование столбцами
        static int GetAmountOfRows(string text, int[] keyOrder)
        {
            int amount = 0, row = 1;
            try
            {
                while (amount < text.Length)
                {
                    amount = amount + Array.IndexOf(keyOrder, row) + 1;
                    row++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в GetAmountOfRows: {ex.Message}");
            }

            return row - 1;
        }

        static string ColumnarTranspositionDecrypt(string text, string key)
        {
            int i = 0;
            int[] keyOrder = GetAlphabetOrder(key);
            int amountOfRows = GetAmountOfRows(text, keyOrder);
            char[,] matrix = new char[key.Length, amountOfRows];
            //List<List<char>> matrix = new List<List<char>>();
            try
            {
                for (int row = 1; row <= key.Length; row++)
                {
                    for (int line = 0; line < amountOfRows; line++)
                    {
                        //тут
                        if (Array.IndexOf(keyOrder, row) <= Array.IndexOf(keyOrder, line + 1) && i < text.Length)
                        {
                            //тут
                            matrix[Array.IndexOf(keyOrder, row), line] = text[i];
                            i++;
                        }
                        else
                        {
                            matrix[Array.IndexOf(keyOrder, row), line] = ' ';
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в ColumnarTranspositionDecrypt: {ex.Message}");
            }

            //до сюда все ок
            string result = MakeStringByColumnsD(matrix, key, keyOrder, amountOfRows);
            return result;
        }

        static string MakeStringByColumnsD(char[,] matrix, string key, int[] keyOrder, int amountOfRows)
        {
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            int numLine = amountOfRows;
            int numRows = key.Length;
            try
            {
                for (int line = 0; line < numLine; line++)
                {
                    for (int row = 0; row < numRows; row++)
                    {
                        if (matrix[row, line] != ' ')
                        {
                            result.Append(matrix[row, line]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в ColumnarTranspositionDecrypt: {ex.Message}");
            }

            return result.ToString();
        }

        //шифрование столбцами
        static string MakeStringByColumns(List<List<char>> matrix, string key, int[] keyOrder)
        {
            // Создаем StringBuilder для накопления символов
            System.Text.StringBuilder result = new System.Text.StringBuilder();
            // Получаем максимальное количество строк в матрице
            int numRows = matrix.Count;
            // Предполагаем, что каждая строка имеет одинаковое количество столбцов
            int numCols = key.Length;
            try
            {
                // Проходим по каждому столбцу
                for (int col = 0; col < numCols; col++)
                {
                    // Проходим по каждой строке
                    for (int row = 0; row < numRows; row++)
                    {
                        if (matrix[row][Array.IndexOf(keyOrder, col + 1)] != ' ')
                        {
                            result.Append(matrix[row][Array.IndexOf(keyOrder, col + 1)]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в MakeStringByColumnsD: {ex.Message}");
            }

            return result.ToString();
        }

        static int[] GetAlphabetOrder(string word)
        {
            try
            {
                if (string.IsNullOrEmpty(word))
                {
                    throw new ArgumentException("Ключ не должен быть пустым или null.");
                }

                // Создаем массив для хранения порядковых номеров
                int[] order = new int[word.Length];

                // Создаем список кортежей для хранения букв и их исходных индексов
                List<Tuple<char, int>> letterPositions = new List<Tuple<char, int>>();

                // Заполняем список буквами и их исходными индексами
                for (int i = 0; i < word.Length; i++)
                {
                    letterPositions.Add(new Tuple<char, int>(word[i], i));
                }

                // Сортируем список по буквам в алфавитном порядке
                letterPositions.Sort((x, y) => x.Item1.CompareTo(y.Item1));

                // Заполняем массив порядковыми номерами
                for (int i = 0; i < letterPositions.Count; i++)
                {
                    order[letterPositions[i].Item2] = i + 1;
                }

                return order;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в GetAlphabetOrder: {ex.Message}");
                return new int[0];
            }
        }

        static string ColumnarTranspositionEncrypt(string text, string key)
        {
            try
            {
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(key))
                {
                    throw new ArgumentException("Текст и ключ не должны быть пустыми или null.");
                }

                int[] keyOrder = GetAlphabetOrder(key);
                // Создание таблицы шифрования
                List<List<char>> matrix = new List<List<char>>();
                int line = 1;
                for (int i = 0; i < text.Length;)
                {
                    List<char> tempLine = new List<char>();
                    int row = 0;
                    while (i < text.Length && (row <= Array.IndexOf(keyOrder, line)))
                    {
                        tempLine.Add(text[i]);
                        i++;
                        row++;
                    }

                    while (row < key.Length)
                    {
                        tempLine.Add(' ');
                        row++;
                    }

                    line++;
                    matrix.Add(tempLine);
                }

                string result = MakeStringByColumns(matrix, key, keyOrder);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в ColumnarTranspositionEncrypt");
                return "";
            }
        }


        static string VigenereEncrypt(string plaintext, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyLength = key.Length;

            try
            {
                for (int i = 0; i < plaintext.Length; i++)
                {
                    char textChar = plaintext[i];
                    char keyChar = key[i % keyLength];

                    if (char.IsLetter(textChar))
                    {
                        char offset = char.IsUpper(textChar) ? 'А' : 'а';
                        char encryptedChar = (char)(((textChar + keyChar - 2 * offset) % 32) + offset);
                        result.Append(encryptedChar);

                        // Расширение ключа на основе зашифрованного символа
                        key += encryptedChar;
                    }
                    else
                    {
                        result.Append(textChar);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в VigenereEncrypt: {ex.Message}");
            }

            return result.ToString();
        }

        static string VigenereDecrypt(string ciphertext, string key)
        {
            StringBuilder result = new StringBuilder();
            int keyLength = key.Length;

            try
            {
                for (int i = 0; i < ciphertext.Length; i++)
                {
                    char textChar = ciphertext[i];
                    char keyChar = key[i % keyLength];

                    if (char.IsLetter(textChar))
                    {
                        char offset = char.IsUpper(textChar) ? 'А' : 'а';
                        char decryptedChar = (char)(((textChar - keyChar + 32) % 32) + offset);
                        result.Append(decryptedChar);

                        // Расширение ключа на основе дешифрованного символа
                        key += textChar;
                    }
                    else
                    {
                        result.Append(textChar);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка в VigenereEncrypt: {ex.Message}");
            }

            return result.ToString();
        }
    }
}