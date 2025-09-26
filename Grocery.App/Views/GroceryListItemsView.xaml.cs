using Grocery.App.ViewModels;
using Grocery.Core.Interfaces.Services;

namespace Grocery.App.Views;

public partial class GroceryListItemsView : ContentPage
{
    private readonly IProductService _productService;
    public GroceryListItemsView(GroceryListItemsViewModel viewModel, IProductService productService)
	{
		InitializeComponent();
        BindingContext = viewModel;
        _productService = productService;

    }

    void OnTextChanged(object sender, EventArgs e)
    {
        SearchBar searchBar = (SearchBar)sender;
        searchResults.ItemsSource = _productService.Search(searchBar.Text); //parameter
    }
}