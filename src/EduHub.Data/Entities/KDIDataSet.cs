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
    /// Victorian Curriculum Strands Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KDIDataSet : EduHubDataSet<KDI>
    {
        /// <inheritdoc />
        public override string Name { get { return "KDI"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KDIDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_KDIKEY = new Lazy<Dictionary<string, KDI>>(() => this.ToDictionary(i => i.KDIKEY));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KDI" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KDI" /> fields for each CSV column header</returns>
        internal override Action<KDI, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KDI, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "KDIKEY":
                        mapper[i] = (e, v) => e.KDIKEY = v;
                        break;
                    case "KDOKEY":
                        mapper[i] = (e, v) => e.KDOKEY = v;
                        break;
                    case "DESCRIPTION":
                        mapper[i] = (e, v) => e.DESCRIPTION = v;
                        break;
                    case "MIN_SCORE":
                        mapper[i] = (e, v) => e.MIN_SCORE = v;
                        break;
                    case "MAX_SCORE":
                        mapper[i] = (e, v) => e.MAX_SCORE = v;
                        break;
                    case "CURRICULUM":
                        mapper[i] = (e, v) => e.CURRICULUM = v;
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
        /// Merges <see cref="KDI" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KDI" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KDI" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KDI}"/> of entities</returns>
        internal override IEnumerable<KDI> ApplyDeltaEntities(IEnumerable<KDI> Entities, List<KDI> DeltaEntities)
        {
            HashSet<string> Index_KDIKEY = new HashSet<string>(DeltaEntities.Select(i => i.KDIKEY));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.KDIKEY;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_KDIKEY.Remove(entity.KDIKEY);
                            
                            if (entity.KDIKEY.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KDI>> Index_KDIKEY;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI FindByKDIKEY(string KDIKEY)
        {
            return Index_KDIKEY.Value[KDIKEY];
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <param name="Value">Related KDI entity</param>
        /// <returns>True if the related KDI entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByKDIKEY(string KDIKEY, out KDI Value)
        {
            return Index_KDIKEY.Value.TryGetValue(KDIKEY, out Value);
        }

        /// <summary>
        /// Attempt to find KDI by KDIKEY field
        /// </summary>
        /// <param name="KDIKEY">KDIKEY value used to find KDI</param>
        /// <returns>Related KDI entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KDI TryFindByKDIKEY(string KDIKEY)
        {
            KDI value;
            if (Index_KDIKEY.Value.TryGetValue(KDIKEY, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KDI table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KDI]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KDI](
        [KDIKEY] varchar(10) NOT NULL,
        [KDOKEY] varchar(10) NULL,
        [DESCRIPTION] varchar(255) NULL,
        [MIN_SCORE] varchar(6) NULL,
        [MAX_SCORE] varchar(6) NULL,
        [CURRICULUM] varchar(7) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KDI_Index_KDIKEY] PRIMARY KEY CLUSTERED (
            [KDIKEY] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KDIDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KDIDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KDI"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KDI"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KDI> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_KDIKEY = new List<string>();

            foreach (var entity in Entities)
            {
                Index_KDIKEY.Add(entity.KDIKEY);
            }

            builder.AppendLine("DELETE [dbo].[KDI] WHERE");


            // Index_KDIKEY
            builder.Append("[KDIKEY] IN (");
            for (int index = 0; index < Index_KDIKEY.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // KDIKEY
                var parameterKDIKEY = $"@p{parameterIndex++}";
                builder.Append(parameterKDIKEY);
                command.Parameters.Add(parameterKDIKEY, SqlDbType.VarChar, 10).Value = Index_KDIKEY[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDI data set</returns>
        public override EduHubDataSetDataReader<KDI> GetDataSetDataReader()
        {
            return new KDIDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KDI data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KDI data set</returns>
        public override EduHubDataSetDataReader<KDI> GetDataSetDataReader(List<KDI> Entities)
        {
            return new KDIDataReader(new EduHubDataSetLoadedReader<KDI>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KDIDataReader : EduHubDataSetDataReader<KDI>
        {
            public KDIDataReader(IEduHubDataSetReader<KDI> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 9; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // KDIKEY
                        return Current.KDIKEY;
                    case 1: // KDOKEY
                        return Current.KDOKEY;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION;
                    case 3: // MIN_SCORE
                        return Current.MIN_SCORE;
                    case 4: // MAX_SCORE
                        return Current.MAX_SCORE;
                    case 5: // CURRICULUM
                        return Current.CURRICULUM;
                    case 6: // LW_DATE
                        return Current.LW_DATE;
                    case 7: // LW_TIME
                        return Current.LW_TIME;
                    case 8: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // KDOKEY
                        return Current.KDOKEY == null;
                    case 2: // DESCRIPTION
                        return Current.DESCRIPTION == null;
                    case 3: // MIN_SCORE
                        return Current.MIN_SCORE == null;
                    case 4: // MAX_SCORE
                        return Current.MAX_SCORE == null;
                    case 5: // CURRICULUM
                        return Current.CURRICULUM == null;
                    case 6: // LW_DATE
                        return Current.LW_DATE == null;
                    case 7: // LW_TIME
                        return Current.LW_TIME == null;
                    case 8: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // KDIKEY
                        return "KDIKEY";
                    case 1: // KDOKEY
                        return "KDOKEY";
                    case 2: // DESCRIPTION
                        return "DESCRIPTION";
                    case 3: // MIN_SCORE
                        return "MIN_SCORE";
                    case 4: // MAX_SCORE
                        return "MAX_SCORE";
                    case 5: // CURRICULUM
                        return "CURRICULUM";
                    case 6: // LW_DATE
                        return "LW_DATE";
                    case 7: // LW_TIME
                        return "LW_TIME";
                    case 8: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "KDIKEY":
                        return 0;
                    case "KDOKEY":
                        return 1;
                    case "DESCRIPTION":
                        return 2;
                    case "MIN_SCORE":
                        return 3;
                    case "MAX_SCORE":
                        return 4;
                    case "CURRICULUM":
                        return 5;
                    case "LW_DATE":
                        return 6;
                    case "LW_TIME":
                        return 7;
                    case "LW_USER":
                        return 8;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
