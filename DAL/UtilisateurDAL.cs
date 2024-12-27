using BLL;
using Emgu.CV;
using System;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace DAL
{
    public class UtilisateurDAL
    {
        #region Ajouter Utilisateur
        public void AddUsers(UtilisateurBLL Ubl)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "INSERT INTO Users (matricule, nom, prenom, telephone, password, sexe, FaceID) VALUES (@Matricule, @Nom, @Prenom, @Telephone, @Password, @Sexe, @FaceID)";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Matricule", Ubl.matriculeUt);
                command.Parameters.AddWithValue("@Nom", Ubl.nomUt);
                command.Parameters.AddWithValue("@Prenom", Ubl.prenomUt);
                command.Parameters.AddWithValue("@Telephone", Ubl.telephoneUt);
                command.Parameters.AddWithValue("@Password", Ubl.password);
                command.Parameters.AddWithValue("@Sexe", Ubl.sexeUt);
                command.Parameters.AddWithValue("@FaceID", Ubl.FaceIDutil);

                command.ExecuteNonQuery();
            }
        }
        #endregion
        #region GetAllUsers
        public List<UtilisateurBLL> GetAllUsers()
        {
            List<UtilisateurBLL> users = new List<UtilisateurBLL>();

            string query = "SELECT * FROM Users";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        UtilisateurBLL user = new UtilisateurBLL
                        {
                            id = rdr.GetInt32(0),
                            matriculeUt = rdr.GetString(1),
                            nomUt = rdr.GetString(2),
                            prenomUt = rdr.GetString(3),
                            telephoneUt = rdr.GetString(4),
                            password = rdr.GetString(5),
                            sexeUt = rdr.GetBoolean(6),
                            FaceIDutil = (byte[])rdr[7]
                        };

                        // Conversion de FaceIDAdmin (bytes) en Image<Gray, byte>
                        using (MemoryStream ms = new MemoryStream(user.FaceIDutil))
                        {
                            ms.Seek(0, SeekOrigin.Begin);
                            Image img = Image.FromStream(ms);
                            Bitmap bmp = new Bitmap(img);
                            user.FaceImageGray = new Image<Gray, byte>(bmp);
                        }

                        users.Add(user);
                    }
                }
            }

            return users;
        }


        #endregion
        #region Seleection des utilisateurs pour Rapport
        public DataTable selectuser(UtilisateurBLL Lbll)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                //La requête SQL ci-dessous permet de sélectionner tous les produits 
                //de la base de données et de les trier par ordre alphabétique croissant en fonction de leur nom grâce à la clauseORDER BY Name ASC
                //ASC est utilisé pour indiquer que les résultats d'une requête doivent être triés dans l'ordre croissant et DESC dans le cas contraire.
                string query = "SELECT matricule, nom, prenom, telephone FROM Users ORDER BY ID ASC";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter sdap = new SqlDataAdapter(cmd);
                sdap.Fill(dt);
            }
            return dt;
        }
        #endregion
        #region GetUsersByID
        public UtilisateurBLL GetUsersByID(int ID)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT * FROM Users WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@ID", ID);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new UtilisateurBLL
                    {
                        id = reader.GetInt32(0),
                        matriculeUt = reader.GetString(1),
                        nomUt = reader.GetString(2),
                        prenomUt = reader.GetString(3),
                        password = reader.GetString(4),
                        telephoneUt = reader.GetString(5),
                        sexeUt = reader.GetBoolean(6),
                        FaceIDutil = (byte[])reader["FaceID"]
                    };
                }
            }
            return null;
        }
        #endregion
        #region Mise à jour Utilisateur
        public void UpdateUtilisateur(UtilisateurBLL Ubl)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "UPDATE Users SET matricule = @Matricule, nom = @Nom, prenom = @Prenom, telephone = @Telephone, password = @Password, sexe = @Sexe, FaceID = @FaceID WHERE ID = @ID ";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Matricule", Ubl.matriculeUt);
                command.Parameters.AddWithValue("@Nom", Ubl.nomUt);
                command.Parameters.AddWithValue("@Prenom", Ubl.prenomUt);
                command.Parameters.AddWithValue("@Telephone", Ubl.telephoneUt);
                command.Parameters.AddWithValue("@Password", Ubl.password);
                command.Parameters.AddWithValue("@Sexe", Ubl.sexeUt);
                command.Parameters.AddWithValue("@FaceID", Ubl.FaceIDutil);
                command.Parameters.AddWithValue("@ID", Ubl.id);

                command.ExecuteNonQuery();
            }
        }
        #endregion
        #region Méthode VerifyUsersInDatabase
        public bool VerifyUsersInDatabase(string nom, string password)
        {
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT password FROM Users WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", nom);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Récupérer le mot de passe stocké dans la base de données
                    string storedPassword = reader.GetString(0);
                    // Déchiffrer le mot de passe stocké
                    string decryptedPassword = Cryptography.Decrypter(storedPassword);
                    // Comparer le mot de passe entré avec le mot de passe stocké
                    if (decryptedPassword == password)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion
        #region Méthode GetPasswordFromDatabase
        public string GetPasswordFromDatabase(string nom)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT password FROM Users WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", nom);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Récupérer le mot de passe stocké dans la base de données
                    return reader.GetString(0);
                }
                return "";
            }
        }
        #endregion
        #region Méthode GetPasswordForUsername pour récupérer un mot de passe oublié
        public string GetCodeForUsersname(string password)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT password FROM Users WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Récupérer le mot de passe stocké dans la base de données
                    string storedPassword = reader.GetString(0);

                    // Déchiffrer le mot de passe stocké
                    string decryptedPassword = Cryptography.Decrypter(storedPassword);

                    return decryptedPassword;
                }

                // Si l'utilisateur n'existe pas, renvoyer null ou une valeur par défaut
                return null;
            }
        }
        #endregion
        #region GetUsersIDbyMatricule
        public int GetUsersIDbyMatricule(int id)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT COUNT(*) from Users where ID=@id";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", id);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                return 0;
            }
        }
        #endregion
        #region getUsersIDByNames
        public int getUsersIDByNames(string Names)
        {

            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT ID FROM Users WHERE nom = @noms";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@noms", Names);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
            }
            return 0;
        }
        #endregion
    }
}
