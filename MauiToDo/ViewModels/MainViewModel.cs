using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDo.Models;
using MauiToDo.Services;
using System.Collections.ObjectModel;

namespace MauiToDo.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<Note> notes = new ObservableCollection<Note>();

        private readonly JsonServices jsonServices;

        public MainViewModel(JsonServices jsonServices)
        {
            this.jsonServices = jsonServices;
        }


        [RelayCommand]
        async Task AddAsync()
        {
            Note note = new Note() { HexColor = new NoteColor() 
                                   { ColorName = "Light yellow", 
                                     ColorHex = "#FDCB36" }};

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}",
               true,
               new Dictionary<string, object>
               {{"Note", note }});

            Notes.Add(note);

            SortNotesByDate();

            await jsonServices.WriteToFileAsync(Notes);
        }

        [RelayCommand]
        async Task DeleteAsync(Note note)
        {
            Notes.Remove(note);

            SortNotesByDate();

            await jsonServices.WriteToFileAsync(Notes);
        }

        [RelayCommand]
        async Task GoToDetail(Note note)
        {
            if (note is null) return;

            await Shell.Current.GoToAsync($"{nameof(DetailsPage)}",
                true,
                new Dictionary<string, object>
                {{"Note", note}});

            note.Date = DateTime.Now;

            SortNotesByDate();

            await jsonServices.WriteToFileAsync(Notes);
        }

        public async Task GetNotesAsync()
        {
            notes.Clear();
            var notesList = await jsonServices.ReadFromFileAsync();

            if (notesList.Count is not 0)
            {
                foreach (var note in notesList)
                {
                    notes.Add(note);
                }
            }
        }

        public void SortNotesByDate()
        {
            var sortedList = Notes.OrderByDescending(note => note.Date).ToList();
            Notes.Clear();
            foreach (var note in sortedList)
            {
                Notes.Add(note);
            }
        }
    }
}
