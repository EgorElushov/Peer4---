using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using FastColoredTextBoxNS;

namespace peer_4
{
    public partial class Notepad : Form
    {
        private readonly Dictionary<object, bool> _fileChange = new();
        private Font _currentFont;
        private int _fileCount = 1;
        private bool _isDark;

        /// <summary>
        ///     Метод инициализации формы.
        /// </summary>
        public Notepad()
        {
            InitializeComponent();
            _currentFont = SystemFonts.DefaultFont;
        }

        /// <summary>
        ///     Метод загрузки формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_Load(object sender, EventArgs e)
        {
            if (File.Exists(".settings"))
            {
                var lines = File.ReadAllLines(".settings");
                if (lines.Length >= 2)
                {
                    bool.TryParse(lines[1], out _isDark);
                    var timerTicks = 10000;
                    int.TryParse(lines[0], out timerTicks);
                    if (timerTicks > 0)
                        timerTextBox.Text = timerTicks.ToString();
                }
            }

            if (File.Exists(".file_list"))
            {
                var files = File.ReadAllLines(".file_list");
                foreach (var file in files)
                    if (File.Exists(file))
                    {
                        if (fileTabControl.TabPages.Contains(file1))
                            fileTabControl.TabPages.Remove(file1);
                        try
                        {
                            var filePage = new TabPage();
                            _fileCount++;
                            filePage.Name = file;
                            filePage.Text = Path.GetFileName(file);
                            if (file.EndsWith(".cs"))
                            {
                                FastColoredTextBox newTextBox = new();
                                newTextBox.Text = File.ReadAllText(file);
                                newTextBox.Width = 792;
                                newTextBox.Height = 392;
                                newTextBox.Margin = new Padding(3, 3, 3, 3);
                                newTextBox.SyntaxHighlighter.InitStyleSchema(Language.CSharp);
                                newTextBox.SyntaxHighlighter.CSharpSyntaxHighlight(newTextBox.Range);
                                newTextBox.ContextMenuStrip = contextMenu;

                                newTextBox.Parent = filePage;
                            }
                            else
                            {
                                var textBox = new RichTextBox
                                {
                                    Name = $"textField{_fileCount}",
                                    Width = 792,
                                    Height = 396,
                                    Margin = new Padding(3, 3, 3, 3),
                                    Font = _currentFont,
                                    ContextMenuStrip = contextMenu
                                };
                                if (file.EndsWith(".rtf"))
                                    textBox.LoadFile(file);
                                else
                                    textBox.Text = File.ReadAllText(file);
                                textBox.TextChanged += TextField_TextChanged;
                                textBox.Parent = filePage;
                            }

                            fileTabControl.TabPages.Add(filePage);
                            _fileChange[filePage] = false;
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message,
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
            }

            _fileChange[fileTabControl.TabPages[0]] = false;
            fileTabControl.TabPages[0].Controls[0].ContextMenuStrip = contextMenu;
            if (_isDark)
                foreach (Control objects in Controls)
                {
                    objects.BackColor = Color.DimGray;
                    objects.ForeColor = Color.AliceBlue;
                    foreach (Control objectsControl in objects.Controls)
                    {
                        objectsControl.BackColor = Color.DimGray;
                        objectsControl.ForeColor = Color.AliceBlue;
                        foreach (Control objectsControlControl in objectsControl.Controls)
                        {
                            objectsControlControl.BackColor = Color.DimGray;
                            objectsControlControl.ForeColor = Color.AliceBlue;
                        }
                    }
                }
            else
                foreach (Control objects in Controls)
                {
                    objects.BackColor = Color.White;
                    objects.ForeColor = Color.Black;
                    foreach (Control objectsControl in objects.Controls)
                    {
                        objectsControl.BackColor = Color.White;
                        objectsControl.ForeColor = Color.Black;
                        foreach (Control objectsControlControl in objectsControl.Controls)
                        {
                            objectsControlControl.BackColor = Color.White;
                            objectsControlControl.ForeColor = Color.Black;
                        }
                    }
                }

            if (_isDark)
                darkTheme.CheckState = CheckState.Checked;
        }

        /// <summary>
        ///     Метод закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (var streamWriter = new StreamWriter(".settings", false))
            {
                streamWriter.WriteLine(timerTextBox.Text);
                streamWriter.WriteLine(_isDark);
            }

            using (var streamWriter = new StreamWriter(".file_list", false))
            {
                foreach (TabPage file in fileTabControl.TabPages) streamWriter.WriteLine(file.Name);
            }

            using (var streamWriter = new StreamWriter(".пасхалка", false))
            {
                streamWriter.Write("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
            }
        }

        /// <summary>
        ///     Метод закрытия формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Notepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var file in _fileChange)
                if (file.Value)
                {
                    var dialogResult = MessageBox.Show(
                        $"Сохранить изменения в файле {Path.GetFileName(((TabPage)file.Key).Name)}?", "Сохранение",
                        MessageBoxButtons.YesNoCancel);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SaveAsFile(file.Key);
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        e.Cancel = true;
                        break;
                    }
                }
        }

