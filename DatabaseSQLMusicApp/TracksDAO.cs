using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseSQLMusicApp
{
    internal class TracksDAO
    {
        string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=music";

        /* --- INSERT DATA --- */
        public int addOneTrack(Track track)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            String query = "INSERT INTO tracks (TRACK_TITLE, NUMBER, VIDEO_URL, LYRICS, albums_ID) " +
                "VALUES (@track_title, @number, @video_url, @lyrics, @albums_ID)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@track_title", track.Name);
            command.Parameters.AddWithValue("@number", track.Number);
            command.Parameters.AddWithValue("@video_url", track.VideoURL);
            command.Parameters.AddWithValue("@lyrics", track.Lyrics);
            command.Parameters.AddWithValue("@albums_ID", track.album_ID);
            int new_rows = command.ExecuteNonQuery();

            connection.Close();

            return new_rows;
        }

        public int modifyTrack(Track track)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String query = "UPDATE tracks " +
                "SET " +
                "TRACK_TITLE = @track_title," +
                "NUMBER = @number," +
                "VIDEO_URL = @video_url," +
                "LYRICS = @lyrics " +
                "WHERE ID=@id";

            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", track.ID);
            command.Parameters.AddWithValue("@track_title", track.Name);
            command.Parameters.AddWithValue("@number", track.Number);
            command.Parameters.AddWithValue("@video_url", track.VideoURL);
            command.Parameters.AddWithValue("@lyrics", track.Lyrics);
            int new_rows = command.ExecuteNonQuery();

            connection.Close();
            return new_rows;
        }
    }
}
