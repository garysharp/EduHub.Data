using EduHub.Data.SeamlessViews.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace EduHub.Data.SeamlessViews
{
    /// <summary>
    /// Seamless Views Context
    /// </summary>
    public class SeamlessViewsContext
    {
        private readonly EduHubContext eduHubContext;

        private readonly V_AIMDataSet _V_AIM;
        private readonly V_FAMILY_CONTACTDataSet _V_FAMILY_CONTACT;
        private readonly V_KGCDataSet _V_KGC;
        private readonly V_KGHDataSet _V_KGH;
        private readonly V_KGLDataSet _V_KGL;
        private readonly V_KSFDataSet _V_KSF;
        private readonly V_RISKDataSet _V_RISK;
        private readonly V_SCIDataSet _V_SCI;
        private readonly V_SCLDataSet _V_SCL;
        private readonly V_SFDataSet _V_SF;
        private readonly V_SGDataSet _V_SG;
        private readonly V_SMDataSet _V_SM;
        private readonly V_STDataSet _V_ST;
        private readonly V_ST_ATTENDDataSet _V_ST_ATTEND;
        private readonly V_STMADataSet _V_STMA;
        private readonly V_STPODataSet _V_STPO;
        private readonly V_SUDataSet _V_SU;
        private readonly V_SXABDataSet _V_SXAB;
        private readonly V_TXASDataSet _V_TXAS;

        internal SeamlessViewsContext(EduHubContext EduHubContext)
        {
            eduHubContext = EduHubContext;

            _V_AIM = new V_AIMDataSet(this);
            _V_FAMILY_CONTACT = new V_FAMILY_CONTACTDataSet(this);
            _V_KGC = new V_KGCDataSet(this);
            _V_KGH = new V_KGHDataSet(this);
            _V_KGL = new V_KGLDataSet(this);
            _V_KSF = new V_KSFDataSet(this);
            _V_RISK = new V_RISKDataSet(this);
            _V_SCI = new V_SCIDataSet(this);
            _V_SCL = new V_SCLDataSet(this);
            _V_SF = new V_SFDataSet(this);
            _V_SG = new V_SGDataSet(this);
            _V_SM = new V_SMDataSet(this);
            _V_ST = new V_STDataSet(this);
            _V_ST_ATTEND = new V_ST_ATTENDDataSet(this);
            _V_STMA = new V_STMADataSet(this);
            _V_STPO = new V_STPODataSet(this);
            _V_SU = new V_SUDataSet(this);
            _V_SXAB = new V_SXABDataSet(this);
            _V_TXAS = new V_TXASDataSet(this);
        }

        /// <summary>
        /// All Seamless Views Data Sets
        /// </summary>
        public IEnumerable<ISeamlessViewsDataSet> GetDataSets()
        {
            yield return _V_AIM;
            yield return _V_FAMILY_CONTACT;
            yield return _V_KGC;
            yield return _V_KGH;
            yield return _V_KGL;
            yield return _V_KSF;
            yield return _V_RISK;
            yield return _V_SCI;
            yield return _V_SCL;
            yield return _V_SF;
            yield return _V_SG;
            yield return _V_SM;
            yield return _V_ST;
            yield return _V_ST_ATTEND;
            yield return _V_STMA;
            yield return _V_STPO;
            yield return _V_SU;
            yield return _V_SXAB;
            yield return _V_TXAS;
        }

        /// <summary>
        /// Names of all Seamless Views Data Sets
        /// </summary>
        public IEnumerable<string> GetDataSetNames()
        {
            foreach (var dataSet in GetDataSets())
            {
                yield return dataSet.Name;
            }
        }

        /// <summary>
        /// Retrieves a Seamless Views Data Set by Name
        /// </summary>
        /// <param name="Name">Name of the Seamless Views Data Set</param>
        public ISeamlessViewsDataSet GetDataSet(string Name)
        {
            foreach (var dataSet in GetDataSets())
            {
                if (dataSet.Name.Equals(Name, StringComparison.OrdinalIgnoreCase))
                {
                    return dataSet;
                }
            }

            throw new ArgumentException($"Unknown Seamless Views Data Set [{Name}]", nameof(Name));
        }

        /// <summary>
        /// Available Data Sets
        /// </summary>
        public IEnumerable<ISeamlessViewsDataSet> GetAvailableDataSets()
        {
            foreach (var dataSet in GetDataSets())
            {
                if (dataSet.IsAvailable)
                {
                    yield return dataSet;
                }
            }
        }

        /// <summary>
        /// Names of Available Data Sets
        /// </summary>
        public IEnumerable<string> GetAvailableDataSetNames()
        {
            foreach (var dataSet in GetAvailableDataSets())
            {
                yield return dataSet.Name;
            }
        }

        /// <summary>
        /// Creates all available views in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the views to, and which contains the eduHub Datasets</param>
        public void CreateInSqlServer(string Server, string Database)
        {
            CreateInSqlServer(Server, Database, Database);
        }

        /// <summary>
        /// Creates all available views in a SQL Server database, connecting to the SQL Server using Integrated Authentication.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        public void CreateInSqlServer(string Server, string Database, string ParentDatabase)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                IntegratedSecurity = true
            };

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                CreateInSqlServer(connection, ParentDatabase);
            }
        }

        /// <summary>
        /// Creates all available views in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the SQL database to add the views to, and which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        public void CreateInSqlServer(string Server, string Database, string SqlUsername, string SqlPassword)
        {
            CreateInSqlServer(Server, Database, Database, SqlUsername, SqlPassword);
        }

        /// <summary>
        /// Creates all available views in a SQL Server database, connecting to the SQL Server using the provided username and password.
        /// </summary>
        /// <param name="Server">The name or network address of the instance of SQL Server to connect to.</param>
        /// <param name="Database">The name of the Seamless Views SQL database</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        /// <param name="SqlUsername">The SQL User ID to be used when connecting to SQL Server</param>
        /// <param name="SqlPassword">The password for the SQL Server account</param>
        public void CreateInSqlServer(string Server, string Database, string ParentDatabase, string SqlUsername, string SqlPassword)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                ApplicationName = "EduHub.Data",
                DataSource = Server,
                InitialCatalog = Database,
                MultipleActiveResultSets = true,
                UserID = SqlUsername,
                Password = SqlPassword
            };

            using (var connection = new SqlConnection(builder.ConnectionString))
            {
                CreateInSqlServer(connection, ParentDatabase);
            }
        }

        /// <summary>
        /// Creates all available views in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        public void CreateInSqlServer(SqlConnection Connection)
        {
            CreateInSqlServer(Connection, Connection.Database);
        }

        /// <summary>
        /// Creates all available views in a SQL Server database using the provided SQL Server connection.
        /// </summary>
        /// <param name="Connection">An existing connection to the SQL Server</param>
        /// <param name="ParentDatabase">The name of the SQL database which contains the eduHub Datasets</param>
        public void CreateInSqlServer(SqlConnection Connection, string ParentDatabase)
        {
            foreach (var dataSet in GetAvailableDataSets())
            {
                dataSet.CreateInSqlServer(Connection, ParentDatabase);
            }
        }

        /// <summary>
        /// eduHub Context
        /// </summary>
        public EduHubContext EduHubContext { get { return eduHubContext; } }

        /// <summary>
        /// AIM Seamless View
        /// </summary>
        public V_AIMDataSet V_AIM { get { return _V_AIM; } }

        /// <summary>
        /// Family Contact Seamless View
        /// </summary>
        public V_FAMILY_CONTACTDataSet V_FAMILY_CONTACT { get { return _V_FAMILY_CONTACT; } }

        /// <summary>
        /// Home Groups Seamless View
        /// </summary>
        public V_KGCDataSet V_KGC { get { return _V_KGC; } }

        /// <summary>
        /// Houses Seamless View
        /// </summary>
        public V_KGHDataSet V_KGH { get { return _V_KGH; } }

        /// <summary>
        /// Languages Seamless View
        /// </summary>
        public V_KGLDataSet V_KGL { get { return _V_KGL; } }

        /// <summary>
        /// Faculties Seamless View
        /// </summary>
        public V_KSFDataSet V_KSF { get { return _V_KSF; } }

        /// <summary>
        /// Risk Seamless View
        /// </summary>
        public V_RISKDataSet V_RISK { get { return _V_RISK; } }

        /// <summary>
        /// School Information Seamless View
        /// </summary>
        public V_SCIDataSet V_SCI { get { return _V_SCI; } }

        /// <summary>
        /// Subject Classes Seamless View
        /// </summary>
        public V_SCLDataSet V_SCL { get { return _V_SCL; } }

        /// <summary>
        /// Staff Seamless View
        /// </summary>
        public V_SFDataSet V_SF { get { return _V_SF; } }

        /// <summary>
        /// Student Groupings Seamless View
        /// </summary>
        public V_SGDataSet V_SG { get { return _V_SG; } }

        /// <summary>
        /// Rooms Seamless View
        /// </summary>
        public V_SMDataSet V_SM { get { return _V_SM; } }

        /// <summary>
        /// Students Seamless View
        /// </summary>
        public V_STDataSet V_ST { get { return _V_ST; } }

        /// <summary>
        /// Student Attendance Seamless View
        /// </summary>
        public V_ST_ATTENDDataSet V_ST_ATTEND { get { return _V_ST_ATTEND; } }

        /// <summary>
        /// Subject Selections &amp; Marks Seamless View
        /// </summary>
        public V_STMADataSet V_STMA { get { return _V_STMA; } }

        /// <summary>
        /// Position or Group Memberships Seamless View
        /// </summary>
        public V_STPODataSet V_STPO { get { return _V_STPO; } }

        /// <summary>
        /// Subject Classes Seamless View
        /// </summary>
        public V_SUDataSet V_SU { get { return _V_SU; } }

        /// <summary>
        /// Student Half-Day Absences Seamless View
        /// </summary>
        public V_SXABDataSet V_SXAB { get { return _V_SXAB; } }

        /// <summary>
        /// Actual Sessions Seamless View
        /// </summary>
        public V_TXASDataSet V_TXAS { get { return _V_TXAS; } }
    }
}
