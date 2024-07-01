using PushButtonCells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

namespace BMAMTNX
{
    public partial class FormMarsQsc : Form
    {
        public event EventHandler<DataEnteredEventArgs>? DataEntered;

        private readonly iGButtonColumnManager BCM = new iGButtonColumnManager();

        private int NumMeters;
        private int NumMetersConfirmed = 0;

        public FormMarsQsc(int numMeters)
        {
            NumMeters = numMeters;
            InitializeComponent();
            InitializeGrid(numMeters);
        }

        private void InitializeGrid(int numMeters)
        {
            iGrid1.BeginUpdate();

            iGCol col;
            col = iGrid1.Cols.Add("sn", "SN");
            col = iGrid1.Cols.Add("start", "STARTING READING");
            col = iGrid1.Cols.Add("end", "ENDING READING");
            col = iGrid1.Cols.Add("valid", "VALID");
            col.DefaultCellValue = "Confirm";
            col.Tag = iGButtonColumnManager.BUTTON_COLUMN_TAG;
            iGrid1.Cols.AutoWidth();

            iGrid1.Rows.Count = numMeters;

            iGrid1.EndUpdate();

            BCM.CellButtonClick += BCM_CellButtonClick;
            BCM.Attach(iGrid1);
        }

        private void BCM_CellButtonClick(object sender, iGButtonColumnManager.iGCellButtonClickEventArgs e)
        {
            NumMetersConfirmed++;
            if (NumMetersConfirmed == NumMeters)
            {
                this.Close();
                DataEntered?.Invoke(this, new DataEnteredEventArgs());
            }
            else
            {
                iGrid1.Cells[e.RowIndex, e.ColIndex].Enabled = iGBool.False;
            }
        }
    }

    #region Data & Event Definitions

    public class MarsQscMeter
    {
        public string? SN;
        public float StartingReading;
        public float EndingReading;
    }

    public class DataEnteredEventArgs : EventArgs
    {
        public MarsQscMeter[] Data { get; }
        public DataEnteredEventArgs()
        {
            Data = Array.Empty<MarsQscMeter>();
        }
    }

    #endregion
}
