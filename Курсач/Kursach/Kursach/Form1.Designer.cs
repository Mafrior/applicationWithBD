
namespace Kursach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IssiuesTextBox = new System.Windows.Forms.TextBox();
            this.upsidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FullScreen = new System.Windows.Forms.Button();
            this.Hide = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.EnterTextBox = new System.Windows.Forms.TextBox();
            this.ShopPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ShopTextBox = new System.Windows.Forms.TextBox();
            this.MainButtons = new System.Windows.Forms.Panel();
            this.FavouritePanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.FavouriteTextBox = new System.Windows.Forms.TextBox();
            this.LibraryPanel = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LibraryTextBox = new System.Windows.Forms.TextBox();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.Genres = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.upsidePanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.ShopPanel.SuspendLayout();
            this.MainButtons.SuspendLayout();
            this.FavouritePanel.SuspendLayout();
            this.LibraryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.mainPanel.Controls.Add(this.Genres);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Controls.Add(this.IssiuesTextBox);
            this.mainPanel.Controls.Add(this.upsidePanel);
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Controls.Add(this.CenterPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1333, 677);
            this.mainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(1200, 550);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(85, 79);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // IssiuesTextBox
            // 
            this.IssiuesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.IssiuesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IssiuesTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IssiuesTextBox.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IssiuesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.IssiuesTextBox.Location = new System.Drawing.Point(427, 313);
            this.IssiuesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IssiuesTextBox.Multiline = true;
            this.IssiuesTextBox.Name = "IssiuesTextBox";
            this.IssiuesTextBox.ReadOnly = true;
            this.IssiuesTextBox.Size = new System.Drawing.Size(800, 31);
            this.IssiuesTextBox.TabIndex = 4;
            this.IssiuesTextBox.TabStop = false;
            this.IssiuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // upsidePanel
            // 
            this.upsidePanel.Controls.Add(this.panel1);
            this.upsidePanel.Controls.Add(this.FullScreen);
            this.upsidePanel.Controls.Add(this.Hide);
            this.upsidePanel.Controls.Add(this.CloseButton);
            this.upsidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upsidePanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.upsidePanel.Location = new System.Drawing.Point(0, 0);
            this.upsidePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upsidePanel.Name = "upsidePanel";
            this.upsidePanel.Size = new System.Drawing.Size(1333, 42);
            this.upsidePanel.TabIndex = 1;
            this.upsidePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.upsidePanel_MouseDown);
            this.upsidePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.upsidePanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(13, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 32);
            this.panel1.TabIndex = 3;
            // 
            // FullScreen
            // 
            this.FullScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FullScreen.BackgroundImage")));
            this.FullScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FullScreen.FlatAppearance.BorderSize = 0;
            this.FullScreen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.FullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.FullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FullScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FullScreen.Location = new System.Drawing.Point(1200, 5);
            this.FullScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FullScreen.Name = "FullScreen";
            this.FullScreen.Size = new System.Drawing.Size(55, 32);
            this.FullScreen.TabIndex = 2;
            this.FullScreen.UseVisualStyleBackColor = true;
            this.FullScreen.Click += new System.EventHandler(this.FullScreen_Click);
            // 
            // Hide
            // 
            this.Hide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hide.BackgroundImage")));
            this.Hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Hide.FlatAppearance.BorderSize = 0;
            this.Hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.Hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.Hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Hide.Location = new System.Drawing.Point(1153, 5);
            this.Hide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(47, 32);
            this.Hide.TabIndex = 1;
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.CloseButton.Location = new System.Drawing.Point(1255, 5);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(73, 32);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.panel7);
            this.leftPanel.Controls.Add(this.ShopPanel);
            this.leftPanel.Controls.Add(this.MainButtons);
            this.leftPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.leftPanel.Location = new System.Drawing.Point(0, 42);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(267, 629);
            this.leftPanel.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.EnterTextBox);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel7.Location = new System.Drawing.Point(0, 555);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 74);
            this.panel7.TabIndex = 6;
            this.panel7.Click += new System.EventHandler(this.Panel7_Click);
            this.panel7.MouseEnter += new System.EventHandler(this.Panel7_MouseEnter);
            this.panel7.MouseLeave += new System.EventHandler(this.Panel7_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Location = new System.Drawing.Point(13, 6);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(67, 62);
            this.panel8.TabIndex = 5;
            this.panel8.Click += new System.EventHandler(this.Panel7_Click);
            this.panel8.MouseEnter += new System.EventHandler(this.Panel7_MouseEnter);
            this.panel8.MouseLeave += new System.EventHandler(this.Panel7_MouseLeave);
            // 
            // EnterTextBox
            // 
            this.EnterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.EnterTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.EnterTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.EnterTextBox.Location = new System.Drawing.Point(107, 25);
            this.EnterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterTextBox.Multiline = true;
            this.EnterTextBox.Name = "EnterTextBox";
            this.EnterTextBox.ReadOnly = true;
            this.EnterTextBox.Size = new System.Drawing.Size(129, 25);
            this.EnterTextBox.TabIndex = 2;
            this.EnterTextBox.TabStop = false;
            this.EnterTextBox.Text = "Вход";
            this.EnterTextBox.Click += new System.EventHandler(this.Panel7_Click);
            this.EnterTextBox.MouseEnter += new System.EventHandler(this.Panel7_MouseEnter);
            this.EnterTextBox.MouseLeave += new System.EventHandler(this.Panel7_MouseLeave);
            // 
            // ShopPanel
            // 
            this.ShopPanel.Controls.Add(this.panel4);
            this.ShopPanel.Controls.Add(this.ShopTextBox);
            this.ShopPanel.Location = new System.Drawing.Point(0, 0);
            this.ShopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShopPanel.Name = "ShopPanel";
            this.ShopPanel.Size = new System.Drawing.Size(267, 74);
            this.ShopPanel.TabIndex = 0;
            this.ShopPanel.Click += new System.EventHandler(this.ShopPanel_Click);
            this.ShopPanel.MouseEnter += new System.EventHandler(this.ShopPanel_MouseEnter);
            this.ShopPanel.MouseLeave += new System.EventHandler(this.ShopPanel_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel4.Location = new System.Drawing.Point(13, 6);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(67, 62);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.Panel4_Click);
            this.panel4.MouseEnter += new System.EventHandler(this.ShopPanel_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.ShopPanel_MouseLeave);
            // 
            // ShopTextBox
            // 
            this.ShopTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ShopTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ShopTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShopTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShopTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ShopTextBox.Location = new System.Drawing.Point(107, 25);
            this.ShopTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShopTextBox.Multiline = true;
            this.ShopTextBox.Name = "ShopTextBox";
            this.ShopTextBox.ReadOnly = true;
            this.ShopTextBox.Size = new System.Drawing.Size(107, 25);
            this.ShopTextBox.TabIndex = 0;
            this.ShopTextBox.TabStop = false;
            this.ShopTextBox.Text = "Магазин";
            this.ShopTextBox.Click += new System.EventHandler(this.ShopTextBox_Click);
            this.ShopTextBox.MouseEnter += new System.EventHandler(this.ShopPanel_MouseEnter);
            this.ShopTextBox.MouseLeave += new System.EventHandler(this.ShopPanel_MouseLeave);
            // 
            // MainButtons
            // 
            this.MainButtons.Controls.Add(this.FavouritePanel);
            this.MainButtons.Controls.Add(this.LibraryPanel);
            this.MainButtons.Location = new System.Drawing.Point(0, 0);
            this.MainButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainButtons.Name = "MainButtons";
            this.MainButtons.Size = new System.Drawing.Size(267, 222);
            this.MainButtons.TabIndex = 0;
            // 
            // FavouritePanel
            // 
            this.FavouritePanel.Controls.Add(this.panel6);
            this.FavouritePanel.Controls.Add(this.FavouriteTextBox);
            this.FavouritePanel.Location = new System.Drawing.Point(0, 148);
            this.FavouritePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FavouritePanel.Name = "FavouritePanel";
            this.FavouritePanel.Size = new System.Drawing.Size(267, 74);
            this.FavouritePanel.TabIndex = 2;
            this.FavouritePanel.Click += new System.EventHandler(this.FavouritePanel_Click);
            this.FavouritePanel.MouseEnter += new System.EventHandler(this.FavouritePanel_MouseEnter);
            this.FavouritePanel.MouseLeave += new System.EventHandler(this.FavouritePanel_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(13, 6);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(67, 62);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.FavouritePanel_Click);
            this.panel6.MouseEnter += new System.EventHandler(this.FavouritePanel_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.FavouritePanel_MouseLeave);
            // 
            // FavouriteTextBox
            // 
            this.FavouriteTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FavouriteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FavouriteTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.FavouriteTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FavouriteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.FavouriteTextBox.Location = new System.Drawing.Point(107, 25);
            this.FavouriteTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FavouriteTextBox.Multiline = true;
            this.FavouriteTextBox.Name = "FavouriteTextBox";
            this.FavouriteTextBox.ReadOnly = true;
            this.FavouriteTextBox.Size = new System.Drawing.Size(129, 25);
            this.FavouriteTextBox.TabIndex = 2;
            this.FavouriteTextBox.TabStop = false;
            this.FavouriteTextBox.Text = "Избранное";
            this.FavouriteTextBox.Click += new System.EventHandler(this.FavouritePanel_Click);
            this.FavouriteTextBox.MouseEnter += new System.EventHandler(this.FavouritePanel_MouseEnter);
            this.FavouriteTextBox.MouseLeave += new System.EventHandler(this.FavouritePanel_MouseLeave);
            // 
            // LibraryPanel
            // 
            this.LibraryPanel.Controls.Add(this.panel5);
            this.LibraryPanel.Controls.Add(this.LibraryTextBox);
            this.LibraryPanel.Location = new System.Drawing.Point(0, 74);
            this.LibraryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibraryPanel.Name = "LibraryPanel";
            this.LibraryPanel.Size = new System.Drawing.Size(267, 74);
            this.LibraryPanel.TabIndex = 1;
            this.LibraryPanel.Click += new System.EventHandler(this.LibraryPanel_Click);
            this.LibraryPanel.MouseEnter += new System.EventHandler(this.LibraryPanel_MouseEnter);
            this.LibraryPanel.MouseLeave += new System.EventHandler(this.LibraryPanel_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel5.Location = new System.Drawing.Point(13, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(67, 62);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.LibraryPanel_Click);
            this.panel5.MouseEnter += new System.EventHandler(this.LibraryPanel_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.LibraryPanel_MouseLeave);
            // 
            // LibraryTextBox
            // 
            this.LibraryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.LibraryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LibraryTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LibraryTextBox.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LibraryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.LibraryTextBox.Location = new System.Drawing.Point(107, 25);
            this.LibraryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LibraryTextBox.Multiline = true;
            this.LibraryTextBox.Name = "LibraryTextBox";
            this.LibraryTextBox.ReadOnly = true;
            this.LibraryTextBox.Size = new System.Drawing.Size(129, 25);
            this.LibraryTextBox.TabIndex = 1;
            this.LibraryTextBox.TabStop = false;
            this.LibraryTextBox.Text = "Библиотека";
            this.LibraryTextBox.Click += new System.EventHandler(this.LibraryPanel_Click);
            this.LibraryTextBox.MouseEnter += new System.EventHandler(this.LibraryPanel_MouseEnter);
            this.LibraryTextBox.MouseLeave += new System.EventHandler(this.LibraryPanel_MouseLeave);
            // 
            // CenterPanel
            // 
            this.CenterPanel.AutoScroll = true;
            this.CenterPanel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.CenterPanel.Location = new System.Drawing.Point(267, 42);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1067, 629);
            this.CenterPanel.TabIndex = 2;
            // 
            // Genres
            // 
            this.Genres.Location = new System.Drawing.Point(267, 42);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(1067, 27);
            this.Genres.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 677);
            this.Controls.Add(this.mainPanel);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.upsidePanel.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ShopPanel.ResumeLayout(false);
            this.ShopPanel.PerformLayout();
            this.MainButtons.ResumeLayout(false);
            this.FavouritePanel.ResumeLayout(false);
            this.FavouritePanel.PerformLayout();
            this.LibraryPanel.ResumeLayout(false);
            this.LibraryPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.Panel upsidePanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button Hide;
        private System.Windows.Forms.Button FullScreen;
        private System.Windows.Forms.Panel ShopPanel;
        private System.Windows.Forms.TextBox ShopTextBox;
        private System.Windows.Forms.Panel MainButtons;
        private System.Windows.Forms.Panel FavouritePanel;
        private System.Windows.Forms.TextBox FavouriteTextBox;
        private System.Windows.Forms.Panel LibraryPanel;
        private System.Windows.Forms.TextBox LibraryTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        public System.Windows.Forms.TextBox EnterTextBox;
        private System.Windows.Forms.TextBox IssiuesTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Genres;
    }
}

