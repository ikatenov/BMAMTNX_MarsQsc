namespace BMAMTNX
{
    partial class FormMarsQsc
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
            iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            iGrid1DefaultCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            iGrid1DefaultColHdrStyle = new TenTec.Windows.iGridLib.iGColHdrStyle(true);
            iGrid1RowTextColCellStyle = new TenTec.Windows.iGridLib.iGCellStyle(true);
            ((System.ComponentModel.ISupportInitialize)iGrid1).BeginInit();
            SuspendLayout();
            // 
            // iGrid1
            // 
            iGrid1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            iGrid1.DefaultAutoGroupRow.Height = 38;
            iGrid1.DefaultCol.CellStyle = iGrid1DefaultCellStyle;
            iGrid1.DefaultCol.ColHdrStyle = iGrid1DefaultColHdrStyle;
            iGrid1.DefaultRow.Height = 38;
            iGrid1.DefaultRow.NormalCellHeight = 38;
            iGrid1.Header.Height = 35;
            iGrid1.Location = new Point(12, 12);
            iGrid1.Name = "iGrid1";
            iGrid1.Size = new Size(1590, 574);
            iGrid1.TabIndex = 0;
            // 
            // FormMarsQsc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1614, 598);
            Controls.Add(iGrid1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMarsQsc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MarsQsc";
            FormClosed += FormMarsQsc_FormClosed;
            ((System.ComponentModel.ISupportInitialize)iGrid1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TenTec.Windows.iGridLib.iGrid iGrid1;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1DefaultCellStyle;
        private TenTec.Windows.iGridLib.iGColHdrStyle iGrid1DefaultColHdrStyle;
        private TenTec.Windows.iGridLib.iGCellStyle iGrid1RowTextColCellStyle;
    }
}