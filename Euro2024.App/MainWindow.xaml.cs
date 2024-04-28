using System.Windows;
using System.Windows.Controls;

namespace Euro2024.App;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Euro2024Manager viewModel;
    public MainWindow()
    {
        InitializeComponent();
        viewModel = new(listbox);
        DataContext = viewModel;
    }
    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) => viewModel.Search();
}