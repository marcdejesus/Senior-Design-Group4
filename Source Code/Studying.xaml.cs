using WellnessApp.Repositories;
using WellnessApp.Services;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WellnessApp;

public partial class Studying : ContentPage
{
    private Theme _currentTheme;
    private List<Item> _items;

    public Studying()
    {
        InitializeComponent();

    }

    public async void OnHomeButtonClicked(object sender, EventArgs e)
    {
        // Navigate back to the home page
        await Shell.Current.GoToAsync("//MainPage"); // Also resets the Main page when returning
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

       
                    // Load items for the specified theme
                    var items = await App.ItemRepository.GetItemsForThemeAsync(1);

                    // Check if items is not null and has elements
                    if (items != null && items.Count > 0)
                    {
                        ItemsListView.ItemsSource = items; // Bind items to ListView
                    }
                    else
                    {
                        ItemsListView.ItemsSource = new List<Item>(); // Set to an empty list if no items
                    }
                }
            }
        

    
