using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDo.Models;
using System.Collections.ObjectModel;

namespace MauiToDo.ViewModels
{
    [QueryProperty("Note","Note")]
    public partial class DetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Note note;

        [ObservableProperty]
        ObservableCollection<NoteColor> noteColors = new ObservableCollection<NoteColor>() 
        {
            new NoteColor(){ColorName = "Light yellow", ColorHex = "#FDCB36"},
            new NoteColor(){ColorName = "Light blue", ColorHex = "#3EBFDE"},
            new NoteColor(){ColorName = "Light green", ColorHex = "#99C75A"},
            new NoteColor(){ColorName = "Light pink", ColorHex = "#EE6B9D"},
            new NoteColor(){ColorName = "Light orange", ColorHex = "#F1905B"},
        };

        [RelayCommand]
        async Task SaveAsync()
        {
            await Shell.Current.GoToAsync("..",
                true); 
        }
    }
}
