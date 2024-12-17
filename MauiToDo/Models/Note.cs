using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.Models
{
    public partial class Note : ObservableObject
    {
        [ObservableProperty]
        public Guid id = new Guid();

        [ObservableProperty]
        public string title  = "New note";

        [ObservableProperty]
        public string text;

        [ObservableProperty]
        public DateTime date = DateTime.Now;
    }
}
