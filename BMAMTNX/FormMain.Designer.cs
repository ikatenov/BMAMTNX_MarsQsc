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
            ButtonStartTest = new Button();
            SuspendLayout();
            // 
            // ButtonStartTest
            // 
            ButtonStartTest.Location = new Point(205, 194);
            ButtonStartTest.Name = "ButtonStartTest";
            ButtonStartTest.Size = new Size(390, 63);
            ButtonStartTest.TabIndex = 0;
            ButtonStartTest.Text = "Start Test";
            ButtonStartTest.UseVisualStyleBackColor = true;
            ButtonStartTest.Click += ButtonStartTest_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonStartTest);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonStartTest;
    }
}
