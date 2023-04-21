using CinemasApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemasApp
{
    public partial class MovieForm : Form
    {
        public MovieForm(long id)
        {
            InitializeComponent();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(
                @"SELECT * FROM 'Movie' WHERE Id = " + id);
            string[] propertyNames = typeof(Movie).GetProperties().Select(prop => prop.Name).ToArray();
            Movie movie = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Movie>(r, propertyNames)).FirstOrDefault();
            reader.Close();

            labelName.Text = movie.Name;
            textBoxDuration.Text = movie.Duration.ToString();
            richTextBoxActors.Text = movie.Actors.ToString();
            textBoxDirector.Text = movie.Director.ToString();
            textBoxOperator.Text = movie.Operator.ToString();
            textBoxAwards.Text = movie.Awards.ToString();
            string destPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(movie.Poster));
            pictureBoxPoster.ImageLocation = destPath;

            reader = SQLiteReaderHelper.Request(
                @"SELECT * FROM 'Genre' WHERE Id = " + movie.GenreId);
            propertyNames = typeof(Genre).GetProperties().Select(prop => prop.Name).ToArray();
            Genre genre = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Genre>(r, propertyNames)).FirstOrDefault();
            textBoxGenre.Text = genre.Name;
            reader.Close();
        }
    }
}
