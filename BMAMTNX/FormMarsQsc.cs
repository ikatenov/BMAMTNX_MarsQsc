using PushButtonCells;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TenTec.Windows.iGridLib;

namespace BMAMTNX
{
    public partial class FormMarsQsc : Form
    {
        public event EventHandler<DataEnteredEventArgs>? DataEntered;

        private readonly iGButtonColumnManager BCM = new();

        private readonly int NumMeters;
        private int NumMetersConfirmed = 0;

        private iGDropDownList UnitsOfMeasureDDL;

        public FormMarsQsc(int numMeters)
        {
            NumMeters = numMeters;
            InitializeComponent();
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            UnitsOfMeasureDDL = new iGDropDownList();
            var ddlItems = typeof(eUnitsOfMeasure).GetEnumValuesWithDescription<eUnitsOfMeasure>();
            foreach (var item in ddlItems)
                UnitsOfMeasureDDL.Items.Add(item.Key, item.Value);

            iGrid1.BeginUpdate();

            int colWidth = 100;
            if (this.DeviceDpi > 96)
                colWidth = colWidth * this.DeviceDpi / 96;
            iGrid1.DefaultCol.Width = colWidth;

            iGCol col;
            col = iGrid1.Cols.Add("sn", "SN");
            col.CellStyle.ValueType = typeof(string);
            col = iGrid1.Cols.Add("start", "STARTING READING");
            col.CellStyle.ValueType = typeof(float);
            col.CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            col.DefaultCellValue = 0f;
            col = iGrid1.Cols.Add("end", "ENDING READING");
            col.CellStyle.ValueType = typeof(float);
            col.CellStyle.TextAlign = iGContentAlignment.MiddleRight;
            col.DefaultCellValue = 0f;
            col = iGrid1.Cols.Add("unit", "UNIT OF MEASURE");
            col.CellStyle.DropDownControl = UnitsOfMeasureDDL;
            col.DefaultCellValue = eUnitsOfMeasure.GAL;
            col = iGrid1.Cols.Add("valid", "VALID");
            col.DefaultCellValue = "Confirm";
            col.Tag = iGButtonColumnManager.BUTTON_COLUMN_TAG;

            iGrid1.Rows.Count = NumMeters;

            iGrid1.SetCurCell(0, 0);

            iGrid1.EndUpdate();

            BCM.CellButtonClick += BCM_CellButtonClick;
            BCM.Attach(iGrid1);
        }

        private void BCM_CellButtonClick(object sender, iGButtonColumnManager.iGCellButtonClickEventArgs e)
        {
            NumMetersConfirmed++;
            if (NumMetersConfirmed < NumMeters)
            {
                #region Only disable the clicked button
                iGrid1.Cells[e.RowIndex, e.ColIndex].Enabled = iGBool.False;
                #endregion
            }
            else
            {
                #region Pass the entered data in the DataEntered event and close the form
                MarsQscMeter[] data = new MarsQscMeter[NumMeters];
                for (int i = 0; i < NumMeters; i++)
                {
                    data[i] = new MarsQscMeter()
                    {
                        SN = (string)iGrid1.CellValues[i, "sn"],
                        StartingReading = (float)iGrid1.CellValues[i, "start"],
                        EndingReading = (float)iGrid1.CellValues[i, "end"],
                        UnitsOfMeasure = (eUnitsOfMeasure)iGrid1.CellValues[i, "unit"]
                    };
                }
                this.Close();
                DataEntered?.Invoke(this, new DataEnteredEventArgs(data));
                #endregion
            }
        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = cp.ClassStyle | CP_NOCLOSE_BUTTON;
                return cp;
            }
        }
    }

    #region Type Definitions

    public enum eUnitsOfMeasure
    {
        [Description("GALLON")]
        GAL,
        [Description("FT3")]
        M3,
        [Description("M3")]
        LITERS,
        [Description("LITER")]
        FT3,
        [Description("IMPERIAL GAL")]
        IGAL,
        [Description("ACRE FEET")]
        ACRE_FT
    }

    public class MarsQscMeter
    {
        public string? SN;
        public float StartingReading;
        public float EndingReading;
        public eUnitsOfMeasure UnitsOfMeasure;
    }

    public class DataEnteredEventArgs : EventArgs
    {
        public MarsQscMeter[] Data { get; }
        public DataEnteredEventArgs(MarsQscMeter[] data)
        {
            Data = data;
        }
    }

    #endregion

    #region Helper stuff

    // Helper class with extension methods to get enum values with their descriptions.
    // Source: https://stackoverflow.com/a/16888620/1651480
    public static class EnumExtender
    {
        public static string GetDescription(this Enum enumValue)
        {
            string output = null;
            Type type = enumValue.GetType();
            FieldInfo fi = type.GetField(enumValue.ToString());
            var attrs = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attrs.Length > 0) output = attrs[0].Description;
            return output;
        }

        public static IDictionary<T, string> GetEnumValuesWithDescription<T>(this Type type) where T : struct, IConvertible
        {
            if (!type.IsEnum)
            {
                throw new ArgumentException("T must be an enumerated type");
            }

            return type.GetEnumValues()
                    .OfType<T>()
                    .ToDictionary(
                        key => key,
                        val => (val as Enum).GetDescription()
                    );
        }
    }

    #endregion
}
