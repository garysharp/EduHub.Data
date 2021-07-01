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
    /// General Ledger Programs Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class KGLPROGDataSet : EduHubDataSet<KGLPROG>
    {
        /// <inheritdoc />
        public override string Name { get { return "KGLPROG"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return true; } }

        internal KGLPROGDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_GLPROGRAM = new Lazy<Dictionary<string, KGLPROG>>(() => this.ToDictionary(i => i.GLPROGRAM));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="KGLPROG" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="KGLPROG" /> fields for each CSV column header</returns>
        internal override Action<KGLPROG, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<KGLPROG, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "GLPROGRAM":
                        mapper[i] = (e, v) => e.GLPROGRAM = v;
                        break;
                    case "TITLE":
                        mapper[i] = (e, v) => e.TITLE = v;
                        break;
                    case "ACTIVE":
                        mapper[i] = (e, v) => e.ACTIVE = v;
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
        /// Merges <see cref="KGLPROG" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="KGLPROG" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="KGLPROG" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{KGLPROG}"/> of entities</returns>
        internal override IEnumerable<KGLPROG> ApplyDeltaEntities(IEnumerable<KGLPROG> Entities, List<KGLPROG> DeltaEntities)
        {
            HashSet<string> Index_GLPROGRAM = new HashSet<string>(DeltaEntities.Select(i => i.GLPROGRAM));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.GLPROGRAM;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_GLPROGRAM.Remove(entity.GLPROGRAM);
                            
                            if (entity.GLPROGRAM.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<string, KGLPROG>> Index_GLPROGRAM;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG FindByGLPROGRAM(string GLPROGRAM)
        {
            return Index_GLPROGRAM.Value[GLPROGRAM];
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <param name="Value">Related KGLPROG entity</param>
        /// <returns>True if the related KGLPROG entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByGLPROGRAM(string GLPROGRAM, out KGLPROG Value)
        {
            return Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out Value);
        }

        /// <summary>
        /// Attempt to find KGLPROG by GLPROGRAM field
        /// </summary>
        /// <param name="GLPROGRAM">GLPROGRAM value used to find KGLPROG</param>
        /// <returns>Related KGLPROG entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public KGLPROG TryFindByGLPROGRAM(string GLPROGRAM)
        {
            KGLPROG value;
            if (Index_GLPROGRAM.Value.TryGetValue(GLPROGRAM, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a KGLPROG table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[KGLPROG]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[KGLPROG](
        [GLPROGRAM] varchar(3) NOT NULL,
        [TITLE] varchar(30) NULL,
        [ACTIVE] varchar(1) NULL,
        [LW_DATE] datetime NULL,
        [LW_TIME] smallint NULL,
        [LW_USER] varchar(128) NULL,
        CONSTRAINT [KGLPROG_Index_GLPROGRAM] PRIMARY KEY CLUSTERED (
            [GLPROGRAM] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="KGLPROGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="KGLPROGDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="KGLPROG"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="KGLPROG"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<KGLPROG> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<string> Index_GLPROGRAM = new List<string>();

            foreach (var entity in Entities)
            {
                Index_GLPROGRAM.Add(entity.GLPROGRAM);
            }

            builder.AppendLine("DELETE [dbo].[KGLPROG] WHERE");


            // Index_GLPROGRAM
            builder.Append("[GLPROGRAM] IN (");
            for (int index = 0; index < Index_GLPROGRAM.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // GLPROGRAM
                var parameterGLPROGRAM = $"@p{parameterIndex++}";
                builder.Append(parameterGLPROGRAM);
                command.Parameters.Add(parameterGLPROGRAM, SqlDbType.VarChar, 3).Value = Index_GLPROGRAM[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLPROG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLPROG data set</returns>
        public override EduHubDataSetDataReader<KGLPROG> GetDataSetDataReader()
        {
            return new KGLPROGDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the KGLPROG data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the KGLPROG data set</returns>
        public override EduHubDataSetDataReader<KGLPROG> GetDataSetDataReader(List<KGLPROG> Entities)
        {
            return new KGLPROGDataReader(new EduHubDataSetLoadedReader<KGLPROG>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class KGLPROGDataReader : EduHubDataSetDataReader<KGLPROG>
        {
            public KGLPROGDataReader(IEduHubDataSetReader<KGLPROG> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 6; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // GLPROGRAM
                        return Current.GLPROGRAM;
                    case 1: // TITLE
                        return Current.TITLE;
                    case 2: // ACTIVE
                        return Current.ACTIVE;
                    case 3: // LW_DATE
                        return Current.LW_DATE;
                    case 4: // LW_TIME
                        return Current.LW_TIME;
                    case 5: // LW_USER
                        return Current.LW_USER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // TITLE
                        return Current.TITLE == null;
                    case 2: // ACTIVE
                        return Current.ACTIVE == null;
                    case 3: // LW_DATE
                        return Current.LW_DATE == null;
                    case 4: // LW_TIME
                        return Current.LW_TIME == null;
                    case 5: // LW_USER
                        return Current.LW_USER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // GLPROGRAM
                        return "GLPROGRAM";
                    case 1: // TITLE
                        return "TITLE";
                    case 2: // ACTIVE
                        return "ACTIVE";
                    case 3: // LW_DATE
                        return "LW_DATE";
                    case 4: // LW_TIME
                        return "LW_TIME";
                    case 5: // LW_USER
                        return "LW_USER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "GLPROGRAM":
                        return 0;
                    case "TITLE":
                        return 1;
                    case "ACTIVE":
                        return 2;
                    case "LW_DATE":
                        return 3;
                    case "LW_TIME":
                        return 4;
                    case "LW_USER":
                        return 5;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
