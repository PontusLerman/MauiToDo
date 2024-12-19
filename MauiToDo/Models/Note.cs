using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.Models
{
    public partial class Note : ObservableObject
    {
        [ObservableProperty]
        private string title  = "New note";

        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private DateTime date = DateTime.Now;

        [ObservableProperty]
        private NoteColor hexColor;
    }
}
