using Euro2024.App.Forms;
using Euro2024.Data;
using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Euro2024.App;

[AddINotifyPropertyChangedInterface]
public class Euro2024Manager
{
    private readonly Euro2024DbContext context;

    private ObservableCollection<CountryVm>? countries = null;
    private ObservableCollection<PlayerVM>? players = null;
    private ObservableCollection<StadiumVM>? stadiums = null;
    private ObservableCollection<GameVM>? games = null;
    public ObservableCollection<TicketVM>? tickets = null;

    public IEnumerable<CountryVm>? Countries => countries;
    public IEnumerable<PlayerVM>? Players => players;
    public IEnumerable<StadiumVM>? Stadiums => stadiums;
    public IEnumerable<GameVM>? Games => games;
    public IEnumerable<TicketVM>? Tickets => tickets;

    private RelayCommand countriesCommand;
    private RelayCommand playersCommand;
    private RelayCommand stadiumsCommand;
    private RelayCommand gamesCommand;
    private RelayCommand ticketsCommand;
    private RelayCommand addCommand;
    private RelayCommand editCommand;
    private RelayCommand deleteCommand;
    private RelayCommand topPlayersCommand;
    private RelayCommand topCountriesCommand;
    private RelayCommand topStadiumsCommand;
    public ICommand CountriesCommand => countriesCommand;
    public ICommand PlayersCommand => playersCommand;
    public ICommand StadiumsCommand => stadiumsCommand;
    public ICommand GamesCommand => gamesCommand;
    public ICommand TicketsCommand => ticketsCommand;
    public ICommand AddCommand => addCommand;
    public ICommand EditCommand => editCommand;
    public ICommand DeleteCommand => deleteCommand;
    public ICommand TopPlayersCommand => topPlayersCommand;
    public ICommand TopCountriesCommand => topCountriesCommand;
    public ICommand TopStadiumsCommand => topStadiumsCommand;


    private ListBox lb = new();

    public object? SelectedItem { get; set; }
    public string? CurrentType { get; set; }
    public string? SearchedText { get; set; } 

    public Euro2024Manager(ListBox listbox)
    {
        context = new();
        LoadCountries();
        lb = listbox;

        countriesCommand = new RelayCommand(o => LoadCountries(), o => CurrentType != nameof(Countries));
        playersCommand = new RelayCommand(o => LoadPlayers(), o => CurrentType != nameof(Players));
        stadiumsCommand = new RelayCommand(o => LoadStadiums(), o => CurrentType != nameof(Stadiums));
        gamesCommand = new RelayCommand(o => LoadGames(), o => CurrentType != nameof(Games));
        ticketsCommand = new RelayCommand(o => LoadTickets(), o => CurrentType != nameof(Tickets));

        addCommand = new RelayCommand(o => Add(), o => CurrentType is nameof(Players) or nameof(Games) or nameof(Tickets));
        editCommand = new RelayCommand(o => Edit(), o => SelectedItem is PlayerVM or GameVM or TicketVM);
        deleteCommand = new RelayCommand(o => Delete(), o => SelectedItem is PlayerVM or GameVM or TicketVM);

        topPlayersCommand = new RelayCommand(o => TopPlayers());
        topCountriesCommand = new RelayCommand(o => TopCountries());
        topStadiumsCommand = new RelayCommand(o => TopStadiums());
    }    

    public void Search()
    {
        if (CurrentType is nameof(Countries)) LoadCountries();
        else if (CurrentType is nameof(Games)) LoadGames();
        else if (CurrentType is nameof(Tickets)) LoadTickets();
        else if (CurrentType is nameof(Stadiums)) LoadStadiums();
        else if (CurrentType is nameof(Players)) LoadPlayers();
    }

    private void Add()
    {
        if (CurrentType is nameof(Players)) AddPlayer();
        else if (CurrentType is nameof(Games)) AddGame();
        else if (CurrentType is nameof(Tickets)) AddTicket();
    }

    private void Edit()
    {
        if (SelectedItem is PlayerVM) EditPlayer();
        else if (SelectedItem is GameVM) EditGame();
        else if (SelectedItem is TicketVM) EditTicket();
    }

