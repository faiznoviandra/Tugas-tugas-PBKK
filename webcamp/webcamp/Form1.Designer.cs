namespace webcamp
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
            comboBoxWebcamplist = new ComboBox();
            ButtonStart = new Button();
            ButtonCapture = new Button();
            ButtonSave = new Button();
            ButtonExit = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamplist
            // 
            comboBoxWebcamplist.FormattingEnabled = true;
            comboBoxWebcamplist.Location = new Point(47, 166);
            comboBoxWebcamplist.Name = "comboBoxWebcamplist";
            comboBoxWebcamplist.Size = new Size(151, 28);
            comboBoxWebcamplist.TabIndex = 0;
            // 
            // ButtonStart
            // 
            ButtonStart.Location = new Point(47, 117);
            ButtonStart.Name = "ButtonStart";
            ButtonStart.Size = new Size(151, 43);
            ButtonStart.TabIndex = 1;
            ButtonStart.Text = "Start";
            ButtonStart.UseVisualStyleBackColor = true;
            ButtonStart.Click += ButtonStart_Click;
            // 
            // ButtonCapture
            // 
            ButtonCapture.Location = new Point(201, 444);
            ButtonCapture.Name = "ButtonCapture";
            ButtonCapture.Size = new Size(94, 47);
            ButtonCapture.TabIndex = 2;
            ButtonCapture.Text = "Capture";
            ButtonCapture.UseVisualStyleBackColor = true;
            ButtonCapture.Click += ButtonCapture_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(301, 444);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(94, 47);
            ButtonSave.TabIndex = 3;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(834, 444);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(151, 47);
            ButtonExit.TabIndex = 4;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel1.Location = new Point(201, 61);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(784, 377);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 371);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Location = new Point(395, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(386, 371);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 503);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonCapture);
            Controls.Add(ButtonStart);
            Controls.Add(comboBoxWebcamplist);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBoxWebcamplist;
        private Button ButtonStart;
        private Button ButtonCapture;
        private Button ButtonSave;
        private Button ButtonExit;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}