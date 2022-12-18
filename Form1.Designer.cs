
namespace Snake
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.start_button = new System.Windows.Forms.Button();
            this.Snap_button = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.TxtScore = new System.Windows.Forms.Label();
            this.TxtHighScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.SkyBlue;
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(623, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(114, 56);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.StartGame);
            // 
            // Snap_button
            // 
            this.Snap_button.BackColor = System.Drawing.Color.LimeGreen;
            this.Snap_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snap_button.Location = new System.Drawing.Point(623, 74);
            this.Snap_button.Name = "Snap_button";
            this.Snap_button.Size = new System.Drawing.Size(114, 56);
            this.Snap_button.TabIndex = 1;
            this.Snap_button.Text = "Snap";
            this.Snap_button.UseVisualStyleBackColor = false;
            this.Snap_button.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.Silver;
            this.picCanvas.Location = new System.Drawing.Point(13, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 2;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // TxtScore
            // 
            this.TxtScore.AutoSize = true;
            this.TxtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtScore.Location = new System.Drawing.Point(618, 156);
            this.TxtScore.Name = "TxtScore";
            this.TxtScore.Size = new System.Drawing.Size(94, 25);
            this.TxtScore.TabIndex = 3;
            this.TxtScore.Text = "Score: 0";
            // 
            // TxtHighScore
            // 
            this.TxtHighScore.AutoSize = true;
            this.TxtHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHighScore.Location = new System.Drawing.Point(618, 209);
            this.TxtHighScore.Name = "TxtHighScore";
            this.TxtHighScore.Size = new System.Drawing.Size(126, 25);
            this.TxtHighScore.TabIndex = 3;
            this.TxtHighScore.Text = "High Score:";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 717);
            this.Controls.Add(this.TxtHighScore);
            this.Controls.Add(this.TxtScore);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.Snap_button);
            this.Controls.Add(this.start_button);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button Snap_button;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label TxtScore;
        private System.Windows.Forms.Label TxtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}