        /// <summary>
        ///     Метод открытия файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            var filePage = new TabPage();
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "RTF Files|*.rtf|TXT files|*.txt|C# code|*.cs";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName == string.Empty)
                return;
            try
            {
                _fileCount++;
                filePage.Name = openFileDialog.FileName;
                filePage.Text = Path.GetFileName(openFileDialog.FileName);
                if (openFileDialog.FileName.EndsWith(".cs"))
                {
                    FastColoredTextBox newTextBox = new();
                    newTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                    newTextBox.Width = 792;
                    newTextBox.Height = 392;
                    newTextBox.Margin = new Padding(3, 3, 3, 3);
                    newTextBox.SyntaxHighlighter.InitStyleSchema(Language.CSharp);
                    newTextBox.SyntaxHighlighter.CSharpSyntaxHighlight(newTextBox.Range);
                    newTextBox.ContextMenuStrip = contextMenu;

                    newTextBox.Parent = filePage;
                }
                else
                {
                    var textBox = new RichTextBox
                    {
                        Name = $"textField{_fileCount}",
                        Width = 792,
                        Height = 396,
                        Margin = new Padding(3, 3, 3, 3),
                        Font = _currentFont,
                        ContextMenuStrip = contextMenu,
                        BackColor = _isDark ? Color.DimGray : Color.White,
                        ForeColor = _isDark ? Color.AliceBlue : Color.Black
                    };
                    if (openFileDialog.FileName.EndsWith(".rtf"))
                        textBox.LoadFile(openFileDialog.FileName);
                    else
                        textBox.Text = File.ReadAllText(openFileDialog.FileName);
                    textBox.TextChanged += TextField_TextChanged;
                    textBox.Parent = filePage;
                }

                fileTabControl.TabPages.Add(filePage);
                _fileChange[filePage] = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        ///     Сохранение файла как.
        /// </summary>
        /// <param name="sender"></param>
        private void SaveAsFile(object sender)
        {
            var saveFileDialog = new SaveFileDialog();
            var selectedTab = (TabPage)sender;

            saveFileDialog.FileName = selectedTab.Name;
            saveFileDialog.DefaultExt = "*.rtf";
            saveFileDialog.Filter = "RTF Files|*.rtf|TXT files|*.txt|C# code|*.cs|All files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK &&
                saveFileDialog.FileName.Length > 0)
                SaveFile(sender, saveFileDialog.FileName);
        }

        /// <summary>
        ///     Метод сохранения файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="name">Имя файла.</param>
        private void SaveFile(object sender, string name)
        {
            var selectedTab = (TabPage)sender;

            selectedTab.Text = Path.GetFileName(name);
            if (selectedTab.Name.EndsWith(".rtf"))
                try
                {
                    var richTextBox = (RichTextBox)selectedTab.Controls[0];
                    richTextBox.SaveFile(name);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
                try
                {
                    var streamWriter = new StreamWriter(name, false);
                    streamWriter.Write(selectedTab.Controls[0].Text);
                    streamWriter.Close();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


            _fileChange[sender] = false;
        }

        /// <summary>
        ///     Сохранить файл как.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            SaveAsFile(selectedTab);
        }

        /// <summary>
        ///     Метод проверки файла на изменение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextField_TextChanged(object sender, EventArgs e)
        {
            var textBox = (RichTextBox)sender;
            if (!_fileChange[textBox.Parent])
            {
                var newText = new StringBuilder();
                newText.Append("*");
                newText.Append(textBox.Parent.Text);
                textBox.Parent.Text = newText.ToString();
            }

            _fileChange[textBox.Parent] = true;
        }

        /// <summary>
        ///     метод форматирование текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormatMenuItem_Click(object sender, EventArgs e)
        {
            var fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                _currentFont = fontDialog.Font;
                foreach (TabPage tab in fileTabControl.TabPages)
                {
                    var richTextBox = (RichTextBox)tab.Controls[0];
                    richTextBox.Font = fontDialog.Font;
                }
            }
        }

