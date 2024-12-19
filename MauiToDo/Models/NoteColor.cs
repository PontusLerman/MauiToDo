using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiToDo.Models
{
    public partial class NoteColor : ObservableObject
    {
        [ObservableProperty]
        private string colorName;
        [ObservableProperty]
        private string colorHex;
    }
}
