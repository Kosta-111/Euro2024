using Euro2024.Data.Entities;
using System.Windows;

namespace Euro2024.App.Forms;

/// <summary>
/// Interaction logic for GameWindow.xaml
/// </summary>
public partial class GameWindow : Window
{
    public DateTime? StartTime { get; set; }
    public int StadiumId { get; set; }
    public int Team1Id { get; set; }
    public int Team2Id { get; set; }

    public GameWindow(Game? game = null)
    {
        InitializeComponent();
        if (game != null)
        {
            calendarchik.SelectedDate = game.StartTime;
            cbxStadium.SelectedValue = game.Stadium;
            cbxTeam1.SelectedValue = game.Countries.FirstOrDefault();
            cbxTeam2.SelectedValue = game.Countries.LastOrDefault();
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (cbxTeam1.SelectedIndex == -1 ||
            cbxTeam2.SelectedIndex == -1 ||
            cbxStadium.SelectedIndex == -1 ||
            calendarchik.SelectedDate == null)
        {
            MessageBox.Show("Fill all required fields!!");
            return;
        }

        StartTime = calendarchik.SelectedDate;

        Stadium stadium = (Stadium)cbxStadium.SelectedItem;
        StadiumId = stadium.Id;

        Team1Id = ((Country)cbxTeam1.SelectedItem).Id;
        Team2Id = ((Country)cbxTeam2.SelectedItem).Id;

        DialogResult = true;
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}