        /// <summary>
        ///     Тик таймера автосохранения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveTimer_Tick(object sender, EventArgs e)
        {
            foreach (TabPage tab in fileTabControl.TabPages)
                if (_fileChange[tab])
                    SaveFile(tab, tab.Name);
        }

        /// <summary>
        ///     Сохранение элемента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            SaveFile(selectedTab, selectedTab.Name);
        }

        /// <summary>
        ///     Метод проверки интервала таймера на соответствие числу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        /// <summary>
        ///     Метод установки интервала таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerTextBox_TextChanged(object sender, EventArgs e)
        {
            var interval = 100000;
            if (int.TryParse(timerTextBox.Text, out interval))
                if (interval > 0)
                    saveTimer.Interval = interval;
        }

        /// <summary>
        ///     Метод копирования текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Copy_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            var textBox = (RichTextBox)selectedTab.Controls[0];
            if (!string.IsNullOrEmpty(textBox.SelectedText))
                Clipboard.SetText(textBox.SelectedText);
        }

        /// <summary>
        ///     Метод вставки текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Paste_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            var textBox = (RichTextBox)selectedTab.Controls[0];
            textBox.SelectedText = Clipboard.GetText();
        }

        /// <summary>
        ///     Метод вырезания текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cut_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            var textBox = (RichTextBox)selectedTab.Controls[0];
            if (!string.IsNullOrEmpty(textBox.SelectedText))
                Clipboard.SetText(textBox.SelectedText);
            textBox.SelectedText = "";
        }

        /// <summary>
        ///     Метод выделения текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            var textBox = (RichTextBox)selectedTab.Controls[0];
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.Text.Length;
            textBox.Focus();
        }

        /// <summary>
        ///     Меток сохраниения всех окрытых вкладок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAll_Click(object sender, EventArgs e)
        {
            foreach (var file in _fileChange)
                if (file.Value)
                {
                    var tabPage = (TabPage)file.Key;
                    SaveFile(file.Key, tabPage.Name);
                }
        }

        /// <summary>
        ///     Метод закрытия приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Метод форматирования участка текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Format_Click(object sender, EventArgs e)
        {
            var selectedTab = fileTabControl.SelectedTab;
            var textBox = (RichTextBox)selectedTab.Controls[0];
            var fontDialog = new FontDialog();

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
                textBox.SelectionFont = fontDialog.Font;
        }

        /// <summary>
        ///     Метод смены темы приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DarkTheme_Click(object sender, EventArgs e)
        {
            if (_isDark == false)
            {
                _isDark = true;
                foreach (Control objects in Controls)
                {
                    objects.BackColor = Color.DimGray;
                    objects.ForeColor = Color.AliceBlue;
                    foreach (Control objectsControl in objects.Controls)
                    {
                        objectsControl.BackColor = Color.DimGray;
                        objectsControl.ForeColor = Color.AliceBlue;
                        foreach (Control objectsControlControl in objectsControl.Controls)
                        {
                            objectsControlControl.BackColor = Color.DimGray;
                            objectsControlControl.ForeColor = Color.AliceBlue;
                        }
                    }
                }
            }
            else
            {
                _isDark = false;
                foreach (Control objects in Controls)
                {
                    objects.BackColor = Color.White;
                    objects.ForeColor = Color.Black;
                    foreach (Control objectsControl in objects.Controls)
                    {
                        objectsControl.BackColor = Color.White;
                        objectsControl.ForeColor = Color.Black;
                        foreach (Control objectsControlControl in objectsControl.Controls)
                        {
                            objectsControlControl.BackColor = Color.White;
                            objectsControlControl.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        /// <summary>
        ///     Метод создания файла в новом окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWindow_Click(object sender, EventArgs e)
        {
            var newWindow = new Notepad();
            newWindow.Show();
        }

        /// <summary>
        ///     Метод создания файла в новой вкладке.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTab_Click(object sender, EventArgs e)
        {
            _fileCount++;
            var filePage = new TabPage();
            filePage.Name = $"file{_fileCount}";
            filePage.Text = $"file{_fileCount}";
            var textBox = new RichTextBox
            {
                Name = $"textField{_fileCount}",
                Width = 792,
                Height = 396,
                Margin = new Padding(3, 3, 3, 3),
                Font = _currentFont,
                ContextMenuStrip = contextMenu
            };
            textBox.TextChanged += TextField_TextChanged;
            textBox.Parent = filePage;

            fileTabControl.TabPages.Add(filePage);
            _fileChange[filePage] = false;
        }
    }
}