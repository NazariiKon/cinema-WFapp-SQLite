using System.Data.SQLite;
using CinemasApp.Data;

namespace CinemasApp
{
    public partial class CinemasForm : Form
    {
        private List<Cinema> _cinemas;
        public CinemasForm()
        {
            InitializeComponent();
            _cinemas = new List<Cinema>();
            SQLiteDataReader reader = SQLiteReaderHelper.Request(@"SELECT * FROM 'Cinema'");
            string[] propertyNames = typeof(Cinema).GetProperties().Select(prop => prop.Name).ToArray();
            _cinemas = SQLiteReaderHelper.ReadObjects(reader,
                r => SQLiteReaderHelper.CreateObject<Cinema>(r, propertyNames));

            cinemasList.DataSource = _cinemas;
            cinemasList.ValueMember = "Name";
        }

        private void cinemasList_DoubleClick(object sender, EventArgs e)
        {
            if (cinemasList.SelectedItem != null)
            {
                CinemaInfoForm cinemaInfo = new CinemaInfoForm(cinemasList.SelectedItem as Cinema);
                cinemaInfo.Show();
            }
        }
    }
}