using Euro2024.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
