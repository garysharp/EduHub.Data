#if !EduHubScoped
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
    /// Archived Census Student Validation Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASVDataSet : EduHubDataSet<SCEN_ASV>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_ASV"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_ASVDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ASV>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ASV" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ASV" /> fields for each CSV column header</returns>
        internal override Action<SCEN_ASV, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ASV, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (int?)null : int.Parse(v);
                        break;
                    case "STKEY":
                        mapper[i] = (e, v) => e.STKEY = v;
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ID_STUDENTVALIDATIONTYPE":
                        mapper[i] = (e, v) => e.ID_STUDENTVALIDATIONTYPE = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "FIELDVALUES":
                        mapper[i] = (e, v) => e.FIELDVALUES = v;
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
        /// Merges <see cref="SCEN_ASV" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_ASV" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_ASV" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_ASV}"/> of entities</returns>
        internal override IEnumerable<SCEN_ASV> ApplyDeltaEntities(IEnumerable<SCEN_ASV> Entities, List<SCEN_ASV> DeltaEntities)
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

        private Lazy<Dictionary<int, SCEN_ASV>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASV FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <param name="Value">Related SCEN_ASV entity</param>
        /// <returns>True if the related SCEN_ASV entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ASV Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASV by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASV</param>
        /// <returns>Related SCEN_ASV entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASV TryFindByID(int ID)
        {
            SCEN_ASV value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_ASV table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ASV]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ASV](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] int NULL,
        [STKEY] varchar(10) NULL,
        [REGISTRATION] smallint NULL,
        [ID_STUDENTVALIDATIONTYPE] smallint NULL,
        [FIELDVALUES] varchar(255) NULL,
        [STATUS] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ASV_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASVDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_ASV"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_ASV"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_ASV> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_ASV] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASV data set</returns>
        public override EduHubDataSetDataReader<SCEN_ASV> GetDataSetDataReader()
        {
            return new SCEN_ASVDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASV data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASV data set</returns>
        public override EduHubDataSetDataReader<SCEN_ASV> GetDataSetDataReader(List<SCEN_ASV> Entities)
        {
            return new SCEN_ASVDataReader(new EduHubDataSetLoadedReader<SCEN_ASV>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ASVDataReader : EduHubDataSetDataReader<SCEN_ASV>
        {
            public SCEN_ASVDataReader(IEduHubDataSetReader<SCEN_ASV> Reader)
                : base (Reader)
            {
            }

            public override int FieldCount { get { return 11; } }

            public override object GetValue(int i)
            {
                switch (i)
                {
                    case 0: // ID
                        return Current.ID;
                    case 1: // ID_RETURN
                        return Current.ID_RETURN;
                    case 2: // STKEY
                        return Current.STKEY;
                    case 3: // REGISTRATION
                        return Current.REGISTRATION;
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return Current.ID_STUDENTVALIDATIONTYPE;
                    case 5: // FIELDVALUES
                        return Current.FIELDVALUES;
                    case 6: // STATUS
                        return Current.STATUS;
                    case 7: // CREATEUSER
                        return Current.CREATEUSER;
                    case 8: // CREATED
                        return Current.CREATED;
                    case 9: // LUPDATEUSER
                        return Current.LUPDATEUSER;
                    case 10: // LUPDATED
                        return Current.LUPDATED;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(i));
                }
            }

            public override bool IsDBNull(int i)
            {
                switch (i)
                {
                    case 1: // ID_RETURN
                        return Current.ID_RETURN == null;
                    case 2: // STKEY
                        return Current.STKEY == null;
                    case 3: // REGISTRATION
                        return Current.REGISTRATION == null;
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return Current.ID_STUDENTVALIDATIONTYPE == null;
                    case 5: // FIELDVALUES
                        return Current.FIELDVALUES == null;
                    case 6: // STATUS
                        return Current.STATUS == null;
                    case 7: // CREATEUSER
                        return Current.CREATEUSER == null;
                    case 8: // CREATED
                        return Current.CREATED == null;
                    case 9: // LUPDATEUSER
                        return Current.LUPDATEUSER == null;
                    case 10: // LUPDATED
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
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // STKEY
                        return "STKEY";
                    case 3: // REGISTRATION
                        return "REGISTRATION";
                    case 4: // ID_STUDENTVALIDATIONTYPE
                        return "ID_STUDENTVALIDATIONTYPE";
                    case 5: // FIELDVALUES
                        return "FIELDVALUES";
                    case 6: // STATUS
                        return "STATUS";
                    case 7: // CREATEUSER
                        return "CREATEUSER";
                    case 8: // CREATED
                        return "CREATED";
                    case 9: // LUPDATEUSER
                        return "LUPDATEUSER";
                    case 10: // LUPDATED
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
                    case "ID_RETURN":
                        return 1;
                    case "STKEY":
                        return 2;
                    case "REGISTRATION":
                        return 3;
                    case "ID_STUDENTVALIDATIONTYPE":
                        return 4;
                    case "FIELDVALUES":
                        return 5;
                    case "STATUS":
                        return 6;
                    case "CREATEUSER":
                        return 7;
                    case "CREATED":
                        return 8;
                    case "LUPDATEUSER":
                        return 9;
                    case "LUPDATED":
                        return 10;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(name));
                }
            }
        }

        #endregion

    }
}
#endif
