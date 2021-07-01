using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EduHub.Data.Entities
{
    /// <summary>
    /// Contacts Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KPCDataSet : EduHubDataSet<KPC>
    {
        /// <inheritdoc />
        public override string Name { get { return "KPC"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KPCDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KPCKEY = new Lazy<Dictionary<string, KPC>>(() => this.ToDictionary(i => i.KPCKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KPC" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KPC" /> fields for each CSV column header</returns>
        internal override Action<KPC, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KPC, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KPCKEY":
                        mapper[i] = (e, v) => e.KPCKEY = v;
                        break;
                    case "SURNAME":
                        mapper[i] = (e, v) => e.SURNAME = v;
                        break;
                    case "FIRST_NAME":
                        mapper[i] = (e, v) => e.FIRST_NAME = v;
                        break;
                    case "SECOND_NAME":
                        mapper[i] = (e, v) => e.SECOND_NAME = v;
                        break;
                    case "GENDER":
                        mapper[i] = (e, v) => e.GENDER = v;
                        break;
                    case "ADDRESS01":
                        mapper[i] = (e, v) => e.ADDRESS01 = v;
                        break;
                    case "ADDRESS02":
                        mapper[i] = (e, v) => e.ADDRESS02 = v;
                        break;
                    case "ADDRESS03":
                        mapper[i] = (e, v) => e.ADDRESS03 = v;
                        break;
                    case "STATE":
                        mapper[i] = (e, v) => e.STATE = v;
                        break;
                    case "POST":
                        mapper[i] = (e, v) => e.POST = v;
                        break;
                    case "BUS_PHONE":
                        mapper[i] = (e, v) => e.BUS_PHONE = v;
                        break;
                    case "HOME_PHONE":
                        mapper[i] = (e, v) => e.HOME_PHONE = v;
                        break;
                    case "MOBILE":
                        mapper[i] = (e, v) => e.MOBILE = v;
                        break;
                    case "EMAIL":
                        mapper[i] = (e, v) => e.EMAIL = v;
                        break;
                    case "LW_DATE":
                        mapper[i] = (e, v) => e.LW_DATE = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LW_TIME":
                        mapper[i] = (e, v) => e.LW_TIME = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "LW_USER":
                        mapper[i] = (e, v) => e.LW_USER = v;
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="KPC" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KPC" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KPC" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KPC}"/> of entities</returns>
        internal override IEnumerable<KPC> ApplyDeltaEntities(IEnumerable<KPC> Entities, List<KPC> DeltaEntities)
        {
            HashSet<string> Index_KPCKEY = new HashSet<string>(DeltaEntities.Select(i => i.KPCKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KPCKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KPCKEY.Remove(entity.KPCKEY);
                            
                            if (entity.KPCKEY.CompareTo(deltaClusteredKey) <= 0)
                            {
                                if (!overwritten)
                                {
                                    yield return entity;
                                }
                            }
                            else
                            {
                                yieldEntity = !overwritten;
                                break;
                            }
                        }
                        
                        yield return deltaIterator.Current;
                        if (yieldEntity)
                        {
                            yield return entityIterator.Current;
                        }
                    }

                    while (entityIterator.MoveNext())
                    {
                        yield return entityIterator.Current;
                    }
                }
            }
        }

        #region Index Fields

        private Lazy<Dictionary<string, KPC>> Index_KPCKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC FindByKPCKEY(string KPCKEY)
        {
            return Index_KPCKEY.Value[KPCKEY];
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <param name="Value">Related KPC entity</param>
        /// <returns>True if the related KPC entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKPCKEY(string KPCKEY, out KPC Value)
        {
            return Index_KPCKEY.Value.TryGetValue(KPCKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KPC by KPCKEY field
        /// </summary>
        /// <param name="KPCKEY">KPCKEY value used to find KPC</param>
        /// <returns>Related KPC entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KPC TryFindByKPCKEY(string KPCKEY)
        {
            KPC value;
            if (Index_KPCKEY.Value.TryGetValue(KPCKEY, out value))
            {
                return value;
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region SQL Integration

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KPC table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KPC]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KPC](
        [KPCKEY] varchar(10) NOT NULL,
        [SURNAME] varchar(20) NULL,
        [FIRST_NAME] varchar(15) NULL,
        [SECOND_NAME] varchar(15) NULL,
        [GENDER] varchar(1) NULL,
        [ADDRESS01] varchar(30) NULL,
        [ADDRESS02] varchar(30) NULL,
        [ADDRESS03] varchar(30) NULL,
        [STATE] varchar(3) NULL,
        [POST] varchar(4) NULL,
        [BUS_PHONE] varchar(15) NULL,
        [HOME_PHONE] varchar(15) NULL,
        [MOBILE] varchar(15) NULL,
        [EMAIL] varchar(MAX) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KPC_Index_KPCKEY] PRIMARY KEY CLUSTERED (
            [KPCKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KPCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KPCDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KPC"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KPC"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KPC> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KPCKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KPCKEY.Add(entity.KPCKEY);
            }

            builder.AppendLine("DELETE [dbo].[KPC] WHERE");


            // Index_KPCKEY
            builder.Append("[KPCKEY] IN (");
            for (int index = 0; index < Index_KPCKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KPCKEY
                var parameterKPCKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKPCKEY);
                command.Parameters.Add(parameterKPCKEY, SqlDbType.VarChar, 10).Value = Index_KPCKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPC data set</returns>
        public override EduHubDataSetDataReader<KPC> GetDataSetDataReader()
        {
            return new KPCDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KPC data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KPC data set</returns>
        public override EduHubDataSetDataReader<KPC> GetDataSetDataReader(List<KPC> Entities)
        {
            return new KPCDataReader(new EduHubDataSetLoadedReader<KPC>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KPCDataReader : EduHubDataSetDataReader<KPC>
        {
            public KPCDataReader(IEduHubDataSetReader<KPC> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 17; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KPCKEY
                        return Current.KPCKEY;
                    case 1: // SURNAME
                        return Current.SURNAME;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME;
                    case 3: // SECOND_NAME
                        return Current.SECOND_NAME;
                    case 4: // GENDER
                        return Current.GENDER;
                    case 5: // ADDRESS01
                        return Current.ADDRESS01;
                    case 6: // ADDRESS02
                        return Current.ADDRESS02;
                    case 7: // ADDRESS03
                        return Current.ADDRESS03;
                    case 8: // STATE
                        return Current.STATE;
                    case 9: // POST
                        return Current.POST;
                    case 10: // BUS_PHONE
                        return Current.BUS_PHONE;
                    case 11: // HOME_PHONE
                        return Current.HOME_PHONE;
                    case 12: // MOBILE
                        return Current.MOBILE;
                    case 13: // EMAIL
                        return Current.EMAIL;
                    case 14: // LW_DATE
                        return Current.LW_DATE;
                    case 15: // LW_TIME
                        return Current.LW_TIME;
                    case 16: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // SURNAME
                        return Current.SURNAME == null;
                    case 2: // FIRST_NAME
                        return Current.FIRST_NAME == null;
                    case 3: // SECOND_NAME
                        return Current.SECOND_NAME == null;
                    case 4: // GENDER
                        return Current.GENDER == null;
                    case 5: // ADDRESS01
                        return Current.ADDRESS01 == null;
                    case 6: // ADDRESS02
                        return Current.ADDRESS02 == null;
                    case 7: // ADDRESS03
                        return Current.ADDRESS03 == null;
                    case 8: // STATE
                        return Current.STATE == null;
                    case 9: // POST
                        return Current.POST == null;
                    case 10: // BUS_PHONE
                        return Current.BUS_PHONE == null;
                    case 11: // HOME_PHONE
                        return Current.HOME_PHONE == null;
                    case 12: // MOBILE
                        return Current.MOBILE == null;
                    case 13: // EMAIL
                        return Current.EMAIL == null;
                    case 14: // LW_DATE
                        return Current.LW_DATE == null;
                    case 15: // LW_TIME
                        return Current.LW_TIME == null;
                    case 16: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KPCKEY
                        return "KPCKEY";
                    case 1: // SURNAME
                        return "SURNAME";
                    case 2: // FIRST_NAME
                        return "FIRST_NAME";
                    case 3: // SECOND_NAME
                        return "SECOND_NAME";
                    case 4: // GENDER
                        return "GENDER";
                    case 5: // ADDRESS01
                        return "ADDRESS01";
                    case 6: // ADDRESS02
                        return "ADDRESS02";
                    case 7: // ADDRESS03
                        return "ADDRESS03";
                    case 8: // STATE
                        return "STATE";
                    case 9: // POST
                        return "POST";
                    case 10: // BUS_PHONE
                        return "BUS_PHONE";
                    case 11: // HOME_PHONE
                        return "HOME_PHONE";
                    case 12: // MOBILE
                        return "MOBILE";
                    case 13: // EMAIL
                        return "EMAIL";
                    case 14: // LW_DATE
                        return "LW_DATE";
                    case 15: // LW_TIME
                        return "LW_TIME";
                    case 16: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KPCKEY":
                        return 0;
                    case "SURNAME":
                        return 1;
                    case "FIRST_NAME":
                        return 2;
                    case "SECOND_NAME":
                        return 3;
                    case "GENDER":
                        return 4;
                    case "ADDRESS01":
                        return 5;
                    case "ADDRESS02":
                        return 6;
                    case "ADDRESS03":
                        return 7;
                    case "STATE":
                        return 8;
                    case "POST":
                        return 9;
                    case "BUS_PHONE":
                        return 10;
                    case "HOME_PHONE":
                        return 11;
                    case "MOBILE":
                        return 12;
                    case "EMAIL":
                        return 13;
                    case "LW_DATE":
                        return 14;
                    case "LW_TIME":
                        return 15;
                    case "LW_USER":
                        return 16;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
