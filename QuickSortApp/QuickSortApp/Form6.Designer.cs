namespace QuickSortApp
{
    partial class Form6
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
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label1 = new Label();
            trackBar1 = new TrackBar();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(561, 222);
            label4.Name = "label4";
            label4.Size = new Size(241, 38);
            label4.TabIndex = 22;
            label4.Text = "character(sorted):\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 222);
            label3.Name = "label3";
            label3.Size = new Size(385, 38);
            label3.TabIndex = 21;
            label3.Text = "Original character(unsorted):\r\n";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(53, 263);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 43);
            textBox3.TabIndex = 20;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(597, 372);
            button2.Name = "button2";
            button2.Size = new Size(159, 54);
            button2.TabIndex = 19;
            button2.Text = "Enter element ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 25);
            label2.Name = "label2";
            label2.Size = new Size(535, 38);
            label2.TabIndex = 18;
            label2.Text = "Choose number of Elements to be sorted.";
            // 
            // label1
            // 
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(364, 160);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 17;
            label1.Text = "1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Brown;
            trackBar1.Location = new Point(176, 101);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(445, 56);
            trackBar1.TabIndex = 16;
            trackBar1.Value = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(561, 263);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(240, 43);
            textBox2.TabIndex = 15;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(336, 46);
            button1.Name = "button1";
            button1.Size = new Size(232, 49);
            button1.TabIndex = 14;
            button1.Text = "Enter element";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(0, 46);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(293, 49);
            textBox1.TabIndex = 13;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(561, 312);
            button3.Name = "button3";
            button3.Size = new Size(195, 54);
            button3.TabIndex = 23;
            button3.Text = "Visualization ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 24;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(55, 24);
            toolStripMenuItem1.Text = "Help";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form6";
            Text = "Sorting characters";
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Label label2;
        private Label label1;
        private TrackBar trackBar1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox1;
        private Button button3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}