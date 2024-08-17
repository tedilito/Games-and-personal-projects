namespace QuickSortApp
{
    partial class Form8
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
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(212, 75);
            button2.Name = "button2";
            button2.Size = new Size(184, 93);
            button2.TabIndex = 1;
            button2.Text = "3";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 75);
            button1.Name = "button1";
            button1.Size = new Size(184, 93);
            button1.TabIndex = 2;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(416, 75);
            button3.Name = "button3";
            button3.Size = new Size(184, 93);
            button3.TabIndex = 3;
            button3.Text = "1";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(616, 75);
            button4.Name = "button4";
            button4.Size = new Size(184, 93);
            button4.TabIndex = 4;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(820, 75);
            button5.Name = "button5";
            button5.Size = new Size(184, 93);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1020, 276);
            button6.Name = "button6";
            button6.Size = new Size(184, 93);
            button6.TabIndex = 6;
            button6.Text = "Start the visualization";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Location = new Point(41, 242);
            label1.Name = "label1";
            label1.Size = new Size(54, 37);
            label1.TabIndex = 7;
            // 
            // label2
            // 
            label2.BackColor = Color.Green;
            label2.Location = new Point(41, 293);
            label2.Name = "label2";
            label2.Size = new Size(54, 37);
            label2.TabIndex = 8;
            // 
            // label3
            // 
            label3.Location = new Point(101, 250);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 9;
            label3.Text = "-The box with red is Pivot";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Location = new Point(92, 303);
            label4.Name = "label4";
            label4.Size = new Size(277, 27);
            label4.TabIndex = 10;
            label4.Text = "-This indicates the swap with the pivot";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 416);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Name = "Form8";
            Text = "Visuzalization(Example)";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}