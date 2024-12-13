namespace Game
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.gamer = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drop = new System.Windows.Forms.Button();
            this.inventory = new System.Windows.Forms.ListBox();
            this.money = new System.Windows.Forms.PictureBox();
            this.creeper = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.money)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.creeper)).BeginInit();
            this.SuspendLayout();
            // 
            // gamer
            // 
            this.gamer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamer.Location = new System.Drawing.Point(93, 314);
            this.gamer.Name = "gamer";
            this.gamer.Size = new System.Drawing.Size(100, 50);
            this.gamer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gamer.TabIndex = 0;
            this.gamer.TabStop = false;
            // 
            // location
            // 
            this.location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.location.Location = new System.Drawing.Point(93, 168);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 50);
            this.location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.location.TabIndex = 1;
            this.location.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.drop);
            this.panel1.Controls.Add(this.inventory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // drop
            // 
            this.drop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.drop.Location = new System.Drawing.Point(0, 390);
            this.drop.Name = "drop";
            this.drop.Size = new System.Drawing.Size(200, 60);
            this.drop.TabIndex = 1;
            this.drop.Text = "F - выбросить";
            this.drop.UseVisualStyleBackColor = true;
            this.drop.Click += new System.EventHandler(this.button1_Click);
            // 
            // inventory
            // 
            this.inventory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventory.FormattingEnabled = true;
            this.inventory.ItemHeight = 16;
            this.inventory.Location = new System.Drawing.Point(0, 0);
            this.inventory.Name = "inventory";
            this.inventory.Size = new System.Drawing.Size(200, 450);
            this.inventory.TabIndex = 0;
            // 
            // money
            // 
            this.money.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.money.Image = ((System.Drawing.Image)(resources.GetObject("money.Image")));
            this.money.Location = new System.Drawing.Point(348, 188);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(30, 30);
            this.money.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.money.TabIndex = 3;
            this.money.TabStop = false;
            // 
            // creeper
            // 
            this.creeper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.creeper.Image = ((System.Drawing.Image)(resources.GetObject("creeper.Image")));
            this.creeper.Location = new System.Drawing.Point(439, 188);
            this.creeper.Name = "creeper";
            this.creeper.Size = new System.Drawing.Size(30, 30);
            this.creeper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creeper.TabIndex = 4;
            this.creeper.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gamer);
            this.Controls.Add(this.money);
            this.Controls.Add(this.creeper);
            this.Controls.Add(this.location);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gamer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.money)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.creeper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox gamer;
        private System.Windows.Forms.PictureBox location;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox inventory;
        private System.Windows.Forms.PictureBox money;
        private System.Windows.Forms.Button drop;
        private System.Windows.Forms.PictureBox creeper;
    }
}

