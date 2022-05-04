namespace peer_4
{
    partial class Notepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.newTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intervalSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.darkTheme = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationMenu = new System.Windows.Forms.MenuStrip();
            this.file1 = new System.Windows.Forms.TabPage();
            this.textField = new System.Windows.Forms.RichTextBox();
            this.fileTabControl = new System.Windows.Forms.TabControl();
            this.saveTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.format = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationMenu.SuspendLayout();
            this.file1.SuspendLayout();
            this.fileTabControl.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindow,
            this.newTab,
            this.toolStripSeparator2,
            this.openFileMenuItem,
            this.saveAsMenuItem,
            this.saveMenuItem,
            this.saveAll,
            this.toolStripSeparator1,
            this.exit});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileMenuItem.Text = "Файл";
            // 
            // newWindow
            // 
            this.newWindow.Name = "newWindow";
            this.newWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindow.Size = new System.Drawing.Size(284, 22);
            this.newWindow.Text = "Создание в новом окне";
            this.newWindow.Click += new System.EventHandler(this.newWindow_Click);
            // 
            // newTab
            // 
            this.newTab.Name = "newTab";
            this.newTab.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newTab.Size = new System.Drawing.Size(284, 22);
            this.newTab.Text = "Создание в новой вкладке";
            this.newTab.Click += new System.EventHandler(this.newTab_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(281, 6);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(284, 22);
            this.openFileMenuItem.Text = "Открыть";
            this.openFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(284, 22);
            this.saveAsMenuItem.Text = "Сохранить как";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(284, 22);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // saveAll
            // 
            this.saveAll.Name = "saveAll";
            this.saveAll.ShortcutKeys = ((System.Windows.Forms.Keys)((((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAll.Size = new System.Drawing.Size(284, 22);
            this.saveAll.Text = "Сохранить все";
            this.saveAll.Click += new System.EventHandler(this.SaveAll_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(281, 6);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exit.Size = new System.Drawing.Size(284, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // settingsMenuItem
            // 
            this.settingsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intervalSetting,
            this.darkTheme});
            this.settingsMenuItem.Name = "settingsMenuItem";
            this.settingsMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsMenuItem.Text = "Настройки";
            // 
            // intervalSetting
            // 
            this.intervalSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerTextBox});
            this.intervalSetting.Name = "intervalSetting";
            this.intervalSetting.Size = new System.Drawing.Size(221, 22);
            this.intervalSetting.Text = "Интервал Автосохранения";
            // 
            // timerTextBox
            // 
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(100, 23);
            this.timerTextBox.Text = "100000";
            this.timerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimerTextBox_KeyPress);
            this.timerTextBox.TextChanged += new System.EventHandler(this.TimerTextBox_TextChanged);
            // 
            // darkTheme
            // 
            this.darkTheme.CheckOnClick = true;
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Size = new System.Drawing.Size(221, 22);
            this.darkTheme.Text = "Темная тема";
            this.darkTheme.Click += new System.EventHandler(this.DarkTheme_Click);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(62, 20);
            this.formatMenuItem.Text = "Формат";
            this.formatMenuItem.Click += new System.EventHandler(this.FormatMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.вырезатьToolStripMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 20);
            this.editMenuItem.Text = "Правка";
            // 
            // applicationMenu
            // 
            this.applicationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.settingsMenuItem,
            this.formatMenuItem,
            this.editMenuItem});
            this.applicationMenu.Location = new System.Drawing.Point(0, 0);
            this.applicationMenu.Name = "applicationMenu";
            this.applicationMenu.Size = new System.Drawing.Size(800, 24);
            this.applicationMenu.TabIndex = 2;
            this.applicationMenu.Text = "menuStrip1";
            // 
            // file1
            // 
            this.file1.Controls.Add(this.textField);
            this.file1.Location = new System.Drawing.Point(4, 24);
            this.file1.Name = "file1";
            this.file1.Padding = new System.Windows.Forms.Padding(3);
            this.file1.Size = new System.Drawing.Size(792, 396);
            this.file1.TabIndex = 0;
            this.file1.Text = "Без имени";
            this.file1.UseVisualStyleBackColor = true;
            // 
            // textField
            // 
            this.textField.Location = new System.Drawing.Point(0, 0);
            this.textField.Name = "textField";
            this.textField.Size = new System.Drawing.Size(792, 396);
            this.textField.TabIndex = 0;
            this.textField.Text = "";
            this.textField.TextChanged += new System.EventHandler(this.TextField_TextChanged);
            // 
            // fileTabControl
            // 
            this.fileTabControl.Controls.Add(this.file1);
            this.fileTabControl.Location = new System.Drawing.Point(0, 27);
            this.fileTabControl.Name = "fileTabControl";
            this.fileTabControl.SelectedIndex = 0;
            this.fileTabControl.Size = new System.Drawing.Size(800, 424);
            this.fileTabControl.TabIndex = 3;
            // 
            // saveTimer
            // 
            this.saveTimer.Enabled = true;
            this.saveTimer.Interval = 100000;
            this.saveTimer.Tick += new System.EventHandler(this.SaveTimer_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copy,
            this.paste,
            this.cut,
            this.selectAll,
            this.format});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(157, 114);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(156, 22);
            this.copy.Text = "Копировать";
            this.copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(156, 22);
            this.paste.Text = "Вставить";
            this.paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(156, 22);
            this.cut.Text = "Вырезать";
            this.cut.Click += new System.EventHandler(this.Cut_Click);
            // 
            // selectAll
            // 
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(156, 22);
            this.selectAll.Text = "Выделить все";
            this.selectAll.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // format
            // 
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(156, 22);
            this.format.Text = "Задать формат";
            this.format.Click += new System.EventHandler(this.Format_Click);
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            this.копироватьToolStripMenuItem.Click += new System.EventHandler(this.Copy_Click);
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            this.вставитьToolStripMenuItem.Click += new System.EventHandler(this.Paste_Click);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            this.вырезатьToolStripMenuItem.Click += new System.EventHandler(this.Cut_Click);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fileTabControl);
            this.Controls.Add(this.applicationMenu);
            this.MainMenuStrip = this.applicationMenu;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Notepad";
            this.Text = "Notepad+";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Notepad_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Notepad_FormClosed);
            this.Load += new System.EventHandler(this.Notepad_Load);
            this.applicationMenu.ResumeLayout(false);
            this.applicationMenu.PerformLayout();
            this.file1.ResumeLayout(false);
            this.fileTabControl.ResumeLayout(false);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.MenuStrip applicationMenu;
        private System.Windows.Forms.TabPage file1;
        private System.Windows.Forms.RichTextBox textField;
        private System.Windows.Forms.TabControl fileTabControl;
        private System.Windows.Forms.Timer saveTimer;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intervalSetting;
        private System.Windows.Forms.ToolStripTextBox timerTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private System.Windows.Forms.ToolStripMenuItem format;
        private System.Windows.Forms.ToolStripMenuItem saveAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.ToolStripMenuItem darkTheme;
        private System.Windows.Forms.ToolStripMenuItem newWindow;
        private System.Windows.Forms.ToolStripMenuItem newTab;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
    }
}
