namespace Paint
{
    partial class MainForm
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.каскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слеваНаправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуВнизToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.упорядочитьЗначкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.эффект3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диффузноеОтражениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьНалевоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоВертикалиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отразитьПоГоризонталиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.chooseColorStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pensilStripButton = new System.Windows.Forms.ToolStripButton();
            this.lineStripButton = new System.Windows.Forms.ToolStripButton();
            this.elipseStripButton = new System.Windows.Forms.ToolStripButton();
            this.starStripButton = new System.Windows.Forms.ToolStripButton();
            this.eraserStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomInStripButton = new System.Windows.Forms.ToolStripButton();
            this.zoomOutStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.рисунокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(947, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.открытьToolStripMenuItem.Text = "Открыть ...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как ...";
            this.сохранитьКакToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.каскадомToolStripMenuItem,
            this.слеваНаправоToolStripMenuItem,
            this.сверхуВнизToolStripMenuItem,
            this.упорядочитьЗначкиToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // каскадомToolStripMenuItem
            // 
            this.каскадомToolStripMenuItem.Name = "каскадомToolStripMenuItem";
            this.каскадомToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.каскадомToolStripMenuItem.Text = "Каскадом";
            this.каскадомToolStripMenuItem.Click += new System.EventHandler(this.каскадомToolStripMenuItem_Click);
            // 
            // слеваНаправоToolStripMenuItem
            // 
            this.слеваНаправоToolStripMenuItem.Name = "слеваНаправоToolStripMenuItem";
            this.слеваНаправоToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.слеваНаправоToolStripMenuItem.Text = "Слева направо";
            this.слеваНаправоToolStripMenuItem.Click += new System.EventHandler(this.слеваНаправоToolStripMenuItem_Click);
            // 
            // сверхуВнизToolStripMenuItem
            // 
            this.сверхуВнизToolStripMenuItem.Name = "сверхуВнизToolStripMenuItem";
            this.сверхуВнизToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.сверхуВнизToolStripMenuItem.Text = "Сверху вниз";
            this.сверхуВнизToolStripMenuItem.Click += new System.EventHandler(this.сверхуВнизToolStripMenuItem_Click);
            // 
            // упорядочитьЗначкиToolStripMenuItem
            // 
            this.упорядочитьЗначкиToolStripMenuItem.Name = "упорядочитьЗначкиToolStripMenuItem";
            this.упорядочитьЗначкиToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.упорядочитьЗначкиToolStripMenuItem.Text = "Упорядочить значки";
            this.упорядочитьЗначкиToolStripMenuItem.Click += new System.EventHandler(this.упорядочитьЗначкиToolStripMenuItem_Click);
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.эффект1ToolStripMenuItem,
            this.эффект2ToolStripMenuItem,
            this.эффект3ToolStripMenuItem,
            this.диффузноеОтражениеToolStripMenuItem,
            this.повернутьНалевоToolStripMenuItem,
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem,
            this.отразитьПоВертикалиToolStripMenuItem,
            this.отразитьПоГоризонталиToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.рисунокToolStripMenuItem.Text = "Рисунок";
            // 
            // эффект1ToolStripMenuItem
            // 
            this.эффект1ToolStripMenuItem.Name = "эффект1ToolStripMenuItem";
            this.эффект1ToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.эффект1ToolStripMenuItem.Text = "Преобразовать в рельеф";
            this.эффект1ToolStripMenuItem.Click += new System.EventHandler(this.эффект1ToolStripMenuItem_Click);
            // 
            // эффект2ToolStripMenuItem
            // 
            this.эффект2ToolStripMenuItem.Name = "эффект2ToolStripMenuItem";
            this.эффект2ToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.эффект2ToolStripMenuItem.Text = "Увеличить резкость";
            this.эффект2ToolStripMenuItem.Click += new System.EventHandler(this.эффект2ToolStripMenuItem_Click);
            // 
            // эффект3ToolStripMenuItem
            // 
            this.эффект3ToolStripMenuItem.Name = "эффект3ToolStripMenuItem";
            this.эффект3ToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.эффект3ToolStripMenuItem.Text = "Сгладить изображение";
            this.эффект3ToolStripMenuItem.Click += new System.EventHandler(this.эффект3ToolStripMenuItem_Click);
            // 
            // диффузноеОтражениеToolStripMenuItem
            // 
            this.диффузноеОтражениеToolStripMenuItem.Name = "диффузноеОтражениеToolStripMenuItem";
            this.диффузноеОтражениеToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.диффузноеОтражениеToolStripMenuItem.Text = "Размытие";
            this.диффузноеОтражениеToolStripMenuItem.Click += new System.EventHandler(this.диффузноеОтражениеToolStripMenuItem_Click);
            // 
            // повернутьНалевоToolStripMenuItem
            // 
            this.повернутьНалевоToolStripMenuItem.Name = "повернутьНалевоToolStripMenuItem";
            this.повернутьНалевоToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.повернутьНалевоToolStripMenuItem.Text = "Повернуть против часовой стрелки";
            this.повернутьНалевоToolStripMenuItem.Click += new System.EventHandler(this.повернутьНалевоToolStripMenuItem_Click);
            // 
            // повернутьGjЧасовойСтрелкиToolStripMenuItem
            // 
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem.Name = "повернутьGjЧасовойСтрелкиToolStripMenuItem";
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem.Text = "Повернуть по часовой стрелке";
            this.повернутьGjЧасовойСтрелкиToolStripMenuItem.Click += new System.EventHandler(this.повернутьGjЧасовойСтрелкиToolStripMenuItem_Click);
            // 
            // отразитьПоВертикалиToolStripMenuItem
            // 
            this.отразитьПоВертикалиToolStripMenuItem.Name = "отразитьПоВертикалиToolStripMenuItem";
            this.отразитьПоВертикалиToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.отразитьПоВертикалиToolStripMenuItem.Text = "Отразить по вертикали";
            this.отразитьПоВертикалиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоВертикалиToolStripMenuItem_Click);
            // 
            // отразитьПоГоризонталиToolStripMenuItem
            // 
            this.отразитьПоГоризонталиToolStripMenuItem.Name = "отразитьПоГоризонталиToolStripMenuItem";
            this.отразитьПоГоризонталиToolStripMenuItem.Size = new System.Drawing.Size(333, 26);
            this.отразитьПоГоризонталиToolStripMenuItem.Text = "Отразить по горизонтали";
            this.отразитьПоГоризонталиToolStripMenuItem.Click += new System.EventHandler(this.отразитьПоГоризонталиToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseColorStripButton,
            this.toolStripSeparator1,
            this.sizeComboBox,
            this.toolStripSeparator2,
            this.pensilStripButton,
            this.lineStripButton,
            this.elipseStripButton,
            this.starStripButton,
            this.eraserStripButton,
            this.zoomInStripButton,
            this.zoomOutStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(947, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // chooseColorStripButton
            // 
            this.chooseColorStripButton.BackColor = System.Drawing.Color.Red;
            this.chooseColorStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.chooseColorStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.chooseColorStripButton.Name = "chooseColorStripButton";
            this.chooseColorStripButton.Size = new System.Drawing.Size(23, 25);
            this.chooseColorStripButton.Text = "toolStripButton1";
            this.chooseColorStripButton.ToolTipText = "Выбор цвета";
            this.chooseColorStripButton.Click += new System.EventHandler(this.chooseColorStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // sizeComboBox
            // 
            this.sizeComboBox.DropDownWidth = 80;
            this.sizeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "7",
            "10",
            "15",
            "20",
            "25"});
            this.sizeComboBox.Name = "sizeComboBox";
            this.sizeComboBox.Size = new System.Drawing.Size(80, 28);
            this.sizeComboBox.Text = "2";
            this.sizeComboBox.TextChanged += new System.EventHandler(this.sizeComboBox_TextChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // pensilStripButton
            // 
            this.pensilStripButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pensilStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pensilStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pensilStripButton.Name = "pensilStripButton";
            this.pensilStripButton.Size = new System.Drawing.Size(50, 25);
            this.pensilStripButton.Text = "Перо";
            this.pensilStripButton.Click += new System.EventHandler(this.pensilStripButton_Click);
            // 
            // lineStripButton
            // 
            this.lineStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lineStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.lineStripButton.Name = "lineStripButton";
            this.lineStripButton.Size = new System.Drawing.Size(58, 25);
            this.lineStripButton.Text = "Линия";
            this.lineStripButton.Click += new System.EventHandler(this.lineStripButton_Click);
            // 
            // elipseStripButton
            // 
            this.elipseStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.elipseStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.elipseStripButton.Name = "elipseStripButton";
            this.elipseStripButton.Size = new System.Drawing.Size(63, 25);
            this.elipseStripButton.Text = "Эллипс";
            this.elipseStripButton.Click += new System.EventHandler(this.elipseStripButton_Click);
            // 
            // starStripButton
            // 
            this.starStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.starStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.starStripButton.Name = "starStripButton";
            this.starStripButton.Size = new System.Drawing.Size(60, 25);
            this.starStripButton.Text = "Звезда";
            this.starStripButton.Click += new System.EventHandler(this.starStripButton_Click);
            // 
            // eraserStripButton
            // 
            this.eraserStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.eraserStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.eraserStripButton.Name = "eraserStripButton";
            this.eraserStripButton.Size = new System.Drawing.Size(60, 25);
            this.eraserStripButton.Text = "Ластик";
            this.eraserStripButton.Click += new System.EventHandler(this.eraserStripButton_Click);
            // 
            // zoomInStripButton
            // 
            this.zoomInStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomInStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInStripButton.Name = "zoomInStripButton";
            this.zoomInStripButton.Size = new System.Drawing.Size(90, 25);
            this.zoomInStripButton.Text = "Масштаб +";
            this.zoomInStripButton.Click += new System.EventHandler(this.zoomInStripButton_Click);
            // 
            // zoomOutStripButton
            // 
            this.zoomOutStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.zoomOutStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutStripButton.Name = "zoomOutStripButton";
            this.zoomOutStripButton.Size = new System.Drawing.Size(86, 25);
            this.zoomOutStripButton.Text = "Масштаб -";
            this.zoomOutStripButton.Click += new System.EventHandler(this.zoomOutStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 695);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Paint";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton chooseColorStripButton;
        private System.Windows.Forms.ToolStripComboBox sizeComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton pensilStripButton;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton lineStripButton;
        private System.Windows.Forms.ToolStripButton elipseStripButton;
        private System.Windows.Forms.ToolStripButton starStripButton;
        private System.Windows.Forms.ToolStripButton eraserStripButton;
        private System.Windows.Forms.ToolStripButton zoomInStripButton;
        private System.Windows.Forms.ToolStripButton zoomOutStripButton;
        private System.Windows.Forms.ToolStripMenuItem каскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слеваНаправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуВнизToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem упорядочитьЗначкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem эффект3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диффузноеОтражениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьНалевоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьGjЧасовойСтрелкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоВертикалиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отразитьПоГоризонталиToolStripMenuItem;
    }
}

