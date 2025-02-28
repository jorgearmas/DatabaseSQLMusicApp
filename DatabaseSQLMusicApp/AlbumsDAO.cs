using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DatabaseSQLMusicApp
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";
        
        /* --- GET DATA --- */
        public List<Album> getAllAlbums()
        {
            List<Album> returnThese = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            MySqlCommand command = new MySqlCommand("SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION FROM ALBUMS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };
                    returnThese.Add(a);
                }
            }

            connection.Close();

            return returnThese;
        }

        public List<Album> searchTitles(String searchTerm)
        {
            List<Album> returnThese = new List<Album>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String searchWildPhrase = "%"+searchTerm+"%";
            String query = "SELECT ID, ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION " +
                "FROM ALBUMS WHERE ALBUM_TITLE LIKE @search";

            MySqlCommand command = new MySqlCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Album a = new Album()
                    {
                        ID = reader.GetInt32(0),
                        AlbumName = reader.GetString(1),
                        ArtistName = reader.GetString(2),
                        Year = reader.GetInt32(3),
                        ImageURL = reader.GetString(4),
                        Description = reader.GetString(5)
                    };

                    returnThese.Add(a);
                }
            }
            connection.Close();

            return returnThese;
        }
        
        /* --- INSERT DATA --- */
        public int addOneAlbum(Album album)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String query = "INSERT INTO albums (ALBUM_TITLE, ARTIST, YEAR, IMAGE_NAME, DESCRIPTION) " +
                "VALUES (@album_title, @artist, @year, @image_name, @description)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@album_title", album.AlbumName);
            command.Parameters.AddWithValue("@artist", album.ArtistName);
            command.Parameters.AddWithValue("@year", album.Year);
            command.Parameters.AddWithValue("@image_name", album.ImageURL);
            command.Parameters.AddWithValue("@description", album.Description);
            int new_rows = command.ExecuteNonQuery();

            connection.Close();

            return new_rows;
        }
        
        /* --- GET DATA / Track --- */
        public List<Track> getTracksForAlbums(int albumID)
        {
            List<Track> returnThese = new List<Track>();
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string query = "SELECT * FROM TRACKS WHERE albums_ID = @albumid";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@albumid", albumID);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Track t = new Track()
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Number = reader.GetInt32(2),
                        VideoURL = reader.GetString(3),
                        Lyrics = reader.GetString(4),
                    };
                    returnThese.Add(t);
                }
            }

            connection.Close();

            return returnThese;
        }
    }
}
