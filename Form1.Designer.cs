namespace SnakeGamev8
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            pictureBoxDisplay = new PictureBox();
            buttonQuit = new Button();
            buttonStart = new Button();
            labelScore = new Label();
            labelHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplay).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDisplay
            // 
            pictureBoxDisplay.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxDisplay.Location = new Point(181, 68);
            pictureBoxDisplay.Name = "pictureBoxDisplay";
            pictureBoxDisplay.Size = new Size(500, 500);
            pictureBoxDisplay.TabIndex = 0;
            pictureBoxDisplay.TabStop = false;
            pictureBoxDisplay.Paint += UpadateGraphics;
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(12, 12);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(94, 29);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "Quit";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(12, 68);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(140, 29);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.Location = new Point(550, 16);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(61, 20);
            labelScore.TabIndex = 3;
            labelScore.Text = "Score: 0";
            // 
            // labelHighScore
            // 
            labelHighScore.AutoSize = true;
            labelHighScore.Location = new Point(550, 45);
            labelHighScore.Name = "labelHighScore";
            labelHighScore.Size = new Size(97, 20);
            labelHighScore.TabIndex = 4;
            labelHighScore.Text = "High Score: 0";
            // 
            // gameTimer
            // 
            gameTimer.Tick += gameTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 580);
            Controls.Add(labelHighScore);
            Controls.Add(labelScore);
            Controls.Add(buttonStart);
            Controls.Add(buttonQuit);
            Controls.Add(pictureBoxDisplay);
            Name = "Form1";
            Text = "Form1";
            KeyDown += OnKeyDown;
            KeyUp += OnKeyUp;
            ((System.ComponentModel.ISupportInitialize)pictureBoxDisplay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxDisplay;
        private Button buttonQuit;
        private Button buttonStart;
        private Label labelScore;
        private Label labelHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}
