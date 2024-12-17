using MauiToDo.ViewModels;

namespace MauiToDo;

public partial class DetailsPage : ContentPage
{
    public DetailsPage(DetailsViewModel detailsViewModel)
    {
        InitializeComponent();
        BindingContext = detailsViewModel;
    }
}
