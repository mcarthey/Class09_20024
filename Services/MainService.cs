using Class09_20024.Data;
using Class09_20024.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Class09_20024.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private readonly IFileService _fileService;
    public MainService(IFileService fileService)
    {
        _fileService = fileService;
    }

    public void Invoke()
    {
        // instantiate our context
        Context context = new Context();

        // ask the user for the search string
        Console.WriteLine("What movie are you looking for?");
        var searchString = Console.ReadLine();

        // this is where the 'orchestrator' could come in to combine all these into a single method call
        List<Movie> movies = context.Movies.Where(m => m.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
        List<Show> shows = context.Shows.Where(m => m.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
        List<Video> videos = context.Videos.Where(m => m.Title.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

        // add all the results to a single list of the base type
        List<Media> results = new List<Media>();
        results.AddRange(movies);
        results.AddRange(shows);
        results.AddRange(videos);

        // loop over the combined results and output them
        foreach (var media in results)
        {
            // used a trick here to get the type of the object
            // this is using something called 'reflection' 
            Console.WriteLine($"Your {media.GetType().Name}: {media.Title}");
        }
    }

    public bool Search(string myStr)
    {
        return myStr == "Pig";
    }

}
//List<string> animalList = new List<string>()
//        {
//            "Hamster", "Gerbil"
//        };
//animalList.Add("Pig");
//        animalList.Add("Dog");
//        animalList.Add("Cat");
//        animalList.Add("Ferret");

//        var pageSize = 2;
//var page = 2;
////var results = animalList.Where(Search).ToList();
////var results = animalList.Take(2).ToList();
//var results = animalList
//    .Skip(pageSize * page)
//    .Take(2)
//    .ToList();

//results.ForEach(Console.WriteLine);

