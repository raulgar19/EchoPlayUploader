namespace EchoPlayUploader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            titleTextBox = new TextBox();
            artistTextBox = new TextBox();
            statusTextBox = new TextBox();
            audioTextLabel = new Label();
            coverTextLabel = new Label();
            label7 = new Label();
            audioBttn = new Button();
            coverBttn = new Button();
            uploadBttn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 45);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 89);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Artista(s):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 184);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Audio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 280);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 3;
            label4.Text = "Carátula:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(197, 42);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(120, 23);
            titleTextBox.TabIndex = 4;
            // 
            // artistTextBox
            // 
            artistTextBox.Location = new Point(197, 84);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(120, 23);
            artistTextBox.TabIndex = 5;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(55, 383);
            statusTextBox.Multiline = true;
            statusTextBox.Name = "statusTextBox";
            statusTextBox.ReadOnly = true;
            statusTextBox.Size = new Size(262, 50);
            statusTextBox.TabIndex = 6;
            // 
            // audioTextLabel
            // 
            audioTextLabel.AutoSize = true;
            audioTextLabel.Location = new Point(77, 152);
            audioTextLabel.Name = "audioTextLabel";
            audioTextLabel.Size = new Size(120, 15);
            audioTextLabel.TabIndex = 8;
            audioTextLabel.Text = "Archivo seleccionado";
            // 
            // coverTextLabel
            // 
            coverTextLabel.AutoSize = true;
            coverTextLabel.Location = new Point(77, 243);
            coverTextLabel.Name = "coverTextLabel";
            coverTextLabel.Size = new Size(122, 15);
            coverTextLabel.TabIndex = 7;
            coverTextLabel.Text = "Carátula seleccionada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 413);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 9;
            label7.Text = "Estado:";
            // 
            // audioBttn
            // 
            audioBttn.Location = new Point(197, 180);
            audioBttn.Name = "audioBttn";
            audioBttn.Size = new Size(120, 23);
            audioBttn.TabIndex = 10;
            audioBttn.Text = "Seleccionar audio";
            audioBttn.UseVisualStyleBackColor = true;
            audioBttn.Click += audioBttn_Click;
            // 
            // coverBttn
            // 
            coverBttn.Location = new Point(197, 276);
            coverBttn.Name = "coverBttn";
            coverBttn.Size = new Size(120, 23);
            coverBttn.TabIndex = 11;
            coverBttn.Text = "Seleccionar carátula";
            coverBttn.UseVisualStyleBackColor = true;
            coverBttn.Click += coverBttn_Click;
            // 
            // uploadBttn
            // 
            uploadBttn.Location = new Point(80, 326);
            uploadBttn.Name = "uploadBttn";
            uploadBttn.Size = new Size(237, 41);
            uploadBttn.TabIndex = 12;
            uploadBttn.Text = "Subir canción";
            uploadBttn.UseVisualStyleBackColor = true;
            uploadBttn.Click += uploadBttn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_17_sept_2025__19_06_05;
            pictureBox1.Location = new Point(360, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 450);
            Controls.Add(pictureBox1);
            Controls.Add(uploadBttn);
            Controls.Add(coverBttn);
            Controls.Add(audioBttn);
            Controls.Add(label7);
            Controls.Add(audioTextLabel);
            Controls.Add(coverTextLabel);
            Controls.Add(statusTextBox);
            Controls.Add(artistTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "EchoPlayUploader";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox titleTextBox;
        private TextBox artistTextBox;
        private TextBox statusTextBox;
        private Label audioTextLabel;
        private Label coverTextLabel;
        private Label label7;
        private Button audioBttn;
        private Button coverBttn;
        private Button uploadBttn;
        private PictureBox pictureBox1;
    }
}
