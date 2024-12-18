using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.Models
{
    public partial class Note : ObservableObject
    {
        [ObservableProperty]
        public string title  = "New note";

        [ObservableProperty]
        public string text;

        [ObservableProperty]
        public DateTime date = DateTime.Now;

        [ObservableProperty]
        public NoteColor hexColor = new NoteColor() { ColorName = "Light yellow", ColorHex = "#FDCB36" };
    }
}