    private void AddTicket()
    {
        TicketWindow ticketWindow = new();
        ticketWindow.cbxGames.ItemsSource = context.Games.ToList();
        var result = ticketWindow.ShowDialog();

        if (result != true) return;
        try
        {
            context.Tickets.Add(new Ticket
            {
                Place = ticketWindow.Place,
                Price = ticketWindow.Price,
                IsSold = ticketWindow.IsSold,
                GameId = ticketWindow.GameId
            });
            context.SaveChanges();
            MessageBox.Show("Ticket created!!!");
            LoadTickets();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void EditTicket()
    {
        TicketVM currentTicketM = (TicketVM)SelectedItem!;
        Ticket? currentTicket = context.Tickets.FirstOrDefault(x => x.Id == currentTicketM.Id);

        if (currentTicket == null) return;

        TicketWindow ticketWindow = new(currentTicket);
        ticketWindow.cbxGames.ItemsSource = context.Games.ToList();
        var result = ticketWindow.ShowDialog();

        if (result != true) return;

        try
        {
            currentTicket.Place = ticketWindow.Place;
            currentTicket.Price = ticketWindow.Price;
            currentTicket.IsSold = ticketWindow.IsSold;
            currentTicket.GameId = ticketWindow.GameId;
            context.SaveChanges();
            MessageBox.Show("Ticket edited!!!");
            LoadTickets();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void AddGame()
    {
        GameWindow gameWindow = new();
        gameWindow.cbxTeam1.ItemsSource = context.Countries.ToList();
        gameWindow.cbxTeam2.ItemsSource = context.Countries.ToList();
        gameWindow.cbxStadium.ItemsSource = context.Stadiums.ToList();

        var result = gameWindow.ShowDialog();

        if (result != true) return;
        try
        {
            if (gameWindow.Team1Id == gameWindow.Team2Id)
                throw new Exception("What are you doing?\nTeam can't play with itself!!");
            Game game = new Game
            {
                StartTime = (DateTime)gameWindow.StartTime!,
                StadiumId = gameWindow.StadiumId
            };
            game.Countries.Add(context.Countries.First(c => c.Id == gameWindow.Team1Id));
            game.Countries.Add(context.Countries.First(c => c.Id == gameWindow.Team2Id));
            context.Games.Add(game);
            context.SaveChanges();
            MessageBox.Show("Game created!!!");
            LoadGames();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void EditGame()
    {
        GameVM currentGameVM = (GameVM)SelectedItem!;
        Game? currentGame = context.Games.FirstOrDefault(x => x.Id == currentGameVM.Id);

        if (currentGame == null) return;

        GameWindow gameWindow = new(currentGame);
        gameWindow.cbxTeam1.ItemsSource = context.Countries.ToList();
        gameWindow.cbxTeam2.ItemsSource = context.Countries.ToList();
        gameWindow.cbxStadium.ItemsSource = context.Stadiums.ToList();
        var result = gameWindow.ShowDialog();

        if (result != true) return;

        try
        {
            if (gameWindow.Team1Id == gameWindow.Team2Id)
                throw new Exception("What are you doing?\nTeam can't play with itself!!");

            currentGame.StadiumId = gameWindow.StadiumId;
            currentGame.StartTime = (DateTime)gameWindow.StartTime!;
            currentGame.Countries.Clear();
            currentGame.Countries.Add(context.Countries.First(c => c.Id == gameWindow.Team1Id));
            currentGame.Countries.Add(context.Countries.First(c => c.Id == gameWindow.Team2Id));
            
            context.SaveChanges();
            MessageBox.Show("Game edited!!!");
            LoadGames();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void AddPlayer()
    {
        PlayerWindow playerWindow = new();
        playerWindow.cbxCountries.ItemsSource = context.Countries.ToList();
        var result = playerWindow.ShowDialog();

        if (result != true) return;
        try
        {
            context.Players.Add(new Player
            {
                FirstName = playerWindow.FirstName,
                LastName = playerWindow.LastName,
                BirthDate = (DateTime)playerWindow.BirthDate!,
                CountryId = playerWindow.CountryId,
                FootballClub = playerWindow.FootballClub,
                PhotoLink = playerWindow.PhotoLink,
                TransferValue = playerWindow.TransferValue
            });
            context.SaveChanges();
            MessageBox.Show("Player created!!!");
            LoadPlayers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void EditPlayer()
    {
        PlayerVM currentPlayerVM = (PlayerVM)SelectedItem!;
        Player? currentPlayer = context.Players.FirstOrDefault(x => x.Id == currentPlayerVM.Id);

        if (currentPlayer == null) return;

        PlayerWindow playerWindow = new(currentPlayer);
        playerWindow.cbxCountries.ItemsSource = context.Countries.ToList();
        var result = playerWindow.ShowDialog();

        if (result != true) return;

        try
        {
            currentPlayer.FirstName = playerWindow.FirstName;
            currentPlayer.LastName = playerWindow.LastName;
            currentPlayer.BirthDate = (DateTime)playerWindow.BirthDate!;
            currentPlayer.CountryId = playerWindow.CountryId;
            currentPlayer.FootballClub = playerWindow.FootballClub;
            currentPlayer.PhotoLink = playerWindow.PhotoLink;
            currentPlayer.TransferValue = playerWindow.TransferValue;
            context.SaveChanges();
            MessageBox.Show("Player edited!!!");
            LoadPlayers();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void Delete()
    {
        if (SelectedItem is PlayerVM player)
        {
            context.Players.Where(p => p.Id == player.Id).ExecuteDelete();
            LoadPlayers();
        }
        else if (SelectedItem is GameVM game)
        {
            context.Games.Where(g => g.Id == game.Id).ExecuteDelete();
            LoadGames();
        }
        else if (SelectedItem is TicketVM ticket)
        {
            context.Tickets.Where(t => t.Id == ticket.Id).ExecuteDelete();
            LoadTickets();
        }
    }
    private void LoadCountries()
    {
        countries = string.IsNullOrEmpty(SearchedText) ?
            new(context.Countries.Select(x => new CountryVm(x))) :
            new(context.Countries.Where(x => x.Name.Contains(SearchedText)).Select(x => new CountryVm(x)));
        CurrentType = nameof(Countries);
        lb.ItemsSource = Countries;
        lb.ItemsSource = null;
    }
    private void LoadGames()
    {
        games = string.IsNullOrEmpty(SearchedText) ? 
            new(context.Games.Include(x => x.Countries).Include(x => x.Stadium).Select(x => new GameVM(x))) :
            new(context.Games.Include(x => x.Countries).Include(x => x.Stadium)
               .Where(x => x.Countries.Any(y => y.Name.Contains(SearchedText)) || 
                      x.Stadium.Name.Contains(SearchedText))
                .Select(x => new GameVM(x)));
        CurrentType = nameof(Games);
        lb.ItemsSource = Games;
        lb.ItemsSource = null;
    }

    private void LoadStadiums()
    {
        stadiums = string.IsNullOrEmpty(SearchedText) ? 
            new(context.Stadiums.Include(x => x.Country).Select(x => new StadiumVM(x))) :
            new(context.Stadiums.Include(x => x.Country)
                .Where(x => x.Name.Contains(SearchedText) || x.Settlement.Contains(SearchedText))
                .Select(x => new StadiumVM(x)));
        CurrentType = nameof(Stadiums);
        lb.ItemsSource = Stadiums;
        lb.ItemsSource = null;
    }

    private void LoadPlayers()
    {
        players = string.IsNullOrEmpty(SearchedText) ?
            new(context.Players.Include(x => x.Country).Select(x => new PlayerVM(x))) :
            new(context.Players.Include(x => x.Country)
            .Where(x => x.FirstName.Contains(SearchedText) || x.LastName.Contains(SearchedText) ||
                        x.FootballClub.Contains(SearchedText))
            .Select(x => new PlayerVM(x)));
        CurrentType = nameof(Players);
        lb.ItemsSource = Players;
        lb.ItemsSource = null;
    }

    private void LoadTickets()
    {
        tickets = string.IsNullOrEmpty(SearchedText) ?
            new(context.Tickets.Include(x => x.Game).ThenInclude(x => x.Stadium).Include(x => x.Game).ThenInclude(x => x.Countries).Select(x => new TicketVM(x))) :
            new(context.Tickets.Include(x => x.Game).ThenInclude(x => x.Stadium).Include(x => x.Game).ThenInclude(x => x.Countries)
            .Where(x => x.Place.Contains(SearchedText))
            .Select(x => new TicketVM(x)));
        CurrentType = nameof(Tickets);
        lb.ItemsSource = Tickets;
        lb.ItemsSource = null;
    }

    private void TopStadiums()
    {
        var stadiums = context.Stadiums.OrderByDescending(s => s.Capacity).Take(3).ToList();

        StringBuilder sb = new();
        for (int i = 0; i < stadiums.Count; i++)
        {
            sb.AppendLine($"{i + 1}. {stadiums[i]} : {stadiums[i].Capacity} places");
        }
        MessageBox.Show(sb.ToString(), "TOP 5 biggest stadiums");
    }

    private void TopCountries()
    {
        var countries = context.Countries.OrderByDescending(c => c.WinningsCount).Take(5).ToList();

        StringBuilder sb = new();
        for (int i = 0; i < countries.Count; i++)
        {
            sb.AppendLine($"{i + 1}. {countries[i]} - {countries[i].WinningsCount} Winnings");
        }
        MessageBox.Show(sb.ToString(), "TOP 5 most successful countries");
    }

    private void TopPlayers()
    {
        var players = context.Players.Include(x => x.Country)
            .OrderByDescending(p => p.TransferValue).Take(5).ToList();

        StringBuilder sb = new();
        for (int i = 0; i < players.Count; i++)
        {
            sb.AppendLine($"{i + 1}. {players[i]} - {players[i].TransferValue} EUR");
        }
        MessageBox.Show(sb.ToString(), "TOP 5 most expensive players");
    }
}
