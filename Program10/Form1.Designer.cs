
namespace Program10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.системаКоординатToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фигураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дугиИСекторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.путьКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.простоКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hQКонтурToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сплошнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.узорнаяЗаливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.градиентнаяЗалливкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.фигураToolStripMenuItem,
            this.заливкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 800);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.системаКоординатToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // системаКоординатToolStripMenuItem
            // 
            this.системаКоординатToolStripMenuItem.Name = "системаКоординатToolStripMenuItem";
            this.системаКоординатToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.системаКоординатToolStripMenuItem.Text = "Система координат";
            this.системаКоординатToolStripMenuItem.Click += new System.EventHandler(this.системаКоординатToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // фигураToolStripMenuItem
            // 
            this.фигураToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дугиИСекторыToolStripMenuItem,
            this.путьКонтурToolStripMenuItem,
            this.простоКонтурToolStripMenuItem,
            this.hQКонтурToolStripMenuItem});
            this.фигураToolStripMenuItem.Name = "фигураToolStripMenuItem";
            this.фигураToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.фигураToolStripMenuItem.Text = "Фигура";
            // 
            // дугиИСекторыToolStripMenuItem
            // 
            this.дугиИСекторыToolStripMenuItem.Name = "дугиИСекторыToolStripMenuItem";
            this.дугиИСекторыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.дугиИСекторыToolStripMenuItem.Text = "Дуги и секторы";
            this.дугиИСекторыToolStripMenuItem.Click += new System.EventHandler(this.дугиИСекторыToolStripMenuItem_Click);
            // 
            // путьКонтурToolStripMenuItem
            // 
            this.путьКонтурToolStripMenuItem.Name = "путьКонтурToolStripMenuItem";
            this.путьКонтурToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.путьКонтурToolStripMenuItem.Text = "Путь- Контур ";
            this.путьКонтурToolStripMenuItem.Click += new System.EventHandler(this.путьКонтурToolStripMenuItem_Click);
            // 
            // простоКонтурToolStripMenuItem
            // 
            this.простоКонтурToolStripMenuItem.Name = "простоКонтурToolStripMenuItem";
            this.простоКонтурToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.простоКонтурToolStripMenuItem.Text = "Просто Контур";
            this.простоКонтурToolStripMenuItem.Click += new System.EventHandler(this.простоКонтурToolStripMenuItem_Click);
            // 
            // hQКонтурToolStripMenuItem
            // 
            this.hQКонтурToolStripMenuItem.Name = "hQКонтурToolStripMenuItem";
            this.hQКонтурToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hQКонтурToolStripMenuItem.Text = "HQ Контур";
            this.hQКонтурToolStripMenuItem.Click += new System.EventHandler(this.hQКонтурToolStripMenuItem_Click);
            // 
            // заливкаToolStripMenuItem
            // 
            this.заливкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сплошнаяЗаливкаToolStripMenuItem,
            this.узорнаяЗаливкаToolStripMenuItem,
            this.градиентнаяЗалливкаToolStripMenuItem});
            this.заливкаToolStripMenuItem.Name = "заливкаToolStripMenuItem";
            this.заливкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заливкаToolStripMenuItem.Text = "Заливка";
            // 
            // сплошнаяЗаливкаToolStripMenuItem
            // 
            this.сплошнаяЗаливкаToolStripMenuItem.Name = "сплошнаяЗаливкаToolStripMenuItem";
            this.сплошнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.сплошнаяЗаливкаToolStripMenuItem.Text = "Сплошная заливка";
            this.сплошнаяЗаливкаToolStripMenuItem.Click += new System.EventHandler(this.сплошнаяЗаливкаToolStripMenuItem_Click);
            // 
            // узорнаяЗаливкаToolStripMenuItem
            // 
            this.узорнаяЗаливкаToolStripMenuItem.Name = "узорнаяЗаливкаToolStripMenuItem";
            this.узорнаяЗаливкаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.узорнаяЗаливкаToolStripMenuItem.Text = "Узорная заливка";
            this.узорнаяЗаливкаToolStripMenuItem.Click += new System.EventHandler(this.узорнаяЗаливкаToolStripMenuItem_Click);
            // 
            // градиентнаяЗалливкаToolStripMenuItem
            // 
            this.градиентнаяЗалливкаToolStripMenuItem.Name = "градиентнаяЗалливкаToolStripMenuItem";
            this.градиентнаяЗалливкаToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.градиентнаяЗалливкаToolStripMenuItem.Text = "Градиентная залливка";
            this.градиентнаяЗалливкаToolStripMenuItem.Click += new System.EventHandler(this.градиентнаяЗалливкаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(527, 836);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem системаКоординатToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фигураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дугиИСекторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem путьКонтурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem простоКонтурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hQКонтурToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сплошнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem узорнаяЗаливкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem градиентнаяЗалливкаToolStripMenuItem;
    }
}

