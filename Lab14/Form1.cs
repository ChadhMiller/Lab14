namespace Lab14
{
    public partial class Lab14 : Form
    {
        public Lab14()
        {
            InitializeComponent();
        }

        DateTime started;

        private void btnStart_Click(object sender, EventArgs e)
        {
            grpStartingInfo.Visible = false;
            grpCounting.Visible = true;
            started = DateTime.Now;
        }

            //this is the stop button
        private void button2_Click(object sender, EventArgs e)
        {
            grpCounting.Visible = false;

            var elapsedTime = DateTime.Now - started;
            var delta = TimeSpan.FromSeconds((double)numTimerTime.Value) - elapsedTime;

            if(Math.Abs(delta.Seconds) < 1)
            {
                pnlWinner.Visible = true;
                labelrst.Text = $"You got within one second!\nActual Delta: {delta}";
            }
            else
            {
                MessageBox.Show($"You Lose\n\nYour time: {elapsedTime}\nDelta: {delta}", "Results");

                grpStartingInfo.Visible = true;
            }

            
        }
        //this is the play again button
        private void button1_Click(object sender, EventArgs e)
        {
            pnlWinner.Visible = false;
            grpStartingInfo.Visible = true;
        }
    }
}
