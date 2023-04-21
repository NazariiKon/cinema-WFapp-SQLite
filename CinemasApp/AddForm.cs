using CinemasApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CinemasApp
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Categories'");
            string[] propertyNames = typeof(Category).GetProperties()
                .Select(prop => prop.Name).ToArray();
            List<Category> categories = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Category>(r, propertyNames));
            reader.Close();

            reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Genre'");
            propertyNames = typeof(Genre).GetProperties()
                .Select(prop => prop.Name).ToArray();
            List<Genre> genres = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Genre>(r, propertyNames));
            reader.Close();

            reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Movie'");
            propertyNames = typeof(Movie).GetProperties()
                .Select(prop => prop.Name).ToArray();
            List<Movie> movies = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Movie>(r, propertyNames));
            reader.Close();

            reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Cinema'");
            propertyNames = typeof(Cinema).GetProperties()
                .Select(prop => prop.Name).ToArray();
            List<Cinema> cinemas = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Cinema>(r, propertyNames));
            reader.Close();

            comboBoxCategory.DataSource = categories;
            comboBoxCategory.ValueMember = "Name";
            comboBoxCategory.SelectedIndex = 0;

            comboBoxGenre.DataSource = genres;
            comboBoxGenre.ValueMember = "Name";
            comboBoxGenre.SelectedIndex = 0;

            comboBoxCinema.DataSource = cinemas;
            comboBoxCinema.ValueMember = "Name";
            comboBoxCinema.SelectedIndex = 0;

            comboBoxFilm.DataSource = movies;
            comboBoxFilm.ValueMember = "Name";
            comboBoxFilm.SelectedIndex = 0;
        }

        public string UploadImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Images (*.jpg)|*.jpg|PNG Images (*.png)|*.png|All Files (*.*)|*.*";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fileName = openFileDialog.FileName;
                    string destPath = Path.Combine(Application.StartupPath, "Images", Path.GetFileName(fileName));
                    File.Copy(fileName, destPath, true);
                    return fileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return null;
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string name = textBoxFilm.Text;
            Genre genre = comboBoxGenre.SelectedItem as Genre;
            string duration = textBoxDuration.Text;
            string actors = richTextBoxActors.Text;
            string director = textBoxDirector.Text;
            string operatorName = textBoxOperator.Text;
            string awards = textBoxAwards.Text;
            string img = UploadImage();
            if (img == null) img = "noimage.jpg";

            string query = "INSERT INTO Movie " +
                "(Director, Operator, Actors, GenreId, Poster, Awards, Duration, Name) " +
                "VALUES(@Director, @Operator, @Actors, @GenreId, @Poster, @Awards, @Duration, @Name);";
            SQLiteReaderHelper.Request(query, director, operatorName, actors, 
                genre.Id, img, awards, duration, name);
            MessageBox.Show("Фільм доданий!");
        }

        private void buttonAddCinema_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string area = textBoxArea.Text;
            string street = textBoxStreet.Text;
            long count = decimal.ToInt64(numericUpDownHalls.Value);
            long halls = decimal.ToInt64(numericUpDownCount.Value);

            string query = "INSERT INTO Cinema " +
                "(Name, Area, Street, CategoryId, Capacity, NumberHalls) " +
                "VALUES (@Name, @Area, @Street, @CategoryId, @Capacity, @NumberHalls);";
            Category category = comboBoxCategory.SelectedItem as Category;
            SQLiteReaderHelper.Request(query, name, area, street, category.Id, count, halls);
            MessageBox.Show("Кінотеатр доданий!");
        }

        private void buttonAddSession_Click(object sender, EventArgs e)
        {
            Cinema cinema = comboBoxCinema.SelectedItem as Cinema;
            Movie movie = comboBoxFilm.SelectedItem as Movie;
            string dateTime = dateTimePicker.Value.ToShortDateString();
            decimal price = numericUpDownPrice.Value;
            long hall = (long)numericUpDownHall.Value;
            string query = "INSERT INTO Session " +
                "(CinemaId, MovieId, Hall, DataTime, Price) " +
                "VALUES (@CinemaId, @MovieId, @Hall, @DataTime, @Price);";
            SQLiteReaderHelper.Request(query, cinema.Id, movie.Id, hall, dateTime, price);
            MessageBox.Show("Сеанс доданий!");
        }
    }
}
