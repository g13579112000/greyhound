namespace Greyhound
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.betButton = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dogPictureBox1 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox2 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox3 = new System.Windows.Forms.PictureBox();
            this.dogPictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.joeRadioButton = new System.Windows.Forms.RadioButton();
            this.bobRadioButton = new System.Windows.Forms.RadioButton();
            this.alRadioButton = new System.Windows.Forms.RadioButton();
            this.joeTextBox = new System.Windows.Forms.TextBox();
            this.bobTextBox = new System.Windows.Forms.TextBox();
            this.alTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.raceButton.Location = new System.Drawing.Point(658, 379);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(75, 23);
            this.raceButton.TabIndex = 1;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.raceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(205, 380);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(117, 380);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 5;
            this.betButton.Text = "Bets";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.betButton_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(491, 380);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 6;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "bucks on dog number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(521, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Bets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum bet: 5 bucks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Betting Parlor";
            // 
            // dogPictureBox1
            // 
            this.dogPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox1.Image")));
            this.dogPictureBox1.Location = new System.Drawing.Point(65, 21);
            this.dogPictureBox1.Name = "dogPictureBox1";
            this.dogPictureBox1.Size = new System.Drawing.Size(79, 23);
            this.dogPictureBox1.TabIndex = 11;
            this.dogPictureBox1.TabStop = false;
            // 
            // dogPictureBox2
            // 
            this.dogPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox2.Image")));
            this.dogPictureBox2.Location = new System.Drawing.Point(65, 67);
            this.dogPictureBox2.Name = "dogPictureBox2";
            this.dogPictureBox2.Size = new System.Drawing.Size(79, 23);
            this.dogPictureBox2.TabIndex = 12;
            this.dogPictureBox2.TabStop = false;
            // 
            // dogPictureBox3
            // 
            this.dogPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox3.Image")));
            this.dogPictureBox3.Location = new System.Drawing.Point(65, 122);
            this.dogPictureBox3.Name = "dogPictureBox3";
            this.dogPictureBox3.Size = new System.Drawing.Size(79, 23);
            this.dogPictureBox3.TabIndex = 13;
            this.dogPictureBox3.TabStop = false;
            // 
            // dogPictureBox4
            // 
            this.dogPictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("dogPictureBox4.Image")));
            this.dogPictureBox4.Location = new System.Drawing.Point(65, 179);
            this.dogPictureBox4.Name = "dogPictureBox4";
            this.dogPictureBox4.Size = new System.Drawing.Size(79, 23);
            this.dogPictureBox4.TabIndex = 14;
            this.dogPictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(65, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(606, 204);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // joeRadioButton
            // 
            this.joeRadioButton.AutoSize = true;
            this.joeRadioButton.Location = new System.Drawing.Point(54, 271);
            this.joeRadioButton.Name = "joeRadioButton";
            this.joeRadioButton.Size = new System.Drawing.Size(38, 16);
            this.joeRadioButton.TabIndex = 16;
            this.joeRadioButton.TabStop = true;
            this.joeRadioButton.Text = "Joe";
            this.joeRadioButton.UseVisualStyleBackColor = true;
            // 
            // bobRadioButton
            // 
            this.bobRadioButton.AutoSize = true;
            this.bobRadioButton.Location = new System.Drawing.Point(54, 303);
            this.bobRadioButton.Name = "bobRadioButton";
            this.bobRadioButton.Size = new System.Drawing.Size(43, 16);
            this.bobRadioButton.TabIndex = 17;
            this.bobRadioButton.TabStop = true;
            this.bobRadioButton.Text = "Bob";
            this.bobRadioButton.UseVisualStyleBackColor = true;
            // 
            // alRadioButton
            // 
            this.alRadioButton.AutoSize = true;
            this.alRadioButton.Location = new System.Drawing.Point(54, 338);
            this.alRadioButton.Name = "alRadioButton";
            this.alRadioButton.Size = new System.Drawing.Size(34, 16);
            this.alRadioButton.TabIndex = 18;
            this.alRadioButton.TabStop = true;
            this.alRadioButton.Text = "Al";
            this.alRadioButton.UseVisualStyleBackColor = true;
            // 
            // joeTextBox
            // 
            this.joeTextBox.Location = new System.Drawing.Point(523, 271);
            this.joeTextBox.Name = "joeTextBox";
            this.joeTextBox.ReadOnly = true;
            this.joeTextBox.Size = new System.Drawing.Size(236, 22);
            this.joeTextBox.TabIndex = 19;
            // 
            // bobTextBox
            // 
            this.bobTextBox.Location = new System.Drawing.Point(523, 299);
            this.bobTextBox.Name = "bobTextBox";
            this.bobTextBox.ReadOnly = true;
            this.bobTextBox.Size = new System.Drawing.Size(236, 22);
            this.bobTextBox.TabIndex = 20;
            // 
            // alTextBox
            // 
            this.alTextBox.Location = new System.Drawing.Point(523, 328);
            this.alTextBox.Name = "alTextBox";
            this.alTextBox.ReadOnly = true;
            this.alTextBox.Size = new System.Drawing.Size(236, 22);
            this.alTextBox.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.alTextBox);
            this.Controls.Add(this.bobTextBox);
            this.Controls.Add(this.joeTextBox);
            this.Controls.Add(this.alRadioButton);
            this.Controls.Add(this.bobRadioButton);
            this.Controls.Add(this.joeRadioButton);
            this.Controls.Add(this.dogPictureBox4);
            this.Controls.Add(this.dogPictureBox3);
            this.Controls.Add(this.dogPictureBox2);
            this.Controls.Add(this.dogPictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.raceButton);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox dogPictureBox1;
        private System.Windows.Forms.PictureBox dogPictureBox2;
        private System.Windows.Forms.PictureBox dogPictureBox3;
        private System.Windows.Forms.PictureBox dogPictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton joeRadioButton;
        private System.Windows.Forms.RadioButton bobRadioButton;
        private System.Windows.Forms.RadioButton alRadioButton;
        private System.Windows.Forms.TextBox joeTextBox;
        private System.Windows.Forms.TextBox bobTextBox;
        private System.Windows.Forms.TextBox alTextBox;
    }
}

