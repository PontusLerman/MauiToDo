using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.Models
{
    public partial class NoteColor : ObservableObject
    {
        [ObservableProperty]
        public string colorName;
        [ObservableProperty]
        public string colorHex;
    }
}
