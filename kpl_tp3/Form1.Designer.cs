namespace kpl_tp3
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
            textBox1 = new TextBox();
            submitBtn = new Button();
            output = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(135, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 23);
            textBox1.TabIndex = 0;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(589, 146);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(130, 23);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += button1_Click;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(135, 196);
            output.Name = "output";
            output.Size = new Size(45, 15);
            output.TabIndex = 2;
            output.Text = "Output";
            output.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(submitBtn);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button submitBtn;
        private Label output;
    }
}
