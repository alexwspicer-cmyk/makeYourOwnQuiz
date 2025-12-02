namespace makeYourOwnQuiz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.bylineLabel = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.questionButton1 = new System.Windows.Forms.Button();
            this.questionButton2 = new System.Windows.Forms.Button();
            this.questionButton3 = new System.Windows.Forms.Button();
            this.questionButton4 = new System.Windows.Forms.Button();
            this.countDown = new System.Windows.Forms.Timer(this.components);
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.White;
            this.titleLabel.Font = new System.Drawing.Font("High Tower Text", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(608, 71);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "The Kiran Quiz";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bylineLabel
            // 
            this.bylineLabel.BackColor = System.Drawing.Color.Transparent;
            this.bylineLabel.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bylineLabel.ForeColor = System.Drawing.Color.White;
            this.bylineLabel.Location = new System.Drawing.Point(-4, 71);
            this.bylineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bylineLabel.Name = "bylineLabel";
            this.bylineLabel.Size = new System.Drawing.Size(611, 28);
            this.bylineLabel.TabIndex = 1;
            this.bylineLabel.Text = "Test Your Knowledge Of Kiran Paul Simmons";
            this.bylineLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // instructLabel
            // 
            this.instructLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructLabel.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.ForeColor = System.Drawing.Color.White;
            this.instructLabel.Location = new System.Drawing.Point(-4, 114);
            this.instructLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(611, 28);
            this.instructLabel.TabIndex = 2;
            this.instructLabel.Text = "Click Start To Begin!";
            this.instructLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(198, 144);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(211, 66);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // questionButton1
            // 
            this.questionButton1.BackColor = System.Drawing.Color.Black;
            this.questionButton1.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionButton1.ForeColor = System.Drawing.Color.White;
            this.questionButton1.Location = new System.Drawing.Point(54, 144);
            this.questionButton1.Margin = new System.Windows.Forms.Padding(2);
            this.questionButton1.Name = "questionButton1";
            this.questionButton1.Size = new System.Drawing.Size(211, 66);
            this.questionButton1.TabIndex = 4;
            this.questionButton1.UseVisualStyleBackColor = false;
            this.questionButton1.Visible = false;
            this.questionButton1.Click += new System.EventHandler(this.questionButton1_Click);
            // 
            // questionButton2
            // 
            this.questionButton2.BackColor = System.Drawing.Color.Black;
            this.questionButton2.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionButton2.ForeColor = System.Drawing.Color.White;
            this.questionButton2.Location = new System.Drawing.Point(343, 144);
            this.questionButton2.Margin = new System.Windows.Forms.Padding(2);
            this.questionButton2.Name = "questionButton2";
            this.questionButton2.Size = new System.Drawing.Size(211, 66);
            this.questionButton2.TabIndex = 5;
            this.questionButton2.UseVisualStyleBackColor = false;
            this.questionButton2.Visible = false;
            this.questionButton2.Click += new System.EventHandler(this.questionButton2_Click);
            // 
            // questionButton3
            // 
            this.questionButton3.BackColor = System.Drawing.Color.Black;
            this.questionButton3.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionButton3.ForeColor = System.Drawing.Color.White;
            this.questionButton3.Location = new System.Drawing.Point(54, 246);
            this.questionButton3.Margin = new System.Windows.Forms.Padding(2);
            this.questionButton3.Name = "questionButton3";
            this.questionButton3.Size = new System.Drawing.Size(211, 66);
            this.questionButton3.TabIndex = 6;
            this.questionButton3.UseVisualStyleBackColor = false;
            this.questionButton3.Visible = false;
            this.questionButton3.Click += new System.EventHandler(this.questionButton3_Click);
            // 
            // questionButton4
            // 
            this.questionButton4.BackColor = System.Drawing.Color.Black;
            this.questionButton4.Font = new System.Drawing.Font("High Tower Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionButton4.ForeColor = System.Drawing.Color.White;
            this.questionButton4.Location = new System.Drawing.Point(343, 246);
            this.questionButton4.Margin = new System.Windows.Forms.Padding(2);
            this.questionButton4.Name = "questionButton4";
            this.questionButton4.Size = new System.Drawing.Size(211, 66);
            this.questionButton4.TabIndex = 7;
            this.questionButton4.UseVisualStyleBackColor = false;
            this.questionButton4.Visible = false;
            this.questionButton4.Click += new System.EventHandler(this.questionButton4_Click);
            // 
            // countDown
            // 
            this.countDown.Enabled = true;
            this.countDown.Interval = 1000;
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.Font = new System.Drawing.Font("High Tower Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.remainingTimeLabel.Location = new System.Drawing.Point(4, 320);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(237, 37);
            this.remainingTimeLabel.TabIndex = 8;
            this.remainingTimeLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.questionButton4);
            this.Controls.Add(this.questionButton3);
            this.Controls.Add(this.questionButton2);
            this.Controls.Add(this.questionButton1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.bylineLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "The Kiran Quiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label bylineLabel;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button questionButton1;
        private System.Windows.Forms.Button questionButton2;
        private System.Windows.Forms.Button questionButton3;
        private System.Windows.Forms.Button questionButton4;
        private System.Windows.Forms.Timer countDown;
        private System.Windows.Forms.Label remainingTimeLabel;
    }
}

