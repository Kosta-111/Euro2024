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
