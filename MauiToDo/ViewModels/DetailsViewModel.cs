using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiToDo.Models;

namespace MauiToDo.ViewModels
{
    [QueryProperty("Note","Note")]
    public partial class DetailsViewModel : BaseViewModel
    {
        [ObservableProperty]
        Note note;

        [RelayCommand]
        async Task SaveAsync()
        {
            await Shell.Current.GoToAsync("..",
                true); 
        }
    }
}
