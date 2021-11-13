using System;
using System.Windows.Forms;
using NFL.Controller;
using NFL.Model;
using NFL.DAO;

namespace NFL.View
{
    public partial class MainWindow : Form
    {
        private readonly MatchController controller;

        public MainWindow()
        {
            InitializeComponent();
            controller = new MatchController(new MatchAdoDao());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateMatchList();
        }

        private void createMatch_Click(object sender, EventArgs e)
        {
            using var addMatchForm = new AddMatch(controller);

            if (addMatchForm.ShowDialog() == DialogResult.OK) updateMatchList();
        }

        private void updateMatchItem_Click(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(matchesDataGridView.CurrentRow.DataBoundItem is Match match)) return;

            using var addMatchForm = new AddMatch(controller, match);

            if (addMatchForm.ShowDialog() == DialogResult.OK) updateMatchList();
        }

        private void updateMatches_Click(object sender, EventArgs e)
        {
            updateMatchList();
        }

        private void updateMatchList()
        {
            var matches = controller.getMatches();

            matchesDataGridView.DataSource = null;
            matchesDataGridView.DataSource = matches;

            matchesDataGridView.Visible = true;

            if (matchesDataGridView.Columns.Contains("HomeNumberofTD")) matchesDataGridView.Columns["HomeNumberofTD"].Visible = false;
            if (matchesDataGridView.Columns.Contains("AwayNumberOfTD")) matchesDataGridView.Columns["AwayNumberOfTD"].Visible = false;
            if (matchesDataGridView.Columns.Contains("ID")) matchesDataGridView.Columns["ID"].Visible = false;

            if (matchesDataGridView.Columns.Contains("HomeClubName")) matchesDataGridView.Columns["HomeClubName"].HeaderText = "Hazai csapat";
            if (matchesDataGridView.Columns.Contains("AwayClubName")) matchesDataGridView.Columns["AwayClubName"].HeaderText = "Vendég csapat";
            if (matchesDataGridView.Columns.Contains("HomeFinalScore")) matchesDataGridView.Columns["HomeFinalScore"].HeaderText = "Hazai csapat pont";
            if (matchesDataGridView.Columns.Contains("AwayFinalScore")) matchesDataGridView.Columns["AwayFinalScore"].HeaderText = "Vendég csapat pont";
            if (matchesDataGridView.Columns.Contains("Week")) matchesDataGridView.Columns["Week"].HeaderText = "Hét";
            if (matchesDataGridView.Columns.Contains("Year")) matchesDataGridView.Columns["Year"].HeaderText = "Év";
        }
    }
}
