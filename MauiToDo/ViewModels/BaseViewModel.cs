using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        public string? title;
    }
}
