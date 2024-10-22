namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            imageList1 = new ImageList(components);
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 36);
            label1.Name = "label1";
            label1.Size = new Size(46, 26);
            label1.TabIndex = 0;
            label1.Text = "Bot";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(109, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 243);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(491, 36);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 243);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(109, 363);
            button1.Name = "button1";
            button1.Size = new Size(134, 36);
            button1.TabIndex = 5;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(414, 36);
            label2.Name = "label2";
            label2.Size = new Size(73, 26);
            label2.TabIndex = 6;
            label2.Text = "Player";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(491, 363);
            button2.Name = "button2";
            button2.Size = new Size(134, 36);
            button2.TabIndex = 7;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 299);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "label3";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "poker1.jpg");
            imageList1.Images.SetKeyName(1, "poker2.jpg");
            imageList1.Images.SetKeyName(2, "poker3.jpg");
            imageList1.Images.SetKeyName(3, "poker4.jpg");
            imageList1.Images.SetKeyName(4, "poker5.jpg");
            imageList1.Images.SetKeyName(5, "poker6.jpg");
            imageList1.Images.SetKeyName(6, "poker7.jpg");
            imageList1.Images.SetKeyName(7, "poker8.jpg");
            imageList1.Images.SetKeyName(8, "poker9.jpg");
            imageList1.Images.SetKeyName(9, "poker10.jpg");
            imageList1.Images.SetKeyName(10, "poker11.jpg");
            imageList1.Images.SetKeyName(11, "poker12.jpg");
            imageList1.Images.SetKeyName(12, "poker13.jpg");
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label2;
        private Button button2;
        private Label label3;
        private ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
    }
}