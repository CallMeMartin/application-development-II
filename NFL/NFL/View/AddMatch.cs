using System;
using System.Windows.Forms;
using System.Drawing;
using NFL.Model;
using NFL.Controller;

namespace NFL.View
{
    public partial class AddMatch : Form
    {
        private const string POSITIV_NUMBERS_REGEX = @"^[1-9]\d*$";
        private readonly MatchController controller;
        private readonly bool isUpdateMode = false;
        private Match match = null;

        public AddMatch(MatchController controller)
        {
            InitializeComponent();
            this.controller = controller;
            match = new Match();
        }

        public AddMatch(MatchController controller, Match match)
        {
            InitializeComponent();
            this.controller = controller;
            this.match = match;
            isUpdateMode = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            HomeClubNameLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            AwayClubNameLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            HomeFinalScoreLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            AwayFinalScoreLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            HomeNumberOfTDLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            AwayNumberOfTDLabel.ForeColor = (isUpdateMode) ? Color.ForestGreen : Color.Crimson;
            WeekLabel.ForeColor = Color.ForestGreen;
            YearLabel.ForeColor = Color.ForestGreen;

            HomeClubNameTextBox.Enabled = !isUpdateMode;
            AwayClubNameTextBox.Enabled = !isUpdateMode;
            WeekNumericUpDown.Enabled = !isUpdateMode;
            YearNumericUpDown.Enabled = !isUpdateMode;

            if (isUpdateMode)
            {
                HomeClubNameTextBox.Text = match.HomeClubName;
                AwayClubNameTextBox.Text = match.AwayClubName;
                HomeFinalScoreTextBox.Text = match.HomeFinalScore.ToString();
                AwayFinalScoreTextBox.Text = match.AwayFinalScore.ToString();
                HomeNumberOfTDTextBox.Text = match.HomeNumberOfTD.ToString();
                AwayNumberOfTDTextBox.Text = match.AwayNumberOfTD.ToString();
                WeekNumericUpDown.Value = match.Week;
                YearNumericUpDown.Value = match.Year;
            }
            
            DoneButton.Text = (isUpdateMode) ? "Módosítás" : "Hozzáadás";
            DoneButton.Enabled = isUpdateMode;
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            string homeClubName = HomeClubNameTextBox.Text.TrimStart().TrimEnd();
            string awayClubName = AwayClubNameTextBox.Text.TrimStart().TrimEnd();
            int week = Convert.ToInt32(Math.Round(WeekNumericUpDown.Value, 0));
            int year = Convert.ToInt32(Math.Round(YearNumericUpDown.Value, 0));

            try
            {
                int homeFinalScore = Int32.Parse(HomeFinalScoreTextBox.Text.TrimStart().TrimEnd());
                int awayFinalScore = Int32.Parse(AwayFinalScoreTextBox.Text.TrimStart().TrimEnd());
                int homeNumberOfTD = Int32.Parse(HomeNumberOfTDTextBox.Text.TrimStart().TrimEnd());
                int awayNumberOfTD = Int32.Parse(AwayNumberOfTDTextBox.Text.TrimStart().TrimEnd());

                match.HomeClubName = homeClubName;
                match.AwayClubName = awayClubName;
                match.HomeFinalScore = homeFinalScore;
                match.AwayFinalScore = awayFinalScore;
                match.HomeNumberOfTD = homeNumberOfTD;
                match.AwayNumberOfTD = awayNumberOfTD;
                match.Week = week;
                match.Year = year;
            }
            catch
            {
                MessageBox.Show("Helytelen inputokat kapott a rendszer, így a művelet sikertelen lett!", "Sikertelen művelet", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (match == null)
            {
                MessageBox.Show("Valami hiba lépett fel új mérkőzés lérehozása során!", "Sikertelen mérkőzés létrehozás", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (isUpdateMode ? (!controller.UpdateMatch(match)) : (!controller.AddMatch(match)))
            {
                MessageBox.Show("Probléma merült fel a művelet elvégzése közben!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }

        private void formValidation(object sender, EventArgs e)
        {
            string homeClubName = HomeClubNameTextBox.Text.TrimStart().TrimEnd();
            string awayClubName = AwayClubNameTextBox.Text.TrimStart().TrimEnd();
            string homeFinalScore = HomeFinalScoreTextBox.Text.TrimStart().TrimEnd();
            string awayFinalScore = AwayFinalScoreTextBox.Text.TrimStart().TrimEnd();
            string homeNumberOfTD = HomeNumberOfTDTextBox.Text.TrimStart().TrimEnd();
            string awayNumberOfTD = AwayNumberOfTDTextBox.Text.TrimStart().TrimEnd();
            bool valid = true;

            if (homeClubName == string.Empty) {
                HomeClubNameLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                HomeClubNameLabel.ForeColor = Color.ForestGreen;
            }

            if (awayClubName == string.Empty) {
                AwayClubNameLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                AwayClubNameLabel.ForeColor = Color.ForestGreen;
            }

            if (homeFinalScore == string.Empty || !System.Text.RegularExpressions.Regex.IsMatch(homeFinalScore, POSITIV_NUMBERS_REGEX)) {
                HomeFinalScoreLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                HomeFinalScoreLabel.ForeColor = Color.ForestGreen;
            }

            if (awayFinalScore == string.Empty || !System.Text.RegularExpressions.Regex.IsMatch(awayFinalScore, POSITIV_NUMBERS_REGEX)) {
                AwayFinalScoreLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                AwayFinalScoreLabel.ForeColor = Color.ForestGreen;
            }

            if (homeNumberOfTD == string.Empty || !System.Text.RegularExpressions.Regex.IsMatch(homeNumberOfTD, POSITIV_NUMBERS_REGEX)) {
                HomeNumberOfTDLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                HomeNumberOfTDLabel.ForeColor = Color.ForestGreen;
            }

            if (awayNumberOfTD == string.Empty || !System.Text.RegularExpressions.Regex.IsMatch(awayNumberOfTD, POSITIV_NUMBERS_REGEX)) {
                AwayNumberOfTDLabel.ForeColor = Color.Crimson;
                valid = false;
            } else {
                AwayNumberOfTDLabel.ForeColor = Color.ForestGreen;
            }

            DoneButton.Enabled = valid;
        }
    }
}
