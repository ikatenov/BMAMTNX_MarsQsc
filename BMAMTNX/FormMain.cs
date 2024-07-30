namespace BMAMTNX
{
    public partial class FormMain : Form
    {
        FormMarsQsc? MeterDataEntryForm;
        MarsQscMeter[] MeterData;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonTest1_Click(object sender, EventArgs e)
        {
            int NumMeters = 2;
            MeterDataEntryForm = new FormMarsQsc();
            MeterDataEntryForm.DataEntered += FormMarsQsc_DataEntered;
            MeterDataEntryForm.Show("Test #1", NumMeters);

            ButtonTest1.Enabled = false;
            ButtonTest2.Enabled = true;
        }

        private void ButtonTest2_Click(object sender, EventArgs e)
        {
            MeterDataEntryForm = new FormMarsQsc();
            MeterDataEntryForm.DataEntered += FormMarsQsc_DataEntered;
            MeterDataEntryForm.Show("Test #2", MeterData);

            ButtonTest2.Enabled = false;
            ButtonTest3.Enabled = true;
        }

        private void ButtonTest3_Click(object sender, EventArgs e)
        {
            MeterDataEntryForm = new FormMarsQsc();
            MeterDataEntryForm.DataEntered += FormMarsQsc_DataEntered;
            MeterDataEntryForm.Show("Test #3", MeterData);

            ButtonTest3.Enabled = false;
        }

        private void FormMarsQsc_DataEntered(object? sender, DataEnteredEventArgs e)
        {
            MeterData = e.Data;
            MessageBox.Show($"Count = {e.Data.Length}", "FormMarsQsc_DataEntered");
        }
    }
}
