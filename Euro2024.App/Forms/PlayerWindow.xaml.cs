using Euro2024.Data.Entities;
using System.Windows;

namespace Euro2024.App.Forms;

/// <summary>
/// Interaction logic for PlayerWindow.xaml
/// </summary>
public partial class PlayerWindow : Window
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? FootballClub { get; set; } = null;
    public int? TransferValue { get; set; } = null;
    public int CountryId { get; set; }
    public string? PhotoLink { get; set; } = null;

    public PlayerWindow(Player? player = null)
    {
        InitializeComponent();
        if (player != null)
        {
            tbFirstName.Text = player.FirstName;
            tbLastName.Text = player.LastName;
            calendarchik.SelectedDate = player.BirthDate;
            tbFootballClub.Text = player.FootballClub;
            tbTransferValue.Text = player.TransferValue.ToString();
            cbxCountries.SelectedValue = player.Country;
            tbPhotoLink.Text = player.PhotoLink;
        }
    }

    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (cbxCountries.SelectedIndex == -1 ||
            string.IsNullOrEmpty(tbFirstName.Text) ||
            string.IsNullOrEmpty(tbLastName.Text) ||
            calendarchik.SelectedDate == null)
        {
            MessageBox.Show("Fill all required fields!!");
            return;
        }
        FirstName = tbFirstName.Text;
        LastName = tbLastName.Text;
        FootballClub = tbFootballClub.Text;
        if (int.TryParse(tbTransferValue.Text, out int transferValue))
        {
            TransferValue = transferValue;
        }
        Country country = (Country)cbxCountries.SelectedItem;
        CountryId = country.Id;
        PhotoLink = tbPhotoLink.Text;
        BirthDate = calendarchik.SelectedDate;
        DialogResult = true;
        Close();
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}
