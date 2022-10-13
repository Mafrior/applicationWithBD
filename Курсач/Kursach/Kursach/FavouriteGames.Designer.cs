
namespace Kursach
{
    partial class FavouriteGames
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouriteGames));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.FavouritePanel = new System.Windows.Forms.Panel();
            this.DownSidePanel = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.TextBox();
            this.GameName = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.DownSidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.FavouritePanel);
            this.MainPanel.Controls.Add(this.DownSidePanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(355, 250);
            this.MainPanel.TabIndex = 0;
            // 
            // FavouritePanel
            // 
            this.FavouritePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FavouritePanel.BackgroundImage")));
            this.FavouritePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FavouritePanel.Location = new System.Drawing.Point(300, 13);
            this.FavouritePanel.Name = "FavouritePanel";
            this.FavouritePanel.Size = new System.Drawing.Size(42, 42);
            this.FavouritePanel.TabIndex = 1;
            this.FavouritePanel.Click += new System.EventHandler(this.Panel2_Click);
            this.FavouritePanel.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.FavouritePanel.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // DownSidePanel
            // 
            this.DownSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.DownSidePanel.Controls.Add(this.Price);
            this.DownSidePanel.Controls.Add(this.GameName);
            this.DownSidePanel.Location = new System.Drawing.Point(0, 205);
            this.DownSidePanel.Name = "DownSidePanel";
            this.DownSidePanel.Size = new System.Drawing.Size(355, 45);
            this.DownSidePanel.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Price.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(228, 20);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(124, 20);
            this.Price.TabIndex = 3;
            this.Price.TabStop = false;
            this.Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Price.Click += new System.EventHandler(this.Price_Click);
            this.Price.MouseEnter += new System.EventHandler(this.Price_MouseEnter);
            this.Price.MouseLeave += new System.EventHandler(this.Price_MouseLeave);
            // 
            // GameName
            // 
            this.GameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.GameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameName.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.Location = new System.Drawing.Point(3, 20);
            this.GameName.Multiline = true;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Size = new System.Drawing.Size(180, 20);
            this.GameName.TabIndex = 2;
            this.GameName.TabStop = false;
            // 
            // FavouriteGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "FavouriteGames";
            this.Size = new System.Drawing.Size(355, 250);
            this.MainPanel.ResumeLayout(false);
            this.DownSidePanel.ResumeLayout(false);
            this.DownSidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel DownSidePanel;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.Panel FavouritePanel;
    }
}
