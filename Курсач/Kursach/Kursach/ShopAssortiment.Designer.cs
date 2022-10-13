
namespace Kursach
{
    partial class ShopAssortiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopAssortiment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.TextBox();
            this.GameName = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.GameName);
            this.panel1.Location = new System.Drawing.Point(0, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 50);
            this.panel1.TabIndex = 0;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.Price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Price.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Price.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(561, 20);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(124, 20);
            this.Price.TabIndex = 1;
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
            this.GameName.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.Location = new System.Drawing.Point(15, 20);
            this.GameName.Multiline = true;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Size = new System.Drawing.Size(262, 20);
            this.GameName.TabIndex = 0;
            this.GameName.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(700, 300);
            this.MainPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(640, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 42);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.Panel2_Click);
            this.panel2.MouseEnter += new System.EventHandler(this.Panel2_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.Panel2_MouseLeave);
            // 
            // ShopAssortiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "ShopAssortiment";
            this.Size = new System.Drawing.Size(700, 300);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Panel panel2;
    }
}
