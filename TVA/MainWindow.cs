namespace TVA

{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            About about = new();
            about.StartPosition = FormStartPosition.Manual;
            about.Location = new Point(
                this.Location.X + (this.Width - about.Width) / 2,
                this.Location.Y + (this.Height - about.Height) / 2
                );
            about.ShowDialog();
            about.BringToFront();
        }

        private void computeButton_Click(object sender, EventArgs e)
        {
            float inputSum = 0;
            float.TryParse(inputTextBox.Text, out inputSum);
            float inputVat = 0;
            float.TryParse(vatTextBox.Text, out inputVat);
            float vatIndice = inputVat + 100;
            float computedVat = inputVat * inputSum / vatIndice;
            float computedSum = 100 * inputSum / vatIndice;
            resultTextBox.Text = computedSum.ToString("0.00");
            vatResult.Text = computedVat.ToString("0.00");
        }


    }
}