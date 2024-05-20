namespace HardwareShopManagement1
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
            button4 = new Button();
            Input_data1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(453, 399);
            button4.Name = "button4";
            button4.Size = new Size(234, 55);
            button4.TabIndex = 8;
            button4.Text = "Close App";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Input_data1
            // 
            Input_data1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Input_data1.Location = new Point(453, 101);
            Input_data1.Name = "Input_data1";
            Input_data1.Size = new Size(234, 55);
            Input_data1.TabIndex = 5;
            Input_data1.Text = "Select To Input Your Item\r\n";
            Input_data1.UseVisualStyleBackColor = true;
            Input_data1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(453, 294);
            button2.Name = "button2";
            button2.Size = new Size(234, 55);
            button2.TabIndex = 6;
            button2.Text = "Bill";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(453, 194);
            button3.Name = "button3";
            button3.Size = new Size(234, 55);
            button3.TabIndex = 7;
            button3.Text = "Categories";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1157, 607);
            Controls.Add(button4);
            Controls.Add(Input_data1);
            Controls.Add(button2);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "HardShop";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private Button Input_data1;
        private Button button2;
        private Button button3;
    }
}
