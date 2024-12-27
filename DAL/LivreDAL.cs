using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LivreDAL
    {
        #region Ajouter Livres
        public void AddLivres(LivreBLL livre)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "INSERT INTO Livres (code, nom, auteur, IsAvailable, NPages, APublic) VALUES (@code, @nom, @auteur, @IsAvailable, @NPages, @APublic)";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@code", livre.codeLiv);
                command.Parameters.AddWithValue("@nom", livre.nomLiv);
                command.Parameters.AddWithValue("@auteur", livre.auteurLiv);
                command.Parameters.AddWithValue("@IsAvailable", livre.Available);
                command.Parameters.AddWithValue("@NPages", livre.NPages);
                command.Parameters.AddWithValue("@APublic", livre.APublic);

                command.ExecuteNonQuery();
            }
        }
        #endregion
        #region GetLivresByID
        public LivreBLL GetBookById(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT * FROM Livres WHERE LivreId = @LivreId";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@BookId", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return new LivreBLL
                    {
                        id = reader.GetInt32(0),
                        nomLiv = reader.GetString(1),
                        auteurLiv = reader.GetString(2),
                        Available = reader.GetString(3),
                        NPages = reader.GetString(4),
                        APublic = reader.GetString(5)
                    };
                }
            }
            return null;
        }
        #endregion
        #region GetAllLivres
        public List<LivreBLL> GetAllBooks()
        {
            List<LivreBLL> books = new List<LivreBLL>();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT * FROM Livres";
                SqlCommand command = new SqlCommand(query, cnx);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new LivreBLL
                    {
                        id = reader.GetInt32(0),
                        nomLiv = reader.GetString(1),
                        auteurLiv = reader.GetString(2),
                        Available = reader.GetString(3),
                        NPages = reader.GetString(4),
                        APublic = reader.GetString(5)
                    });
                }
            }
            return books;
        }
        #endregion
        #region UpdateLivres
        public void UpdateBook(LivreBLL livre)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "UPDATE Livres SET code = @Code, nom = @Nom, auteur = @Auteur, IsAvailable = @IsAvailable, NPages = @Npages, APublic = @Apublic WHERE code = @code_where";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Code", livre.codeLiv);
                command.Parameters.AddWithValue("@Nom", livre.nomLiv);
                command.Parameters.AddWithValue("@Auteur", livre.auteurLiv);
                command.Parameters.AddWithValue("@IsAvailable", livre.Available);
                command.Parameters.AddWithValue("@Npages", livre.NPages);
                command.Parameters.AddWithValue("@Apublic", livre.APublic);
                command.Parameters.AddWithValue("@code_where", livre.codeLiv);
                command.ExecuteNonQuery();
            }
        }
        #endregion
        #region Méthode de Selection des livres
        public DataTable selectLivres(LivreBLL Lbll)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                //La requête SQL ci-dessous permet de sélectionner tous les produits 
                //de la base de données et de les trier par ordre alphabétique croissant en fonction de leur nom grâce à la clauseORDER BY Name ASC
                //ASC est utilisé pour indiquer que les résultats d'une requête doivent être triés dans l'ordre croissant et DESC dans le cas contraire.
                string query = "SELECT * FROM Livres ORDER BY LivreID ASC";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter sdap = new SqlDataAdapter(cmd);
                sdap.Fill(dt);
            }
            return dt;
        }
        #endregion
        #region Méthode de vérification d'existence d'un produit
        public bool Livresexist(LivreBLL prdt)
        {
            if (prdt == null || string.IsNullOrEmpty(prdt.codeLiv))
            {
                return false;
            }
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT COUNT(*) FROM Livres WHERE code = @code";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@code", prdt.codeLiv);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        #endregion
        #region Méthode de Suppression des livres

        public void livredelete(LivreBLL prdt)
        {
            using (SqlConnection cnx = new
            SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "DELETE FROM Livres WHERE code = @code";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@code", prdt.codeLiv);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region GetLivresIDbyCodes
        public int GetLivresIDbyCodes(string code)
        {
            using(SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT LivreID from Livres where code=@code";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@code", code);
                object result = cmd.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                return 0;
            }
        }
        #endregion
        #region SetStatus
        public void SetStatus(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "UPDATE Livres SET IsAvailable = 'Indisponible' WHERE LivreID =@id ";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
        #endregion
        #region Contrôle
        public string Contrôle(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT IsAvailable FROM Livres WHERE IsAvailable='Indisponible'";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                object result = cmd.ExecuteScalar();
                if(result != null && result != DBNull.Value)
                {
                    return result.ToString();
                }
                return string.Empty;
            }
        }
        #endregion
        #region GetAvailableBooksCount
        public int GetAvailableBooksCount()
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                    cnx.Open();
                    string selectData = "SELECT COUNT(LivreID) FROM Livres WHERE IsAvailable = 'Disponible'";

                    using (SqlCommand cmd = new SqlCommand(selectData, cnx))
                    {
                        int tempAB = 0;
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            tempAB = Convert.ToInt32(reader[0]);
                        }
                        return tempAB;
                    }               
            }
        }
        #endregion
        #region GetUnavailableBooksCount
        public int GetUnavailableBooksCount()
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string selectData = "SELECT COUNT(LivreID) FROM Livres WHERE IsAvailable = 'Indisponible'";

                using (SqlCommand cmd = new SqlCommand(selectData, cnx))
                {
                    int tempAB = 0;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        tempAB = Convert.ToInt32(reader[0]);
                    }
                    return tempAB;
                }
            }
        }
        #endregion
        #region Méthode de selection pour stock
        public DataTable livrestock(LivreBLL lbll)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                //La requête SQL ci-dessous permet de sélectionner tous les produits 
                //de la base de données et de les trier par ordre alphabétique croissant en fonction de leur nom grâce à la clauseORDER BY Name ASC
                //ASC est utilisé pour indiquer que les résultats d'une requête doivent être triés dans l'ordre croissant et DESC dans le cas contraire.
                string query = "SELECT * FROM Livres WHERE IsAvailable='Disponible' ORDER BY LivreID ASC";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter sdap = new SqlDataAdapter(cmd);
                sdap.Fill(dt);
            }
            return dt;
        }
        #endregion
    }
}
