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
using CinemasApp.Data;
using Microsoft.VisualBasic.Devices;
using static System.Collections.Specialized.BitVector32;

namespace CinemasApp
{
    public partial class CinemaInfoForm : Form
    {
        List<Session> _sessions;
        List<Movie> _movies;
        public CinemaInfoForm(Cinema cinema)
        {
            InitializeComponent();
            _sessions = new List<Session>();
            textBoxName.Text = cinema.Name;
            textBoxArea.Text = cinema.Area;
            textBoxStreet.Text = cinema.Street;
            textBoxCount.Text = cinema.Capacity.ToString();
            textBoxHalls.Text = cinema.NumberHalls.ToString();

            SQLiteDataReader reader = SQLiteReaderHelper.Request(
                @"SELECT * FROM 'Categories' WHERE Id = " + cinema.CategoryId);
            string[] propertyNames = typeof(Category).GetProperties().Select(prop => prop.Name).ToArray();
            Category category = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                .CreateObject<Category>(r, propertyNames)).FirstOrDefault();
            textBoxCategory.Text = category.Name;
            reader.Close();

            reader = SQLiteReaderHelper.Request(
                @"SELECT * FROM 'Session' WHERE CinemaId = " + cinema.Id);
            if(reader != null )
            {
                propertyNames = typeof(Session).GetProperties()
                .Where(prop => prop.Name != "Info")
                .Select(prop => prop.Name).ToArray();
                _sessions = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                    .CreateObject<Session>(r, propertyNames));
                reader.Close();


                reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Movie'");
                propertyNames = typeof(Movie).GetProperties()
                    .Select(prop => prop.Name).ToArray();
                _movies = SQLiteReaderHelper.ReadObjects(reader, r => SQLiteReaderHelper
                    .CreateObject<Movie>(r, propertyNames));
                reader.Close();

                foreach (Session session in _sessions)
                {
                    foreach (Movie movie in _movies)
                    {
                        if (session.MovieId == movie.Id)
                        {
                            session.Info = movie.Name.ToString() + " Дата: " + session.DataTime.ToString()
                                    + " Ціна: " + session.Price.ToString();
                        }
                    }
                }

                listBoxRepertuar.DataSource = _sessions;
                listBoxRepertuar.DisplayMember = "Info";
            }
        }

        private void listBoxRepertuar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Session session = listBoxRepertuar.SelectedItem as Session;
            if (session != null)
            {
                MovieForm movieForm = new MovieForm(session.MovieId);
                movieForm.Show();
            }

        }
    }
}
