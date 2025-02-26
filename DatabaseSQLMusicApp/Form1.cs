using System.Net;

namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        //Instance of BindingSource to bind the data
        BindingSource albumbBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // data in 'getAllAlbums' list is binded to albumbBindingSource
            albumbBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumbBindingSource;

            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // data in 'getAllAlbums' list is binded to albumbBindingSource
            albumbBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumbBindingSource;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int rowClicked = dataGridView.CurrentRow.Index;
            string imageURL = dataGridView.Rows[rowClicked].Cells[4].Value.ToString();

            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");

                    byte[] imageBytes = client.DownloadData(imageURL);
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
    }
}
