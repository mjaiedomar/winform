using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_session_winform.modele;

namespace tp_session_winform
{
    internal class DaoContact
    {

        public MySqlConnection mySqlConnection { get; set; }
        public MySqlCommand command { get; set; }

        public DaoContact(string cs)
        {
            this.mySqlConnection = new MySqlConnection(cs);
        }

        public int ExecuterCommande(string cde, Contact contc)
        {
            int lignes;
       

            GetCommande(cde);
            //Mettre en relation
            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = contc.Nom;

            MySqlParameter pEmail = new MySqlParameter();
            pEmail.ParameterName = "@email";
            pEmail.Value = contc.Email;

              //Ajouter les params à la commande
            command.Parameters.Add(pNom);
            command.Parameters.Add(pEmail);
          
            //Execution
            lignes = command.ExecuteNonQuery();
            FermerConnexion();

            return lignes;
        }

        public int ExecuterCommandeFornisseur(string cde, Fournisseur frs)
        {
            int lignes;


            GetCommande(cde);
            //Mettre en relation
            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = frs.Nom;

            MySqlParameter pEmail = new MySqlParameter();
            pEmail.ParameterName = "@email";
            pEmail.Value = frs.Email;

            MySqlParameter pCode = new MySqlParameter();
            pCode.ParameterName = "@code_scn";
            pCode.Value = frs.code_scn;

            //Ajouter les params à la commande
            command.Parameters.Add(pNom);
            command.Parameters.Add(pEmail);
            command.Parameters.Add(pCode);

            //Execution
            lignes = command.ExecuteNonQuery();
            FermerConnexion();

            return lignes;
        }

        private void FermerConnexion()
        {
            mySqlConnection.Close();
        }

        private void GetCommande(string cde)
        {
            mySqlConnection.Open();
            command = new MySqlCommand(cde, mySqlConnection);
        }

        public List<Contact> ExecuterRequete(string requete)
        {
            GetCommande(requete);
            List<Contact> registre = new List<Contact>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

            string nom, email;
            while (reader.Read())
            {
                nom = (string)reader[0];
                email = (string)reader[1];
                
                registre.Add(new Contact(nom, email));
            }

            FermerConnexion();
            return registre;
        }

        public List<Fournisseur> ExecuterRequeteFrs(string requete)
        {
            GetCommande(requete);
            List<Fournisseur> registre = new List<Fournisseur>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

            string nom, email;
            int code_scn;
            while (reader.Read())
            {
                code_scn = (int)reader[0];
                nom = (string)reader[1];
                email = (string)reader[2];

                registre.Add(new Fournisseur(code_scn,nom, email));
            }

            FermerConnexion();
            return registre;
        }


        public List<Contact> ExecuterRequeteSearch(string requete, String Nom)
        {
            GetCommande(requete);
            List<Contact> registre = new List<Contact>();



            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = Nom;



            //Ajouter les params à la commande
            command.Parameters.Add(pNom);


            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

            string nom, email;
            while (reader.Read())
            {
                nom = (string)reader[0];
                email = (string)reader[1];

                registre.Add(new Contact(nom, email));
            }

            FermerConnexion();
            return registre;
        }
        public List<Fournisseur> ExecuterRequeteSearchFrs(string requete, String Nom)
        {
            GetCommande(requete);
            List<Fournisseur> registre = new List<Fournisseur>();



            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = Nom;



            //Ajouter les params à la commande
            command.Parameters.Add(pNom);


            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

            string nom, email;
            int code_scn;
            while (reader.Read())
            {
                code_scn = (int)reader[0];
                nom = (string)reader[1];
                email = (string)reader[2];

                registre.Add(new Fournisseur(code_scn, nom, email));
            }

            FermerConnexion();
            return registre;
        }
    }
}

