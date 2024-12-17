using MauiToDo.ViewModels;

namespace MauiToDo
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
            viewModel.Title = "Notes";
            viewModel.GetNotesAsync();
        }
    }
}
