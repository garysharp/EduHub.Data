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
    /// Visa Subclasses Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KCVDataSet : EduHubDataSet<KCV>
    {
        /// <inheritdoc />
        public override string Name { get { return "KCV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KCVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_VISA_SUBCLASS = new Lazy<Dictionary<string, KCV>>(() => this.ToDictionary(i => i.VISA_SUBCLASS));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KCV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KCV" /> fields for each CSV column header</returns>
        internal override Action<KCV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KCV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "VISA_SUBCLASS":
                        mapper[i] = (e, v) => e.VISA_SUBCLASS = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "VISA_RESIDENCY":
                        mapper[i] = (e, v) => e.VISA_RESIDENCY = v;
                        break;
                    case "SGB_FUNDED":
                        mapper[i] = (e, v) => e.SGB_FUNDED = v;
                        break;
                    case "CHECK_STAT_CODE":
                        mapper[i] = (e, v) => e.CHECK_STAT_CODE = v;
                        break;
                    case "CHECK_EXPIRY_DATE":
                        mapper[i] = (e, v) => e.CHECK_EXPIRY_DATE = v;
                        break;
                    case "CHECK_ISID":
                        mapper[i] = (e, v) => e.CHECK_ISID = v;
                        break;
                    case "REFUGEE":
                        mapper[i] = (e, v) => e.REFUGEE = v;
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
        /// Merges <see cref="KCV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KCV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KCV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KCV}"/> of entities</returns>
        internal override IEnumerable<KCV> ApplyDeltaEntities(IEnumerable<KCV> Entities, List<KCV> DeltaEntities)
        {
            HashSet<string> Index_VISA_SUBCLASS = new HashSet<string>(DeltaEntities.Select(i => i.VISA_SUBCLASS));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.VISA_SUBCLASS;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_VISA_SUBCLASS.Remove(entity.VISA_SUBCLASS);
                            
                            if (entity.VISA_SUBCLASS.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KCV>> Index_VISA_SUBCLASS;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV FindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            return Index_VISA_SUBCLASS.Value[VISA_SUBCLASS];
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <param name="Value">Related KCV entity</param>
        /// <returns>True if the related KCV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByVISA_SUBCLASS(string VISA_SUBCLASS, out KCV Value)
        {
            return Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out Value);
        }

        /// <summary>
        /// Attempt to find KCV by VISA_SUBCLASS field
        /// </summary>
        /// <param name="VISA_SUBCLASS">VISA_SUBCLASS value used to find KCV</param>
        /// <returns>Related KCV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KCV TryFindByVISA_SUBCLASS(string VISA_SUBCLASS)
        {
            KCV value;
            if (Index_VISA_SUBCLASS.Value.TryGetValue(VISA_SUBCLASS, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KCV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KCV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KCV](
        [VISA_SUBCLASS] varchar(3) NOT NULL,
        [DESCRIPTION] varchar(52) NULL,
        [VISA_RESIDENCY] varchar(1) NULL,
        [SGB_FUNDED] varchar(1) NULL,
        [CHECK_STAT_CODE] varchar(1) NULL,
        [CHECK_EXPIRY_DATE] varchar(1) NULL,
        [CHECK_ISID] varchar(1) NULL,
        [REFUGEE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KCV_Index_VISA_SUBCLASS] PRIMARY KEY CLUSTERED (
            [VISA_SUBCLASS] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KCVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KCVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KCV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KCV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KCV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_VISA_SUBCLASS = new List<string>();

            foreach (var entity in Entities)
            {
                Index_VISA_SUBCLASS.Add(entity.VISA_SUBCLASS);
            }

            builder.AppendLine("DELETE [dbo].[KCV] WHERE");


            // Index_VISA_SUBCLASS
            builder.Append("[VISA_SUBCLASS] IN (");
            for (int index = 0; index < Index_VISA_SUBCLASS.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // VISA_SUBCLASS
                var parameterVISA_SUBCLASS = $"@p{parameterIndex++}";
                builder.Append(parameterVISA_SUBCLASS);
                command.Parameters.Add(parameterVISA_SUBCLASS, SqlDbType.VarChar, 3).Value = Index_VISA_SUBCLASS[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCV data set</returns>
        public override EduHubDataSetDataReader<KCV> GetDataSetDataReader()
        {
            return new KCVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KCV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KCV data set</returns>
        public override EduHubDataSetDataReader<KCV> GetDataSetDataReader(List<KCV> Entities)
        {
            return new KCVDataReader(new EduHubDataSetLoadedReader<KCV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KCVDataReader : EduHubDataSetDataReader<KCV>
        {
            public KCVDataReader(IEduHubDataSetReader<KCV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // VISA_SUBCLASS
                        return Current.VISA_SUBCLASS;
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 2: // VISA_RESIDENCY
                        return Current.VISA_RESIDENCY;
                    case 3: // SGB_FUNDED
                        return Current.SGB_FUNDED;
                    case 4: // CHECK_STAT_CODE
                        return Current.CHECK_STAT_CODE;
                    case 5: // CHECK_EXPIRY_DATE
                        return Current.CHECK_EXPIRY_DATE;
                    case 6: // CHECK_ISID
                        return Current.CHECK_ISID;
                    case 7: // REFUGEE
                        return Current.REFUGEE;
                    case 8: // LW_DATE
                        return Current.LW_DATE;
                    case 9: // LW_TIME
                        return Current.LW_TIME;
                    case 10: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 2: // VISA_RESIDENCY
                        return Current.VISA_RESIDENCY == null;
                    case 3: // SGB_FUNDED
                        return Current.SGB_FUNDED == null;
                    case 4: // CHECK_STAT_CODE
                        return Current.CHECK_STAT_CODE == null;
                    case 5: // CHECK_EXPIRY_DATE
                        return Current.CHECK_EXPIRY_DATE == null;
                    case 6: // CHECK_ISID
                        return Current.CHECK_ISID == null;
                    case 7: // REFUGEE
                        return Current.REFUGEE == null;
                    case 8: // LW_DATE
                        return Current.LW_DATE == null;
                    case 9: // LW_TIME
                        return Current.LW_TIME == null;
                    case 10: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // VISA_SUBCLASS
                        return "VISA_SUBCLASS";
                    case 1: // DESCRIPTION
                        return "DESCRIPTION";
                    case 2: // VISA_RESIDENCY
                        return "VISA_RESIDENCY";
                    case 3: // SGB_FUNDED
                        return "SGB_FUNDED";
                    case 4: // CHECK_STAT_CODE
                        return "CHECK_STAT_CODE";
                    case 5: // CHECK_EXPIRY_DATE
                        return "CHECK_EXPIRY_DATE";
                    case 6: // CHECK_ISID
                        return "CHECK_ISID";
                    case 7: // REFUGEE
                        return "REFUGEE";
                    case 8: // LW_DATE
                        return "LW_DATE";
                    case 9: // LW_TIME
                        return "LW_TIME";
                    case 10: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "VISA_SUBCLASS":
                        return 0;
                    case "DESCRIPTION":
                        return 1;
                    case "VISA_RESIDENCY":
                        return 2;
                    case "SGB_FUNDED":
                        return 3;
                    case "CHECK_STAT_CODE":
                        return 4;
                    case "CHECK_EXPIRY_DATE":
                        return 5;
                    case "CHECK_ISID":
                        return 6;
                    case "REFUGEE":
                        return 7;
                    case "LW_DATE":
                        return 8;
                    case "LW_TIME":
                        return 9;
                    case "LW_USER":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
