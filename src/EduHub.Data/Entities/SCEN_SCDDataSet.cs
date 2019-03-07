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
    /// Column-Display Metadata for displaying Student Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_SCDDataSet : EduHubDataSet<SCEN_SCD>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_SCD"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_SCDDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_SCD>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_SCD" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_SCD" /> fields for each CSV column header</returns>
        internal override Action<SCEN_SCD, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_SCD, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "COLUMNNAME":
                        mapper[i] = (e, v) => e.COLUMNNAME = v;
                        break;
                    case "COLUMNDISPLAYNAME":
                        mapper[i] = (e, v) => e.COLUMNDISPLAYNAME = v;
                        break;
                    case "DEFAULTCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.DEFAULTCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYWIDTH":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYWIDTH = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "PREFERREDCOLUMNDISPLAYORDER":
                        mapper[i] = (e, v) => e.PREFERREDCOLUMNDISPLAYORDER = v == null ? (short?)null : short.Parse(v);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_SCD" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_SCD" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_SCD" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_SCD}"/> of entities</returns>
        internal override IEnumerable<SCEN_SCD> ApplyDeltaEntities(IEnumerable<SCEN_SCD> Entities, List<SCEN_SCD> DeltaEntities)
        {
            HashSet<int> Index_ID = new HashSet<int>(DeltaEntities.Select(i => i.ID));

            using (var deltaIterator = DeltaEntities.GetEnumerator())
            {
                using (var entityIterator = Entities.GetEnumerator())
                {
                    while (deltaIterator.MoveNext())
                    {
                        var deltaClusteredKey = deltaIterator.Current.ID;
                        bool yieldEntity = false;

                        while (entityIterator.MoveNext())
                        {
                            var entity = entityIterator.Current;

                            bool overwritten = Index_ID.Remove(entity.ID);
                            
                            if (entity.ID.CompareTo(deltaClusteredKey) <= 0)
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

        private Lazy<Dictionary<int, SCEN_SCD>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <param name="Value">Related SCEN_SCD entity</param>
        /// <returns>True if the related SCEN_SCD entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_SCD Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_SCD by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_SCD</param>
        /// <returns>Related SCEN_SCD entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_SCD TryFindByID(int ID)
        {
            SCEN_SCD value;
            if (Index_ID.Value.TryGetValue(ID, out value))
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_SCD table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_SCD]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_SCD](
        [ID] int IDENTITY NOT NULL,
        [COLUMNNAME] varchar(255) NULL,
        [COLUMNDISPLAYNAME] varchar(255) NULL,
        [DEFAULTCOLUMNDISPLAYWIDTH] smallint NULL,
        [DEFAULTCOLUMNDISPLAYORDER] smallint NULL,
        [PREFERREDCOLUMNDISPLAYWIDTH] smallint NULL,
        [PREFERREDCOLUMNDISPLAYORDER] smallint NULL,
        CONSTRAINT [SCEN_SCD_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_SCDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_SCDDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_SCD"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_SCD"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_SCD> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_SCD] WHERE");


            // Index_ID
            builder.Append("[ID] IN (");
            for (int index = 0; index < Index_ID.Count; index++)
            {
                if (index != 0)
                    builder.Append(", ");

                // ID
                var parameterID = $"@p{parameterIndex++}";
                builder.Append(parameterID);
                command.Parameters.Add(parameterID, SqlDbType.Int).Value = Index_ID[index];
            }
            builder.Append(");");

            command.Connection = SqlConnection;
            command.CommandText = builder.ToString();

            return command;
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_SCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_SCD data set</returns>
        public override EduHubDataSetDataReader<SCEN_SCD> GetDataSetDataReader()
        {
            return new SCEN_SCDDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_SCD data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_SCD data set</returns>
        public override EduHubDataSetDataReader<SCEN_SCD> GetDataSetDataReader(List<SCEN_SCD> Entities)
        {
            return new SCEN_SCDDataReader(new EduHubDataSetLoadedReader<SCEN_SCD>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_SCDDataReader : EduHubDataSetDataReader<SCEN_SCD>
        {
            public SCEN_SCDDataReader(IEduHubDataSetReader<SCEN_SCD> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 7; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // COLUMNNAME
                        return Current.COLUMNNAME;
                    case 2: // COLUMNDISPLAYNAME
                        return Current.COLUMNDISPLAYNAME;
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return Current.DEFAULTCOLUMNDISPLAYWIDTH;
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return Current.DEFAULTCOLUMNDISPLAYORDER;
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return Current.PREFERREDCOLUMNDISPLAYWIDTH;
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return Current.PREFERREDCOLUMNDISPLAYORDER;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // COLUMNNAME
                        return Current.COLUMNNAME == null;
                    case 2: // COLUMNDISPLAYNAME
                        return Current.COLUMNDISPLAYNAME == null;
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return Current.DEFAULTCOLUMNDISPLAYWIDTH == null;
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return Current.DEFAULTCOLUMNDISPLAYORDER == null;
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return Current.PREFERREDCOLUMNDISPLAYWIDTH == null;
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return Current.PREFERREDCOLUMNDISPLAYORDER == null;
                    default:
                        return false;
                }
            }

            public override string GetName(int ordinal)
            {
                switch (ordinal)
                {
                    case 0: // ID
                        return "ID";
                    case 1: // COLUMNNAME
                        return "COLUMNNAME";
                    case 2: // COLUMNDISPLAYNAME
                        return "COLUMNDISPLAYNAME";
                    case 3: // DEFAULTCOLUMNDISPLAYWIDTH
                        return "DEFAULTCOLUMNDISPLAYWIDTH";
                    case 4: // DEFAULTCOLUMNDISPLAYORDER
                        return "DEFAULTCOLUMNDISPLAYORDER";
                    case 5: // PREFERREDCOLUMNDISPLAYWIDTH
                        return "PREFERREDCOLUMNDISPLAYWIDTH";
                    case 6: // PREFERREDCOLUMNDISPLAYORDER
                        return "PREFERREDCOLUMNDISPLAYORDER";
                    default:
                        throw new ArgumentOutOfRangeException(nameof(ordinal));
                }
            }

            public override int GetOrdinal(string name)
            {
                switch (name)
                {
                    case "ID":
                        return 0;
                    case "COLUMNNAME":
                        return 1;
                    case "COLUMNDISPLAYNAME":
                        return 2;
                    case "DEFAULTCOLUMNDISPLAYWIDTH":
                        return 3;
                    case "DEFAULTCOLUMNDISPLAYORDER":
                        return 4;
                    case "PREFERREDCOLUMNDISPLAYWIDTH":
                        return 5;
                    case "PREFERREDCOLUMNDISPLAYORDER":
                        return 6;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
