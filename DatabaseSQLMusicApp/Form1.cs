using System;
using System.Net;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;

namespace DatabaseSQLMusicApp
{
    public partial class Form1 : Form
    {
        //Instance of BindingSource to bind the data
        BindingSource albumbBindingSource = new BindingSource();
        BindingSource trackBindingSource = new BindingSource();
        List<Album> albums = new List<Album>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            // data in 'getAllAlbums' list is binded to albumbBindingSource
            albums = albumsDAO.getAllAlbums();
            albumbBindingSource.DataSource = albumsDAO.getAllAlbums();
            dataGridView1.DataSource = albumbBindingSource;

            //pictureBox1.Load("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/114.0.0.0 Safari/537.36");

                    byte[] imageBytes = client.DownloadData("https://upload.wikimedia.org/wikipedia/en/4/42/Beatles_-_Abbey_Road.jpg");
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
        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albumbBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);
            dataGridView1.DataSource = albumbBindingSource;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkBox2.Checked = false;
            txt_albumName.Text = "";
            txt_artist.Text = "";
            txt_year.Text = "";
            txt_imageURL.Text = "";
            txt_description.Text = "";

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
                        trackBindingSource.DataSource = albums[rowClicked].Tracks;
                        dataGridView2.DataSource = trackBindingSource;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading image: " + ex.Message);
            }
        }
        // depreciate below
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // depreciate above
        private void button3_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int albumID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;

            if (checkBox2.Checked == true)
            {
                Album albumUpdate = new Album()
                {
                    ID = albumID,
                    AlbumName = txt_albumName.Text,
                    ArtistName = txt_artist.Text,
                    Year = Int32.Parse(txt_year.Text),
                    ImageURL = txt_imageURL.Text,
                    Description = txt_description.Text,
                };

                AlbumsDAO albumsDAOUpdate = new AlbumsDAO();
                int resultUpdate = albumsDAOUpdate.modifyAlbum(albumUpdate);
                txt_albumName.Text = "";
                txt_artist.Text = "";
                txt_year.Text = "";
                txt_imageURL.Text = "";
                txt_description.Text = "";
                MessageBox.Show($"{resultUpdate} row(s) updated");
            }
            else
            {
                Album album = new Album()
                {
                    AlbumName = txt_albumName.Text,
                    ArtistName = txt_artist.Text,
                    Year = Int32.Parse(txt_year.Text),
                    ImageURL = txt_imageURL.Text,
                    Description = txt_description.Text,
                };

                AlbumsDAO albumsDAO = new AlbumsDAO();
                int result = albumsDAO.addOneAlbum(album);
                txt_albumName.Text = "";
                txt_artist.Text = "";
                txt_year.Text = "";
                txt_imageURL.Text = "";
                txt_description.Text = "";
                MessageBox.Show($"{result} new row(s) inserted");
            }
        }
        // depreciate below
        private void label6_Click(object sender, EventArgs e)
        {

        }
        // depreciate above
        private void button4_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView2.CurrentRow.Index;
            int trackID = (int)dataGridView2.Rows[rowClicked].Cells[0].Value;

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.deleteTrack(trackID);
            MessageBox.Show("Result " + result);
            dataGridView2.DataSource = "";
            albums = albumsDAO.getAllAlbums();
        }
        // depreciate below
        private void label7_Click(object sender, EventArgs e)
        {

        }
        // depreciate above
        private void button5_Click(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            int rowClickedDataGrid2 = dataGridView2.CurrentRow.Index;
            int albumID = (int)dataGridView1.Rows[rowClicked].Cells[0].Value;
            int trackID = (int)dataGridView2.Rows[rowClickedDataGrid2].Cells[0].Value;

            if (checkBox1.Checked == true)
            {
                Track trackUpdate = new Track()
                {
                    ID = trackID,
                    Name = txt_trackTitle.Text,
                    Number = Int32.Parse(txt_trackNumber.Text),
                    VideoURL = txt_trackVideoURL.Text,
                    Lyrics = txt_trackLyrics.Text,
                    album_ID = albumID
                };

                TracksDAO tracksDAO_update = new TracksDAO();
                int resultUpdate = tracksDAO_update.modifyTrack(trackUpdate);
                txt_trackTitle.Text = "";
                txt_trackNumber.Text = "";
                txt_trackVideoURL.Text = "";
                txt_trackLyrics.Text = "";
                MessageBox.Show($"{resultUpdate} rows updated in tracks");
            }
            else
            {

                Track track = new Track()
                {
                    Name = txt_trackTitle.Text,
                    Number = Int32.Parse(txt_trackNumber.Text),
                    VideoURL = txt_trackVideoURL.Text,
                    Lyrics = txt_trackLyrics.Text,
                    album_ID = albumID
                };

                TracksDAO tracksDAO = new TracksDAO();
                int result = tracksDAO.addOneTrack(track);
                txt_trackTitle.Text = "";
                txt_trackNumber.Text = "";
                txt_trackVideoURL.Text = "";
                txt_trackLyrics.Text = "";
                MessageBox.Show($"{result} rows inserted in tracks");
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //int rowClickedAlbums = dataGridView1.CurrentRow.Index;

            int rowClicked = dataGridView2.CurrentRow.Index;
            string track_title = dataGridView2.Rows[rowClicked].Cells[1].Value.ToString();
            string track_number = dataGridView2.Rows[rowClicked].Cells[2].Value.ToString();
            string track_videoURL = dataGridView2.Rows[rowClicked].Cells[3].Value.ToString();
            string track_lyrics = dataGridView2.Rows[rowClicked].Cells[4].Value.ToString();

            txt_trackTitle.Text = track_title;
            txt_trackNumber.Text = track_number;
            txt_trackVideoURL.Text = track_videoURL;
            txt_trackLyrics.Text = track_lyrics;

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkBox1.Checked = false;
            txt_trackTitle.Text = "";
            txt_trackNumber.Text = "";
            txt_trackVideoURL.Text = "";
            txt_trackLyrics.Text = "";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int rowClicked = dataGridView1.CurrentRow.Index;
            string album_title = dataGridView1.Rows[rowClicked].Cells[1].Value.ToString();
            string artist_name = dataGridView1.Rows[rowClicked].Cells[2].Value.ToString();
            string year = dataGridView1.Rows[rowClicked].Cells[3].Value.ToString();
            string image_url = dataGridView1.Rows[rowClicked].Cells[4].Value.ToString();
            string description = dataGridView1.Rows[rowClicked].Cells[5].Value.ToString();

            txt_albumName.Text = album_title;
            txt_artist.Text = artist_name;
            txt_year.Text = year;
            txt_imageURL.Text = image_url;
            txt_description.Text = description;
        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}
