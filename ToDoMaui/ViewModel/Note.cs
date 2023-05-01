using System.ComponentModel;

namespace ToDoMaui.ViewModel
{
    public class Note 
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

        public Note(string title, string text, DateTime date)
        {
            Title = title;
            Text = text;
            Date = date;
        }
    }
}
