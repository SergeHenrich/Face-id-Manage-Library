using BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class EmpruntDAL
    {
        LivreDAL ldal = new LivreDAL();
        #region Emprunt de livres
        public void BorrowBookByCode(int userId, string bookCode, EmpruntBLL ebll)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                try
                {
                    
                    cnx.Open();                                       
                    // Vérifiez que l'utilisateur existe dans la table Users
                    string queryCheckUser = "SELECT COUNT(*) FROM Users WHERE ID = @userId";
                    using (SqlCommand cmdCheckUser = new SqlCommand(queryCheckUser, cnx))
                    {
                        cmdCheckUser.Parameters.AddWithValue("@userId", userId);
                        int userExists = (int)cmdCheckUser.ExecuteScalar();

                        if (userExists == 0)
                        {
                            // Fin de la méthode si l'utilisateur n'existe pas
                            return;
                        }
                    }

                    // Récupérer l'ID du livre à partir du code
                    int bookId = ldal.GetLivresIDbyCodes(bookCode);
                    if (bookId == 0)
                    {
                        // Fin de la méthode si le livre n'existe pas ou une erreur s'est produite
                        return;
                    }
                       
                        // Vérifiez que le livre est disponible dans la table Livres
                        string queryCheckBook = "SELECT COUNT(*) FROM Livres WHERE LivreId = @bookId AND IsAvailable = 'Disponible'";
                    using (SqlCommand cmdCheckBook = new SqlCommand(queryCheckBook, cnx))
                    {
                        cmdCheckBook.Parameters.AddWithValue("@bookId", bookId);
                        int bookExists = (int)cmdCheckBook.ExecuteScalar();

                        if (bookExists == 0)
                        {
                            // Fin de la méthode si le livre n'est pas disponible
                            Console.WriteLine("Ce livre est indisponible");
                            return;
                        }
                    }       
                    // Insérer l'emprunt dans la table Emprunt
                    string queryInsertEmprunt = "INSERT INTO Emprunt (UsersID, BookID, DatePrêt, DateRetour) VALUES (@userId, @bookId, @datePret, @DateRetour)";
                    using (SqlCommand cmdInsertEmprunt = new SqlCommand(queryInsertEmprunt, cnx))
                    {
                        cmdInsertEmprunt.Parameters.AddWithValue("@userId", userId);
                        cmdInsertEmprunt.Parameters.AddWithValue("@bookId", bookId);
                        cmdInsertEmprunt.Parameters.AddWithValue("@datePret", ebll.dateEmprunt);
                        cmdInsertEmprunt.Parameters.AddWithValue("@DateRetour", ebll.dateRetour);
                        cmdInsertEmprunt.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    // Gérer l'exception selon les besoins, par exemple, enregistrer l'erreur dans un log.
                    Console.WriteLine("Erreur lors de l'emprunt du livre : " + ex.Message);
                }
            }
        }
        #endregion
        #region Retour de livres
        public void ReturnBook(int EmpruntId)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "UPDATE Emprunt SET DateRetour = @dateRetour WHERE EId = @EId AND DateRetour IS NULL";
                SqlCommand returnCommand = new SqlCommand(query, cnx);
                returnCommand.Parameters.AddWithValue("@dateRetour", DateTime.Now);
                returnCommand.Parameters.AddWithValue("@EId", EmpruntId);
                int rowsAffected = returnCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    string query1 = "UPDATE Livres SET IsAvailable = 'Disponible' WHERE LivreId = (SELECT LivreId FROM Emprunt WHERE EId = @EId)";
                    SqlCommand bookCommand = new SqlCommand(query1, cnx);
                    bookCommand.Parameters.AddWithValue("@EId", EmpruntId);
                    bookCommand.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region GetPrêtByUsersID
        public List<EmpruntBLL> GetLoansByStudentId(int UsersId)
        {
            List<EmpruntBLL> prêt = new List<EmpruntBLL>();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT * FROM Emprunt WHERE UsersID = @usersID";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@usersID", UsersId);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    prêt.Add(new EmpruntBLL
                    {
                        id = reader.GetInt32(0),
                        UsersID = reader.GetInt32(1),
                        BookID = reader.GetInt32(2),
                        dateEmprunt = reader.GetDateTime(3),
                        dateRetour = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4)
                    });
                }
            }
            return prêt;
        }
        #endregion
        #region Méthode de Selection des livres
        public DataTable selectEmprunt(EmpruntBLL ebll)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                //La requête SQL ci-dessous permet de sélectionner tous les produits 
                //de la base de données et de les trier par ordre alphabétique croissant en fonction de leur nom grâce à la clauseORDER BY Name ASC
                //ASC est utilisé pour indiquer que les résultats d'une requête doivent être triés dans l'ordre croissant et DESC dans le cas contraire.
                string query = "SELECT * FROM Emprunt ORDER BY EId ASC";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter sdap = new SqlDataAdapter(cmd);
                sdap.Fill(dt);
            }
            return dt;
        }
        #endregion

    }
}
