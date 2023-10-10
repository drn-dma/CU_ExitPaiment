using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CU_ExitPaiment.Classes
{
    internal class SQLConnect
    {
        #region Properties

        /*public static string _dataSource = @"PCFIXE-DORIAN\SQLEXPRESS";*/
        /*public static string _dataSource = @"DO_LAPTOP\SQLEXPRESS";*/


        public static string _dataSource = GlobalSettings.Settings[0].Value;
        private readonly static string _initialCatalog = "CU_ExitPaiement";

        /*        private readonly static string _userID = "cuw";*/
        /*     private readonly static string _password = "Climb-up2021";*/
        
        #endregion

        #region readDataFromSQL_NoParameters Methods


        /// <summary>
        //! Execute une requête SQL et retourne le résultat dans un string (pour les requêtes de type SELECT)
        //// </summary>
        /// <param name="queryToRead"></param>
        //! <returns>List of dictionnary representating all rows return by SQL Query</returns>


        //x Fonctionnement :
        /*?
         * var sqlResult = SQLConnect.readDataFromSQL_NoParameters("SELECT * FROM Equipement");
         * 
         * string stringResult = "";
         * 
         * foreach(var row in sqlResult)
         * {
         *  stringResult += row["isWeapon"].toString() + "\n";
         * }
         * MessageBox.Show(stringResult);
        */

        public static List<Dictionary<string, object>> readDataFromSQL_WithParameters(string queryWithParam, List<SqlParameter> sqlParameters)
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
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Logger.WriteLog(e, e.StackTrace);

                    MessageBox.Show("Impossible de se connecter à la base de données");

                    string connString = "";

                    if(FunctionsLibs.InputBox_General("Modifier adresse BDD", "Saisir l'adresse : ", ref connString) == DialogResult.OK)
                    {
                        Logger.UpdateParam("Server_Adress", connString);
                        Application.Restart();
                    }

                    

                    
                    
                }

                using (var command = new SqlCommand(queryWithParam, conn))
                {
                    //! Ajout des paramètres à la requête
                    foreach (SqlParameter param in sqlParameters)
                    {
                        command.Parameters.Add(param);
                    }

                    //! Execution de la requête
                    command.CommandText = queryWithParam;

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
                                                try
                                                {
                                                    //! Ajout dans le dictionnaire si la valeur est un bool
                                                    resultList[rowCount].Add(reader.GetName(i), reader.GetBoolean(i));
                                                }
                                                catch
                                                {
                                                    //! Ajout dans le dictionnaire si la valeur est un double
                                                    resultList[rowCount].Add(reader.GetName(i), reader.IsDBNull(i));
                                                }
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

        public static List<Dictionary<string, object>> readDataFromSQL_NoParameters(string queryToRead)
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
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Logger.WriteLog(e, e.StackTrace);

                    MessageBox.Show("Impossible de se connecter à la base de données");

                    string connString = "";

                    if (FunctionsLibs.InputBox_General("Modifier adresse BDD", "Saisir l'adresse : ", ref connString) == DialogResult.OK)
                    {
                        Logger.UpdateParam("Server_Adress", connString);
                        Application.Restart();
                    }
                }

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
                                                try
                                                {
                                                    //! Ajout dans le dictionnaire si la valeur est un bool
                                                    resultList[rowCount].Add(reader.GetName(i), reader.GetBoolean(i));
                                                }
                                                catch
                                                {
                                                    //! Ajout dans le dictionnaire si la valeur est un double
                                                    resultList[rowCount].Add(reader.GetName(i), reader.IsDBNull(i));
                                                }
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
        public static bool ExecuteSQL_WithParameters(string queryToWrite, List<SqlParameter> sqlParameters)
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
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Logger.WriteLog(e, e.StackTrace);

                    MessageBox.Show("Impossible de se connecter à la base de données");

                    string connString = "";

                    if (FunctionsLibs.InputBox_General("Modifier adresse BDD", "Saisir l'adresse : ", ref connString) == DialogResult.OK)
                    {
                        Logger.UpdateParam("Server_Adress", connString);
                        Application.Restart();
                    }
                }

                using (var command = new SqlCommand(queryToWrite, conn))
                {
                    //! Ajout des paramètres à la requête

                    foreach (SqlParameter sqlParameter in sqlParameters)
                    {
                        command.Parameters.Add(sqlParameter);
                    }

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
        public static bool ExecuteSQL_NoParameters(string queryToWrite)
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
                try
                {
                    conn.Open();
                }
                catch (Exception e)
                {
                    Logger.WriteLog(e, e.StackTrace);

                    MessageBox.Show("Impossible de se connecter à la base de données");

                    string connString = "";

                    if (FunctionsLibs.InputBox_General("Modifier adresse BDD", "Saisir l'adresse : ", ref connString) == DialogResult.OK)
                    {
                        Logger.UpdateParam("Server_Adress", connString);
                        Application.Restart();
                    }

                }

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

        #endregion


        #region Custom_Classes

        public static bool addArdoise(string nom, string prenom, bool isNew, Dictionary<int, int> entreeMatos, DateTime date)
        {
            //! Ajout des paramètres à la requête
            List<SqlParameter> parameters1 = new List<SqlParameter>();
            SqlParameter q1Param1 = new SqlParameter("@name", DbType.String);
            SqlParameter q1Param2 = new SqlParameter("@firstname", DbType.String);
            SqlParameter q1Param3 = new SqlParameter("@date", DbType.String);
            SqlParameter q1Param4 = new SqlParameter("@new", DbType.Binary);

            q1Param1.Value = nom;
            q1Param2.Value = prenom;
            q1Param3.Value = date.ToShortDateString();
            q1Param4.Value = isNew;

            parameters1.Add(q1Param1);
            parameters1.Add(q1Param2);
            parameters1.Add(q1Param3);
            parameters1.Add(q1Param4);

            string query1 = "EXEC InsertNewClientAndArdoise @nom = @name, @prenom = @firstname ,@dateArdoise = @date, @isNew = @new";
            ExecuteSQL_WithParameters(query1, parameters1);

            bool success = false;
            foreach (var entree in entreeMatos)
            {
                //! Ajout des paramètres à la requête
                List<SqlParameter> parameters2 = new List<SqlParameter>();
                SqlParameter q2Param1 = new SqlParameter("@nom", DbType.String);
                SqlParameter q2Param2 = new SqlParameter("@prenom", DbType.String);
                SqlParameter q2Param3 = new SqlParameter("@date", DbType.String);
                SqlParameter q2Param4 = new SqlParameter("@idEntreeMatos", DbType.Int64);
                SqlParameter q2Param5 = new SqlParameter("@quantite", DbType.Int64);
                q2Param1.Value = nom;
                q2Param2.Value = prenom;
                q2Param3.Value = date.ToShortDateString();
                q2Param4.Value = entree.Key;
                q2Param5.Value = entree.Value;

                parameters2.Add(q2Param1);
                parameters2.Add(q2Param2);
                parameters2.Add(q2Param3);
                parameters2.Add(q2Param4);
                parameters2.Add(q2Param5);

                string query2 = "INSERT INTO regler(Id_Ardoise, Id_EntreeMatos, quantite) VALUES((SELECT Id_Ardoise FROM Clients c JOIN Ardoise a ON a.Id_Clients = c.Id_Clients WHERE nom = @nom AND prenom = @prenom AND a.dateArdoise = @date), @idEntreeMatos, @quantite)";
                success = ExecuteSQL_WithParameters(query2, parameters2);
            }
            return success;
        }

        public static bool checkExistingClient(string nom, string prenom, DateTime date)
        {
            bool success = false;
            int idClient = 0;
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>> { };

            string query = "DECLARE @nom NVARCHAR(50) = @name; DECLARE @prenom NVARCHAR(50) = @firstname; SELECT Id_Clients FROM Clients WHERE LOWER(nom) = LOWER(@nom) AND LOWER(prenom) = LOWER(@prenom); ";

            List<SqlParameter> q1Parameters = new List<SqlParameter> { };

            SqlParameter q1Param = new SqlParameter("@name", DbType.String);
            SqlParameter q1Param2 = new SqlParameter("@firstname", DbType.String);

            q1Param.Value = nom;
            q1Param2.Value = prenom;

            q1Parameters.Add(q1Param);
            q1Parameters.Add(q1Param2);

            var resul_idClient = readDataFromSQL_WithParameters(query, q1Parameters);



            if (resul_idClient.Count > 0)
            {
                idClient = (int)resul_idClient[0]["Id_Clients"];
                string queryToRead = "SELECT 1 FROM Ardoise WHERE Id_Clients = @idClient AND dateArdoise = @date";

                List<SqlParameter> q2Parameters = new List<SqlParameter> { };

                SqlParameter q2Param = new SqlParameter("@idClient", DbType.Int64);
                SqlParameter q2Param2 = new SqlParameter("@date", DbType.String);

                q2Param.Value = idClient;
                q2Param2.Value = date.ToShortDateString();

                q2Parameters.Add(q2Param);
                q2Parameters.Add(q2Param2);

                result = readDataFromSQL_WithParameters(queryToRead, q2Parameters);
            }

            if (result.Count > 0)
            {
                success = true;
            }
            else
            {
                success = false;
            }
            return success;
        }

        public static int countClientVisit(int idClient)
        {
            string queryToRead = ($"SELECT COUNT(*) as nbrVisite FROM Ardoise WHERE Id_Clients = @idClient");

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@idClient", DbType.Int64);

            param.Value = idClient;

            parameters.Add(param);

            var result = readDataFromSQL_WithParameters(queryToRead, parameters);

            return (int)result[0]["nbrVisite"];
        }

        public static List<Dictionary<string, object>> getAllClientsName()
        {
            var result = readDataFromSQL_NoParameters($"SELECT CONCAT(nom, ' ',prenom) as nomPrenom FROM Clients");
            return result;
        }

        public static List<Dictionary<string, object>> getAllLoyalComment()
        {
            var result = readDataFromSQL_NoParameters($"SELECT commentLoyality FROM Ardoise");
            return result;
        }

        public static List<Dictionary<string, object>> getAllConsos()
        {
            var result = readDataFromSQL_NoParameters($"SELECT Id_Consommation, libelle, prix, Id_TypeConso FROM Consommation");
            return result;
        }

        public static List<Dictionary<string, object>> getClientInfo(string idArdoise)
        {
            string query = "SELECT c.Id_Clients, CONCAT(c.nom, ' ',c.prenom) as nomPrenom, c.isNew FROM Clients c JOIN Ardoise a on a.Id_Clients = c.Id_Clients where a.Id_Ardoise = @idArdoise";
            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@idArdoise", DbType.Int64);
            param.Value = idArdoise;
            parameters.Add(param);
            var result = readDataFromSQL_WithParameters(query, parameters);
            return result;
        }

        public static List<Dictionary<string, object>> getArdoiseDetails(string IdArdoise, DateTime date)
        {
            string queryToRead = "SELECT a.Id_Ardoise, CONCAT(c.nom, ' ', c.prenom) as nomPrenom ,a.dateArdoise ,a.isPaid ,a.aRegler ,a.isLoyal, a.commentLoyality FROM Ardoise a JOIN Clients c on c.Id_Clients = a.Id_Clients where a.Id_Ardoise = @idArdoise and a.dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param2 = new SqlParameter("@date", DbType.String);
            SqlParameter param = new SqlParameter("@idArdoise", DbType.Int64);

            param.Value = IdArdoise;
            param2.Value = date.ToShortDateString();

            parameters.Add(param);
            parameters.Add(param2);

            return readDataFromSQL_WithParameters(queryToRead, parameters);
        }

        public static List<Dictionary<string, object>> getMatosDetails(string IdArdoise, DateTime date)
        {
            string queryToRead = "Select r.Id_EntreeMatos,r.quantite, e.prix FROM regler r JOIN Ardoise a on a.Id_Ardoise = r.Id_Ardoise JOIN EntreeMatos e ON e.Id_EntreeMatos = r.Id_EntreeMatos where r.Id_Ardoise = @idArdoise and a.dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param2 = new SqlParameter("@date", DbType.String);
            SqlParameter param = new SqlParameter("@idArdoise", DbType.Int64);

            param.Value = IdArdoise;
            param2.Value = date.ToShortDateString();

            parameters.Add(param);
            parameters.Add(param2);

            return readDataFromSQL_WithParameters(queryToRead, parameters);
        }

        public static bool setAReglerForArdoise(float coutTotalApprox, string idArdoise, DateTime date)
        {
            string query = "UPDATE Ardoise SET aRegler = @coutTotal WHERE Id_Ardoise = @idArdoise AND dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@coutTotal", SqlDbType.Real);
            SqlParameter param2 = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param3 = new SqlParameter("@date", DbType.String);

            param.Value = coutTotalApprox;
            param2.Value = idArdoise;
            param3.Value = date.ToShortDateString();

            parameters.Add(param);
            parameters.Add(param2);
            parameters.Add(param3);

            return ExecuteSQL_WithParameters(query, parameters);

        }

        public static bool setMatosQuantityForArdoise(int quantite, string idArdoise, int idItem)
        {
            string query = "UPDATE regler SET quantite = @quantite WHERE Id_Ardoise = @idArdoise AND Id_EntreeMatos = @idItem";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@quantite", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param3 = new SqlParameter("@idItem", SqlDbType.Int);

            param.Value = quantite;
            param2.Value = idArdoise;
            param3.Value = idItem;

            parameters.Add(param);
            parameters.Add(param2);
            parameters.Add(param3);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool setPaidForArdoise(string idArdoise, DateTime date)
        {
            string query = "UPDATE Ardoise SET isPaid = 1 WHERE Id_Ardoise = @idArdoise AND dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@date", DbType.String);

            param.Value = idArdoise;
            param2.Value = date.ToShortDateString();

            parameters.Add(param);
            parameters.Add(param2);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool setIsNewTrueForClient(int idClient)
        {
            string query = "UPDATE Clients SET isNew = 1 WHERE Id_Clients = @idClient";

            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@idClient", SqlDbType.Int);
            param.Value = idClient;
            parameters.Add(param);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool setLoyalTrueForArdoise(string idArdoise, DateTime date)
        {
            string query = "UPDATE Ardoise SET isLoyal = 1 WHERE Id_Ardoise = @idArdoise AND dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@date", DbType.String);

            param.Value = idArdoise;
            param2.Value = date.ToShortDateString();

            parameters.Add(param);
            parameters.Add(param2);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool setLoyalFalseAndCommentForArdoise(string idArdoise, DateTime date, string comment)
        {
            string query = "UPDATE Ardoise SET isLoyal = 0, commentLoyality = @comment WHERE Id_Ardoise = @idArdoise AND dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };

            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@date", DbType.String);
            SqlParameter param3 = new SqlParameter("@comment", SqlDbType.VarChar);

            param.Value = idArdoise;
            param2.Value = date.ToShortDateString();
            param3.Value = comment;

            parameters.Add(param);
            parameters.Add(param2);
            parameters.Add(param3);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool setIsNewFalseForClient(int idClient)
        {
            string query = "UPDATE Clients SET isNew = 0 WHERE Id_Clients = @idClient";

            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@idClient", SqlDbType.Int);
            param.Value = idClient;
            parameters.Add(param);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static bool cancelPaiement(string idArdoise, DateTime date)
        {
            string query = "UPDATE Ardoise SET isPaid = 0, isLoyal = 0 WHERE Id_Ardoise = @idArdoise AND dateArdoise = @date";

            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@date", DbType.String);
            param.Value = idArdoise;
            param2.Value = date.ToShortDateString();
            parameters.Add(param);
            parameters.Add(param2);

            return ExecuteSQL_WithParameters(query, parameters);
        }

        public static List<Dictionary<string, object>> getConsoForArdoise(string idArdoise)
        {
            string query = "SELECT co.Id_Ardoise, co.Id_Consommation, co.quantite, c.prix, c.libelle FROM consommer co JOIN Consommation c ON c.Id_Consommation = co.Id_Consommation WHERE Id_Ardoise = @idArdoise";

            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            param.Value = idArdoise;
            parameters.Add(param);

            return readDataFromSQL_WithParameters(query, parameters);
        }

        public static bool verifierSiConsoExiste(string idArdoise, string idConso)
        {
            string query = "SELECT COUNT(*) as compteur FROM consommer WHERE Id_Ardoise = @IdArdoise AND Id_Consommation = @IdConsommation";
            List<SqlParameter> parameters = new List<SqlParameter> { };
            SqlParameter param = new SqlParameter("@IdArdoise", SqlDbType.Int);
            SqlParameter param2 = new SqlParameter("@IdConsommation", SqlDbType.Int);
            param.Value = idArdoise;
            param2.Value = idConso;
            parameters.Add(param);
            parameters.Add(param2);

            var res = readDataFromSQL_WithParameters(query, parameters);

            if (res[0]["compteur"].ToString() != "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool addConsoToArdoise(string idArdoise, Dictionary<string, int> allItems)
        {
            var actualConso = getConsoForArdoise(idArdoise);
            int i = 0;
            bool success = false;

            foreach (var item in allItems)
            {

                if (verifierSiConsoExiste(idArdoise, item.Key))
                {
                    string query = "UPDATE consommer SET quantite += @quantite WHERE Id_Ardoise = @idArdoise AND Id_Consommation = @idConso";
                    List<SqlParameter> parameters = new List<SqlParameter> { };
                    SqlParameter param = new SqlParameter("@quantite", SqlDbType.Int);
                    SqlParameter param2 = new SqlParameter("@idArdoise", SqlDbType.Int);
                    SqlParameter param3 = new SqlParameter("@idConso", SqlDbType.Int);
                    param.Value = item.Value;
                    param2.Value = idArdoise;
                    param3.Value = item.Key;
                    parameters.Add(param);
                    parameters.Add(param2);
                    parameters.Add(param3);

                    success = ExecuteSQL_WithParameters(query, parameters);

                }
                else
                {
                    string query = "INSERT INTO consommer (Id_Ardoise,Id_Consommation,quantite) VALUES (@idArdoise,@idConso,@quantite)";
                    List<SqlParameter> parameters = new List<SqlParameter> { };
                    SqlParameter param = new SqlParameter("@quantite", SqlDbType.Int);
                    SqlParameter param2 = new SqlParameter("@idArdoise", SqlDbType.Int);
                    SqlParameter param3 = new SqlParameter("@idConso", SqlDbType.Int);
                    param.Value = item.Value;
                    param2.Value = idArdoise;
                    param3.Value = item.Key;
                    parameters.Add(param);
                    parameters.Add(param2);
                    parameters.Add(param3);

                    success = ExecuteSQL_WithParameters(query, parameters);
                }


            }

            return success;
        }

        public static bool deleteArdoise(string idArdoise)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("@idArdoise", SqlDbType.Int);
            param.Value = idArdoise;
            sqlParameters.Add(param);

            return ExecuteSQL_WithParameters("DELETE Ardoise WHERE Id_Ardoise = @idArdoise", sqlParameters);
        }



        public static bool isAdmin(string pin)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param = new SqlParameter("@cPassword", SqlDbType.Int);
            param.Value = pin;
            sqlParameters.Add(param);

            var b_returned = readDataFromSQL_WithParameters("DECLARE @responseMessage NVARCHAR(250) EXEC dbo.uspLogin @pLoginName = N'admin', @pPassword = @cPassword, @responseMessage = @responseMessage OUTPUT SELECT @responseMessage as N'@responseMessage'", sqlParameters);

            if (b_returned.Count != 0)
            {
                switch (b_returned[0]["@responseMessage"])
                {
                    case "true":
                        return true;
                    default:
                        return false;
                }
            }
            return false;
        }

        public static bool changeUserPassword(string username, string password)
        {
            List<SqlParameter> sqlParameters = new List<SqlParameter>();
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.VarChar);
            SqlParameter param2 = new SqlParameter("@cPassword", SqlDbType.Int);
            param1.Value = username;
            param2.Value = password;
            sqlParameters.Add(param1);
            sqlParameters.Add(param2);

            return ExecuteSQL_WithParameters("EXEC dbo.uspUpdatePsw @pLoginName = @name, @pPassword = @cPassword", sqlParameters);
        }

        #endregion
    }
}
