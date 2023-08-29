using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CU_ExitPaiment.Classes
{
    internal class SQLConnect
    {
        #region Properties

/*        public  static string _dataSource = @"PCFIXE-DORIAN\SQLEXPRESS";**/
        public static string _dataSource = @"DO_LAPTOP\SQLEXPRESS";
        private readonly static string _initialCatalog = "CU_ExitPaiement";
/*        private readonly static string _userID = "cuw";
*//*        private readonly static string _password = "Climb-up2021";
*/
        #endregion

        #region readDataFromSQL Methods


        /// <summary>
        //! Execute une requête SQL et retourne le résultat dans un string (pour les requêtes de type SELECT)
        //// </summary>
        /// <param name="queryToRead"></param>
        //! <returns>List of dictionnary representating all rows return by SQL Query</returns>


        //x Fonctionnement :
        /*?
         * var sqlResult = SQLConnect.readDataFromSQL("SELECT * FROM Equipement");
         * 
         * string stringResult = "";
         * 
         * foreach(var row in sqlResult)
         * {
         *  stringResult += row["isWeapon"].toString() + "\n";
         * }
         * MessageBox.Show(stringResult);
        */


        public static List<Dictionary<string, object>> readDataFromSQL(string queryToRead)
        {
            //! Création des données de connexion
            #region Connection String

            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.IntegratedSecurity = true;

            /*builder.UserID = _userID;
            builder.Password = _password;*/

            #endregion

            //! Liste de dictionnaire contenant les résultats de la requête (simulation des différentes lignes de résultat de notre requête)
            List<Dictionary<string, object>> resultList = new List<Dictionary<string, object>>();


            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                //! Ouverture de la connexion
                conn.Open();

                using (var command = new SqlCommand(queryToRead, conn))
                {
                    //! Execution de la requête
                    command.CommandText = queryToRead;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //! Récupération du nombre de colonne et initialisation du nombre de ligne
                        int fieldCount = reader.FieldCount;
                        int rowCount = 0;

                        //! Parcours des lignes de résultat
                        while (reader.Read())
                        {
                            //! Ajout d'un dictionnaire dans la liste de dictionnaire pour chaque ligne de résultat
                            resultList.Add(new Dictionary<string, object>());

                            for (int i = 0; i < fieldCount; i++)
                            {
                                //! Ajout de la colonne et de la valeur dans le dictionnaire
                                #region Ajout Valeur dans le dictionnaire en fonction du type
                               
                                try
                                {
                                    resultList[rowCount].Add(reader.GetName(i), reader.GetDateTime(i));
                                }
                                catch
                                {
                                    try
                                    {
                                        //! Ajout dans le dictionnaire si la valeur est un string
                                        resultList[rowCount].Add(reader.GetName(i), reader.GetString(i));

                                    }
                                    catch 
                                    {
                                        try
                                        {
                                            //! Ajout dans le dictionnaire si la valeur est un int
                                            resultList[rowCount].Add(reader.GetName(i), reader.GetInt32(i));
                                        }
                                        catch
                                        {
                                            try
                                            {
                                                resultList[rowCount].Add(reader.GetName(i), reader.GetFloat(i));
                                            }
                                            catch
                                            {
                                                //! Ajout dans le dictionnaire si la valeur est un bool
                                                resultList[rowCount].Add(reader.GetName(i), reader.GetBoolean(i));
                                            }
                                            
                                        }
                                    }
                                }
                                
                                #endregion
                            }
                            //! Incrémentation du nombre de ligne
                            rowCount++;
                        }
                    }
                }
                //! Fermeture de la connexion
                conn.Close();
            }

            return resultList;
        }
        #endregion


        #region ExecuteSQL Methods


        /// <summary>
        //! Execute une requête SQL en base et retourne un booléen si la requête s'est bien exécuté (pour les requêtes de type INSERT, UPDATE, DELETE)
        //// </summary>
        /// <param name="queryToWrite"></param>
        //! <returns>True or False on succes / error</returns>
        public static bool ExecuteSQL(string queryToWrite)
        {
            //! Création des données de connexion
            #region Connection String
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = _dataSource;
            builder.InitialCatalog = _initialCatalog;
            builder.IntegratedSecurity = true;
            /*builder.UserID = _userID;
            builder.Password = _password;*/

            #endregion

            //! Booléen de retour si la requête s'est bien exécuté
            bool success = false;

            using (var conn = new SqlConnection(builder.ConnectionString))
            {
                //! Ouverture de la connexion
                conn.Open();

                using (var command = new SqlCommand(queryToWrite, conn))
                {
                    //! Execution de la requête
                    command.CommandText = queryToWrite;

                    //! Vérification si la requête s'est bien exécuté + éxécution de la requête
                    if (command.ExecuteNonQuery() > 0)
                    {
                        success = true;
                    }
                }
                //! Fermeture de la connexion
                conn.Close();
            }
            return success;
        }



        public static bool addArdoise(string nom, string prenom, bool isNew, Dictionary<int, int> entreeMatos, DateTime date)
        {
            ExecuteSQL($"EXEC InsertNewClientAndArdoise @nom = '{nom}', @prenom = '{prenom}',@dateArdoise = '{date.ToShortDateString()}', @isNew = {Convert.ToInt32(isNew)}");
            bool success = false;
            foreach(var entree in entreeMatos)
            {
                success = ExecuteSQL($"INSERT INTO regler (Id_Ardoise, Id_EntreeMatos, quantite) VALUES ((SELECT Id_Ardoise FROM Clients c JOIN Ardoise a ON a.Id_Clients = c.Id_Clients WHERE nom = '{nom}' AND prenom = '{prenom}' AND a.dateArdoise = '{date.ToShortDateString()}'), {entree.Key}, {entree.Value})");
            }

            return success;
        }

        public static bool checkExistingClient(string nom, string prenom, DateTime date)
        {
            bool success = false;
            try
            {
                var resul_idClient = readDataFromSQL($"DECLARE @nom NVARCHAR(50) = '{nom}'; DECLARE @prenom NVARCHAR(50) = '{prenom}';SELECT Id_Clients FROM Clients WHERE LOWER(nom) = LOWER(@nom) AND LOWER(prenom) = LOWER(@prenom);");

                int idClient = (int)resul_idClient[0]["Id_Client"];
                var result = readDataFromSQL($"DECLARE @clientId INT; SET @clientId = {idClient} DECLARE @today DATE; SET @today = GETDATE(); IF EXISTS ( SELECT 1 FROM Ardoise WHERE Id_Clients = @clientId AND dateArdoise = @today ) SELECT 'Vrai' AS Result ELSE SELECT 'Faux' AS Result;");
                if (result.Count > 0)
                {
                    success = true;
                }
            }
            catch
            {
                success = false;
            }
            return success;
        }
        #endregion

    }
}
