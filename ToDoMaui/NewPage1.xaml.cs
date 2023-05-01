using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ToDoMaui;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    public string Name { get; set; } = "sdfdfsfsdf";
    int count = 0;
    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        count++;
        Name = count.ToString();
    }
}