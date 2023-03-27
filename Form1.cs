namespace WinFormsPractice
{
    public partial class Form1 : Form
    {
        private int _numOfHorses;
        private static string[] PHRASES = { "Can't Catch me agian", "Stop bothering me", "What did I ever do to you?!", "Is this cool?", "Are you done yet?", "Hehe", "A+? You shouldn't have" };
        public Form1()
        {
            InitializeComponent();
            _numOfHorses = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < _numOfHorses; i++)
            {
                ProgressBar pb = new();
                //Attach the pb to the horses distance
            }

            HorseRacing.Program.NumOfHorses(_numOfHorses);
            HorseRacing.Program.Main();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            _numOfHorses = (int) NumberOfHorses.Value;
            ProgressBar pb = new();

            for (int i = 0; i < _numOfHorses; i++)
            {
                pb = new()
                {
                    Visible = true,
                    Value = 78,
                    Location = new Point(12, i * 20 + 12)
                };
                //Attach the pb to the horses distance
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random r = new();
            this.WildButton.Location = new Point(r.Next(12, this.Size.Width - 100), r.Next(12, this.Size.Height - 12));
            WildButton.Text = PHRASES[r.Next(0, PHRASES.Length)];
        }
    }
}