using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MovieScreening
{
    class MovieScreening
    {
        
        public MovieScreening()
        {
           
        }
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["FirstConn"].ConnectionString;
            }
            
        }
        public SqlConnection _sqlConn
        {
            set;get;
        }
        public bool AddMovie(Movie movie)
        {
            try
            {
                _sqlConn = new SqlConnection(ConnectionString);
            _sqlConn.Open();
           SqlCommand cmd = new SqlCommand("insert into tblMovie values(@name,@duration,@rating)", _sqlConn);
       
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = movie.Id;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = movie.Title;
            cmd.Parameters.Add("@duration", SqlDbType.Float).Value = movie.Duration;
            cmd.Parameters.Add("@rating", SqlDbType.Int).Value = movie.Rating;
            
               int i=  cmd.ExecuteNonQuery();
                if(i>0)
                {
                    _sqlConn.Close();
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            catch (Exception e)
            {
                _sqlConn.Close();
                return false;
            }
        }

        // public bool IList<Movie> 	

        public IList<Movie> DisplayMoviesByHighestRating()
        {
            try
            {
                _sqlConn = new SqlConnection(ConnectionString);

                IList<Movie> ilist = new List<Movie>();
                _sqlConn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblMovie where rating = (select max(rating) from tblMovie )", _sqlConn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Movie m = new Movie();
                    m.Id = Convert.ToInt32(reader["Id"]);
                    m.Title = reader["Name"].ToString();
                    m.Duration = float.Parse(reader["Duration"].ToString());
                    m.Rating = Convert.ToInt32(reader["Rating"]);
                    ilist.Add(m);
                }
                reader.Close();
                _sqlConn.Close();


                return ilist;
            }
            catch(Exception e)
            {
                return new List<Movie>();
            }
            

        }

        public IList<Movie> SearchMoviesByStartLetter(string searchedFirstLetter)
        {
            try
            {
                _sqlConn = new SqlConnection(ConnectionString);
                IList<Movie> ilist = new List<Movie>();
                _sqlConn.Open();
                SqlCommand cmd = new SqlCommand("select * from tblMovie where substring(lower(Name),1,1)=LOWER(@sfl) ", _sqlConn);
                cmd.Parameters.Add("@sfl", SqlDbType.VarChar).Value = searchedFirstLetter.ToLower();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Movie m = new Movie();
                    m.Id = Convert.ToInt32(reader["Id"]);
                    m.Title = reader["Name"].ToString();
                    m.Duration = float.Parse(reader["Duration"].ToString());
                    m.Rating = Convert.ToInt32(reader["Rating"]);
                    ilist.Add(m);
                }
                reader.Close();
                _sqlConn.Close();
                return ilist;
            }
            catch(Exception e)
            {
                return new List<Movie>();
            }
           

        }
    }
}
