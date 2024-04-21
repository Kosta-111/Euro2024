using Euro2024.Data;
using Euro2024.Data.Entities;
using Microsoft.EntityFrameworkCore;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    private ObservableCollection<TicketVM>? tickets = null;

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
    public ICommand CountriesCommand => countriesCommand;
    public ICommand PlayersCommand => playersCommand;
    public ICommand StadiumsCommand => stadiumsCommand;
    public ICommand GamesCommand => gamesCommand;
    public ICommand TicketsCommand => ticketsCommand;

    public object? SelectedItem { get; set; }
    public string? CurrentType { get; set; }

    public Euro2024Manager()
    {
        context = new();
        CurrentType = nameof(Countries);
        countries = new(context.Countries.Select(x => new CountryVm(x)));
        players = new(context.Players.Select(x => new PlayerVM(x)));
        stadiums = new(context.Stadiums.Select(x => new StadiumVM(x)));
        games = new(context.Games.Include(x => x.Countries).Select(x => new GameVM(x)));
        tickets = new(context.Tickets.Select(x => new TicketVM(x)));

        countriesCommand = new RelayCommand(o => CurrentType = nameof(Countries), o => CurrentType != nameof(Countries));
        playersCommand = new RelayCommand(o => CurrentType = nameof(Players), o => CurrentType != nameof(Players));
        stadiumsCommand = new RelayCommand(o => CurrentType = nameof(Stadiums), o => CurrentType != nameof(Stadiums));
        gamesCommand = new RelayCommand(o => CurrentType = nameof(Games), o => CurrentType != nameof(Games));
        ticketsCommand = new RelayCommand(o => CurrentType = nameof(Tickets), o => CurrentType != nameof(Tickets));
    }
    public void LoadCountries()
    {
        //CurrentType = nameof(Countries);
        //countries = new(context.Countries.Select(x => new CountryVm(x)));

        //if (SelectedCountry == null)
        //{
        //    return;
        //}
        //int index = countries.IndexOf(SelectedCountry);
        //if (index > 0)
        //{
        //    SelectedCountry = countries[--index];
        //}
    }
}
