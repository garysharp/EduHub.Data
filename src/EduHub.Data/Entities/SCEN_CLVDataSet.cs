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
    /// Census Class Sizes Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_CLVDataSet : EduHubDataSet<SCEN_CLV>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_CLV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_CLVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_CLV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_CLV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_CLV" /> fields for each CSV column header</returns>
        internal override Action<SCEN_CLV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_CLV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "CLASSCODE":
                        mapper[i] = (e, v) => e.CLASSCODE = v;
                        break;
                    case "ID_CLASSVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_CLASSVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "STATUS":
                        mapper[i] = (e, v) => e.STATUS = v;
                        break;
                    case "CREATEUSER":
                        mapper[i] = (e, v) => e.CREATEUSER = v;
                        break;
                    case "CREATED":
                        mapper[i] = (e, v) => e.CREATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    case "LUPDATEUSER":
                        mapper[i] = (e, v) => e.LUPDATEUSER = v;
                        break;
                    case "LUPDATED":
                        mapper[i] = (e, v) => e.LUPDATED = v == null ? (DateTime?)null : DateTime.ParseExact(v, "d/MM/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                        break;
                    default:
                        mapper[i] = MapperNoOp;
                        break;
                }
            }

            return mapper;
        }

        /// <summary>
        /// Merges <see cref="SCEN_CLV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_CLV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_CLV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_CLV}"/> of entities</returns>
        internal override IEnumerable<SCEN_CLV> ApplyDeltaEntities(IEnumerable<SCEN_CLV> Entities, List<SCEN_CLV> DeltaEntities)
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

        private Lazy<Dictionary<int, SCEN_CLV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CLV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <param name="Value">Related SCEN_CLV entity</param>
        /// <returns>True if the related SCEN_CLV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_CLV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_CLV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_CLV</param>
        /// <returns>Related SCEN_CLV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_CLV TryFindByID(int ID)
        {
            SCEN_CLV value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_CLV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_CLV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_CLV](
        [ID] int IDENTITY NOT NULL,
        [CLASSCODE] varchar(5) NULL,
        [ID_CLASSVALIDATIONTYPE] smallint NULL,
        [STATUS] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_CLV_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_CLVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_CLVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_CLV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_CLV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_CLV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_CLV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SCEN_CLV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CLV data set</returns>
        public override EduHubDataSetDataReader<SCEN_CLV> GetDataSetDataReader()
        {
            return new SCEN_CLVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_CLV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_CLV data set</returns>
        public override EduHubDataSetDataReader<SCEN_CLV> GetDataSetDataReader(List<SCEN_CLV> Entities)
        {
            return new SCEN_CLVDataReader(new EduHubDataSetLoadedReader<SCEN_CLV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_CLVDataReader : EduHubDataSetDataReader<SCEN_CLV>
        {
            public SCEN_CLVDataReader(IEduHubDataSetReader<SCEN_CLV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 8; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // CLASSCODE
                        return Current.CLASSCODE;
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return Current.ID_CLASSVALIDATIONTYPE;
                    case 3: // STATUS
                        return Current.STATUS;
                    case 4: // CREATEUSER
                        return Current.CREATEUSER;
                    case 5: // CREATED
                        return Current.CREATED;
                    case 6: // LUPDATEUSER
                        return Current.LUPDATEUSER;
                    case 7: // LUPDATED
                        return Current.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // CLASSCODE
                        return Current.CLASSCODE == null;
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return Current.ID_CLASSVALIDATIONTYPE == null;
                    case 3: // STATUS
                        return Current.STATUS == null;
                    case 4: // CREATEUSER
                        return Current.CREATEUSER == null;
                    case 5: // CREATED
                        return Current.CREATED == null;
                    case 6: // LUPDATEUSER
                        return Current.LUPDATEUSER == null;
                    case 7: // LUPDATED
                        return Current.LUPDATED == null;
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
                    case 1: // CLASSCODE
                        return "CLASSCODE";
                    case 2: // ID_CLASSVALIDATIONTYPE
                        return "ID_CLASSVALIDATIONTYPE";
                    case 3: // STATUS
                        return "STATUS";
                    case 4: // CREATEUSER
                        return "CREATEUSER";
                    case 5: // CREATED
                        return "CREATED";
                    case 6: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 7: // LUPDATED
                        return "LUPDATED";
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
                    case "CLASSCODE":
                        return 1;
                    case "ID_CLASSVALIDATIONTYPE":
                        return 2;
                    case "STATUS":
                        return 3;
                    case "CREATEUSER":
                        return 4;
                    case "CREATED":
                        return 5;
                    case "LUPDATEUSER":
                        return 6;
                    case "LUPDATED":
                        return 7;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
