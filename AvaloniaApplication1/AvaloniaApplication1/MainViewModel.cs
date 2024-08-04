using System;

namespace AvaloniaApplication1;

using ReactiveUI;
using System.Collections.ObjectModel;

public class MainViewModel : ReactiveObject
{
    private ObservableCollection<Manga> mangas = new ObservableCollection<Manga>();
    public ObservableCollection<Manga> Mangas
    {
        get => mangas;
        set => this.RaiseAndSetIfChanged(ref mangas, value);
    }
    
    private string testProperty = "please work";
    public string TestProperty
    {
        get => testProperty;
        set => this.RaiseAndSetIfChanged(ref testProperty, value);
    }

    public MainViewModel()
    {
        Mangas = new ObservableCollection<Manga>
        {
            new Manga { Title = "Manga 1", Author = "Author 1", CoverImageUrl = "cover1.jpg", Description = "Description 1" },
            new Manga { Title = "Manga 2", Author = "Author 2", CoverImageUrl = "cover2.jpg", Description = "Description 2" }
        };
        
        Console.WriteLine("Mangas collection initialized with the following data:");
        foreach (var manga in Mangas)
        {
            Console.WriteLine($"Title: {manga.Title}, Author: {manga.Author}, CoverImageUrl: {manga.CoverImageUrl}, Description: {manga.Description}");
        }
    }
}
