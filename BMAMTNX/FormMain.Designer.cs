namespace BMAMTNX
{
    partial class FormMain
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
            ButtonTest1 = new Button();
            ButtonTest2 = new Button();
            ButtonTest3 = new Button();
            SuspendLayout();
            // 
            // ButtonTest1
            // 
            ButtonTest1.Location = new Point(205, 90);
            ButtonTest1.Name = "ButtonTest1";
            ButtonTest1.Size = new Size(390, 63);
            ButtonTest1.TabIndex = 0;
            ButtonTest1.Text = "Test #1";
            ButtonTest1.UseVisualStyleBackColor = true;
            ButtonTest1.Click += ButtonTest1_Click;
            // 
            // ButtonTest2
            // 
            ButtonTest2.Enabled = false;
            ButtonTest2.Location = new Point(205, 192);
            ButtonTest2.Name = "ButtonTest2";
            ButtonTest2.Size = new Size(390, 63);
            ButtonTest2.TabIndex = 1;
            ButtonTest2.Text = "Test #2";
            ButtonTest2.UseVisualStyleBackColor = true;
            ButtonTest2.Click += ButtonTest2_Click;
            // 
            // ButtonTest3
            // 
            ButtonTest3.Enabled = false;
            ButtonTest3.Location = new Point(205, 294);
            ButtonTest3.Name = "ButtonTest3";
            ButtonTest3.Size = new Size(390, 63);
            ButtonTest3.TabIndex = 2;
            ButtonTest3.Text = "Test #3";
            ButtonTest3.UseVisualStyleBackColor = true;
            ButtonTest3.Click += ButtonTest3_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonTest3);
            Controls.Add(ButtonTest2);
            Controls.Add(ButtonTest1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonTest1;
        private Button ButtonTest2;
        private Button ButtonTest3;
    }
}
