using MoviesApplication.MovieModels;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace MoviesApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string _key = "619df916";

        private void getMovieButton_Click(object sender, EventArgs e)
        {
            if (movieNameTextBox.Text != String.Empty)
            {
                //ThreadPool.QueueUserWorkItem(GetMovie);
                GetMovie(true);
            }
        }

        private void GetMovie(object sender)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = String.Format("https://www.omdbapi.com/?apikey={0}&t={1}", _key, movieNameTextBox.Text); ;

                    var json = client.DownloadString(url);
                    Movie movie = JsonConvert.DeserializeObject<Movie>(json);

                    FillResultTextBox(movie);
                }
            }
            catch (Exception)
            {
                resultTextBox.Text = String.Empty;
                resultTextBox.Text += "Invalid Movie Name";
            }
        }

        private void FillResultTextBox(Movie movie)
        {
            resultTextBox.Text = String.Empty;

            resultTextBox.Text += $"Title: {movie.Title}\r\n";
            resultTextBox.Text += $"Year: {movie.Year}\r\n";
            resultTextBox.Text += $"Runtime: {movie.Runtime}\r\n";
            resultTextBox.Text += $"Genre: {movie.Genre}\r\n";
            resultTextBox.Text += $"Writer: {movie.Writer}\r\n";
            resultTextBox.Text += $"Actors: {movie.Actors}\r\n";
            resultTextBox.Text += $"Language: {movie.Language}\r\n";
            resultTextBox.Text += $"Country: {movie.Country}\r\n";
            resultTextBox.Text += $"Imdb Rating: {movie.ImdbRating}\r\n";

        }

        private void sendMailButton_Click(object sender, EventArgs e)
        {
            if (resultTextBox.Text != String.Empty)
            {
                SendMailForm sendMailForm = new SendMailForm(resultTextBox.Text);
                sendMailForm.ShowDialog();
            }
        }
    }
}
