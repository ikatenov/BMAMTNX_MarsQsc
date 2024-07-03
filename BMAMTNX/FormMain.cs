namespace BMAMTNX
{
    public partial class FormMain : Form
    {
        FormMarsQsc? formMarsQsc;

        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonStartTest_Click(object sender, EventArgs e)
        {
            int NumMeters = 2;
            formMarsQsc = new FormMarsQsc(NumMeters);
            formMarsQsc.DataEntered += FormMarsQsc_DataEntered;
            formMarsQsc.Show();
            ButtonStartTest.Enabled = false;
        }

        private void FormMarsQsc_DataEntered(object? sender, DataEnteredEventArgs e)
        {
            MessageBox.Show($"Count = {e.Data.Length}", "FormMarsQsc_DataEntered");
        }
    }
}
