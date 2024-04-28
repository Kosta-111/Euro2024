using Euro2024.Data.Entities;
using System.Windows;

namespace Euro2024.App.Forms;

/// <summary>
/// Interaction logic for TicketWindow.xaml
/// </summary>
public partial class TicketWindow : Window
{
    public int Id { get; set; }
    public string Place { get; set; }
    public decimal Price { get; set; }
    public bool IsSold { get; set; }
    public int GameId { get; set; }

    public TicketWindow(Ticket? ticket = null)
    {
        InitializeComponent();
        if (ticket != null)
        {
            tbPlace.Text = ticket.Place;
            tbPrice.Text = ticket.Price.ToString();
            cbIsSold.IsChecked = ticket.IsSold;
            cbxGames.SelectedValue = ticket.Game;
        }
    }
    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {
        if (cbxGames.SelectedIndex == -1 ||
            string.IsNullOrEmpty(tbPlace.Text) ||
            string.IsNullOrEmpty(tbPrice.Text))
        {
            MessageBox.Show("Fill all required fields!!");
            return;
        }

        Place = tbPlace.Text;
        IsSold = (bool)cbIsSold.IsChecked!;

        if (decimal.TryParse(tbPrice.Text, out decimal price))
        {
            Price = price;
        }
        Game game = (Game)cbxGames.SelectedItem;
        GameId = game.Id;
        DialogResult = true;
        Close();
    }
    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = false;
        Close();
    }
}
