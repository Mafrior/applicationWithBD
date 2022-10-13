
namespace Kursach
{
    partial class LibraryComponent
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeInGame = new System.Windows.Forms.TextBox();
            this.GameName = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Controls.Add(this.PlayButton);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(210, 220);
            this.MainPanel.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(159)))), ((int)(((byte)(244)))));
            this.PlayButton.FlatAppearance.BorderSize = 0;
            this.PlayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(146)))), ((int)(((byte)(210)))));
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayButton.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PlayButton.Location = new System.Drawing.Point(0, 190);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(210, 30);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.TabStop = false;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TimeInGame);
            this.panel1.Controls.Add(this.GameName);
            this.panel1.Location = new System.Drawing.Point(0, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 80);
            this.panel1.TabIndex = 1;
            // 
            // TimeInGame
            // 
            this.TimeInGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.TimeInGame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TimeInGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeInGame.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeInGame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.TimeInGame.Location = new System.Drawing.Point(10, 30);
            this.TimeInGame.Multiline = true;
            this.TimeInGame.Name = "TimeInGame";
            this.TimeInGame.ReadOnly = true;
            this.TimeInGame.Size = new System.Drawing.Size(190, 17);
            this.TimeInGame.TabIndex = 1;
            this.TimeInGame.TabStop = false;
            // 
            // GameName
            // 
            this.GameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.GameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameName.Font = new System.Drawing.Font("Montserrat Medium", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GameName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.GameName.Location = new System.Drawing.Point(10, 12);
            this.GameName.Multiline = true;
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Size = new System.Drawing.Size(190, 17);
            this.GameName.TabIndex = 0;
            this.GameName.TabStop = false;
            // 
            // LibraryComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainPanel);
            this.Name = "LibraryComponent";
            this.Size = new System.Drawing.Size(210, 300);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox GameName;
        private System.Windows.Forms.TextBox TimeInGame;
        private System.Windows.Forms.Button PlayButton;
    }
}
