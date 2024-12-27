using BLL;
using System;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.IO;

namespace DAL
{
    public class AdministrateurDAL
    {
        #region Méthode AdminInsert
        public void Admininsert(AdministrateurBLL Ubl)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "INSERT INTO Admin (code, nom, prenom, telephone, sexe, FaceID) VALUES (@Code, @Nom, @Prenom, @Telephone, @Sexe, @FaceID)";
                SqlCommand command = new SqlCommand(query, cnx);
                command.Parameters.AddWithValue("@Code", Ubl.CodeAdmin);
                command.Parameters.AddWithValue("@Nom", Ubl.nomAdmin);
                command.Parameters.AddWithValue("@Prenom", Ubl.prenomAdmin);
                command.Parameters.AddWithValue("@Telephone", Ubl.telephoneAdmin);
                command.Parameters.AddWithValue("@Sexe", Ubl.sexeAdmin);
                command.Parameters.AddWithValue("@FaceID", Ubl.FaceIDAdmin);
                // command.Parameters.AddWithValue("@FaceID", Ubl.FaceIDAdmin);

                command.ExecuteNonQuery();
            }
        }
        #endregion
        #region GetAllAdmins
        public List<AdministrateurBLL> GetAllAdmins()
        {
            List<AdministrateurBLL> admins = new List<AdministrateurBLL>();
            
            string query = "SELECT * FROM Admin";

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        AdministrateurBLL admin = new AdministrateurBLL
                        {
                            id = rdr.GetInt32(0),
                            CodeAdmin = rdr.GetString(1),
                            nomAdmin = rdr.GetString(2),
                            prenomAdmin = rdr.GetString(3),
                            telephoneAdmin = rdr.GetString(4),
                            sexeAdmin = rdr.GetBoolean(5),
                            FaceIDAdmin = (byte[])rdr[6]
                        };

                        // Conversion de FaceIDAdmin (bytes) en Image<Gray, byte>
                        using (MemoryStream ms = new MemoryStream(admin.FaceIDAdmin))
                        {
                            ms.Seek(0, SeekOrigin.Begin);
                            Image img = Image.FromStream(ms);
                            Bitmap bmp = new Bitmap(img);
                            admin.FaceImageGray = new Image<Gray, byte>(bmp);
                        }

                        admins.Add(admin);
                    }
                }
            }

            return admins;
        }


        #endregion
        #region Méthode Adminexiste
        public bool Adminexiste(AdministrateurBLL Ubl)
        {
            if (Ubl == null || string.IsNullOrEmpty(Ubl.nomAdmin))
            {
                return false;
            }
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT COUNT(*) FROM Admin WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", Ubl.nomAdmin);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
        #endregion
        #region AdminSelect
        public DataTable AdminSelect(AdministrateurBLL Ubl)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                //La requête SQL ci-dessous permet de sélectionner tous les produits 
                //de la base de données et de les trier par ordre alphabétique  croissant en fonction de leur nom grâce à la clauseORDER BY Name ASC
                //ASC est utilisé pour indiquer que les résultats d'une requête doivent être triés dans l'ordre croissant et DESC dans le cas contraire.
                string query = "SELECT * FROM Admin ORDER BY nom ASC";
                SqlCommand cmd = new SqlCommand(query, cnx);
                SqlDataAdapter sdap = new SqlDataAdapter(cmd);
                sdap.Fill(dt);
            }
            return dt;
        }
        #endregion
        #region Méthode VerifyAdminInDatabase
        public bool VerifyAdminInDatabase(string nom, string code)
        {
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT Code FROM Admin WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", nom);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    // Récupérer le mot de passe stocké dans la base de données
                    string storedPassword = reader.GetString(0);
                    // Déchiffrer le mot de passe stocké
                    string decryptedPassword = Cryptography.Decrypter(storedPassword);
                    string codeString = code.ToString();
                    // Comparer le mot de passe entré avec le mot de passe stocké
                    if (decryptedPassword == codeString)
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        #endregion
        #region Méthode GetCodeFromDatabase
        public string GetCodeFromDatabase(string nom)
        {
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT code FROM Admin WHERE nom = @Nom";
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
        #region GetFaceIDFromDatabase
        public string GetFaceIDFromDatabase(string nom)
        {
            using (SqlConnection cnx = new
           SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT FaceID FROM Admin WHERE nom = @Nom";
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
        public string GetCodeForAdminname(string code)
        {
            using (SqlConnection cnx = new SqlConnection(ConfigurationManager.ConnectionStrings["CS"].ConnectionString))
            {
                cnx.Open();
                string query = "SELECT code FROM Admin WHERE nom = @Nom";
                SqlCommand cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Nom", code);
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
    }
}
