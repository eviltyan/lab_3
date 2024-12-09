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
            this.components = new System.ComponentModel.Container();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.gamer = new System.Windows.Forms.PictureBox();
            this.location = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gamer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerGame
            // 
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // gamer
            // 
            this.gamer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gamer.Location = new System.Drawing.Point(93, 314);
            this.gamer.Name = "gamer";
            this.gamer.Size = new System.Drawing.Size(100, 50);
            this.gamer.TabIndex = 0;
            this.gamer.TabStop = false;
            // 
            // location
            // 
            this.location.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.location.Location = new System.Drawing.Point(93, 168);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(100, 50);
            this.location.TabIndex = 1;
            this.location.TabStop = false;
            this.location.Click += new System.EventHandler(this.location_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gamer);
            this.Controls.Add(this.location);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Gamer_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gamer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gamer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.location)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.PictureBox gamer;
        private System.Windows.Forms.PictureBox location;
    }
}

