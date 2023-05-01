using System.Collections.Generic;
using ToDoMaui.ViewModel;
using static System.Net.Mime.MediaTypeNames;

namespace ToDoMaui;

public partial class MainPage : ContentPage
{
    List<Note> notes = new List<Note>();
    int i = 3;
    public MainPage()
	{
		InitializeComponent();
	}

    private void OnAddingNote(object sender, EventArgs e)
    {
        if(entry.Text!= string.Empty)
            AddCollectionItem();



    }

    void AddCollectionItem()
    {
        Note note = new Note(entry.Text, entry.Text, DateTime.Now);
        notes.Add(note);
        entry.Text = string.Empty;

        var sorted = from noteEl in notes
                     orderby noteEl.Date descending
                     select noteEl;

        Coll.ItemsSource = sorted;
        Coll.ItemTemplate = new DataTemplate(() =>
        {
            var title = new Label() { FontSize = 20, TextColor = Color.FromArgb("#2B0B98") };
            title.SetBinding(Label.TextProperty, "Title");

            var date = new Label() { FontSize = 10, TextColor = Color.FromArgb("#212121") };
            date.SetBinding(Label.TextProperty, "Date");


            VerticalStackLayout vLayout = new VerticalStackLayout()
            {
                Children = {title, date},
                
            };



            return new StackLayout()
            {
                Children = {
                    new Frame()
                    {
                        CornerRadius = 10,
                        Padding=10,
                        BorderColor= Color.FromArgb("#212121"),
                        Content = vLayout,
                        
                    }
                    
                },
                Padding = new Thickness(0, 1, 0, 1)
            };
        });

        entry.Unfocus();
    }
}

