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
    /// Archived Census Student Excluded Data Data Set
    /// </summary>
    [GeneratedCode("EduHub Data", "0.9")]
    public sealed partial class SCEN_ASEDataSet : EduHubDataSet<SCEN_ASE>
    {
        /// <inheritdoc />
        public override string Name { get { return "SCEN_ASE"; } }

        /// <inheritdoc />
        public override bool SupportsEntityLastModified { get { return false; } }

        internal SCEN_ASEDataSet(EduHubContext Context)
            : base(Context)
        {
            Index_ID = new Lazy<Dictionary<int, SCEN_ASE>>(() => this.ToDictionary(i => i.ID));
        }

        /// <summary>
        /// Matches CSV file headers to actions, used to deserialize <see cref="SCEN_ASE" />
        /// </summary>
        /// <param name="Headers">The CSV column headers</param>
        /// <returns>An array of actions which deserialize <see cref="SCEN_ASE" /> fields for each CSV column header</returns>
        internal override Action<SCEN_ASE, string>[] BuildMapper(IReadOnlyList<string> Headers)
        {
            var mapper = new Action<SCEN_ASE, string>[Headers.Count];

            for (var i = 0; i < Headers.Count; i++) {
                switch (Headers[i]) {
                    case "ID":
                        mapper[i] = (e, v) => e.ID = int.Parse(v);
                        break;
                    case "ID_RETURN":
                        mapper[i] = (e, v) => e.ID_RETURN = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "REGISTRATION":
                        mapper[i] = (e, v) => e.REGISTRATION = v == null ? (short?)null : short.Parse(v);
                        break;
                    case "ASE_TYPE":
                        mapper[i] = (e, v) => e.ASE_TYPE = v;
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
        /// Merges <see cref="SCEN_ASE" /> delta entities
        /// </summary>
        /// <param name="Entities">Iterator for base <see cref="SCEN_ASE" /> entities</param>
        /// <param name="DeltaEntities">List of delta <see cref="SCEN_ASE" /> entities</param>
        /// <returns>A merged <see cref="IEnumerable{SCEN_ASE}"/> of entities</returns>
        internal override IEnumerable<SCEN_ASE> ApplyDeltaEntities(IEnumerable<SCEN_ASE> Entities, List<SCEN_ASE> DeltaEntities)
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

        private Lazy<Dictionary<int, SCEN_ASE>> Index_ID;

        #endregion

        #region Index Methods

        /// <summary>
        /// Find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASE FindByID(int ID)
        {
            return Index_ID.Value[ID];
        }

        /// <summary>
        /// Attempt to find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <param name="Value">Related SCEN_ASE entity</param>
        /// <returns>True if the related SCEN_ASE entity is found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public bool TryFindByID(int ID, out SCEN_ASE Value)
        {
            return Index_ID.Value.TryGetValue(ID, out Value);
        }

        /// <summary>
        /// Attempt to find SCEN_ASE by ID field
        /// </summary>
        /// <param name="ID">ID value used to find SCEN_ASE</param>
        /// <returns>Related SCEN_ASE entity, or null if not found</returns>
        /// <exception cref="ArgumentOutOfRangeException">No match was found</exception>
        public SCEN_ASE TryFindByID(int ID)
        {
            SCEN_ASE value;
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
        /// Returns a <see cref="SqlCommand"/> which checks for the existence of a SCEN_ASE table, and if not found, creates the table and associated indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        public override SqlCommand GetSqlCreateTableCommand(SqlConnection SqlConnection)
        {
            return new SqlCommand(
                connection: SqlConnection,
                cmdText:
@"IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[SCEN_ASE]') AND OBJECTPROPERTY(id, N'IsUserTable') = 1)
BEGIN
    CREATE TABLE [dbo].[SCEN_ASE](
        [ID] int IDENTITY NOT NULL,
        [ID_RETURN] smallint NULL,
        [REGISTRATION] smallint NULL,
        [ASE_TYPE] varchar(1) NULL,
        [CREATEUSER] varchar(128) NULL,
        [CREATED] datetime NULL,
        [LUPDATEUSER] varchar(128) NULL,
        [LUPDATED] datetime NULL,
        CONSTRAINT [SCEN_ASE_Index_ID] PRIMARY KEY CLUSTERED (
            [ID] ASC
        )
    );
END");
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlDisableIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns null as <see cref="SCEN_ASEDataSet"/> has no non-clustered indexes.
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <returns>null</returns>
        public override SqlCommand GetSqlRebuildIndexesCommand(SqlConnection SqlConnection)
        {
            return null;
        }

        /// <summary>
        /// Returns a <see cref="SqlCommand"/> which deletes the <see cref="SCEN_ASE"/> entities passed
        /// </summary>
        /// <param name="SqlConnection">The <see cref="SqlConnection"/> to be associated with the <see cref="SqlCommand"/></param>
        /// <param name="Entities">The <see cref="SCEN_ASE"/> entities to be deleted</param>
        public override SqlCommand GetSqlDeleteCommand(SqlConnection SqlConnection, IEnumerable<SCEN_ASE> Entities)
        {
            SqlCommand command = new SqlCommand();
            int parameterIndex = 0;
            StringBuilder builder = new StringBuilder();

            List<int> Index_ID = new List<int>();

            foreach (var entity in Entities)
            {
                Index_ID.Add(entity.ID);
            }

            builder.AppendLine("DELETE [dbo].[SCEN_ASE] WHERE");


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
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASE data set</returns>
        public override EduHubDataSetDataReader<SCEN_ASE> GetDataSetDataReader()
        {
            return new SCEN_ASEDataReader(Load());
        }

        /// <summary>
        /// Provides a <see cref="IDataReader"/> for the SCEN_ASE data set
        /// </summary>
        /// <returns>A <see cref="IDataReader"/> for the SCEN_ASE data set</returns>
        public override EduHubDataSetDataReader<SCEN_ASE> GetDataSetDataReader(List<SCEN_ASE> Entities)
        {
            return new SCEN_ASEDataReader(new EduHubDataSetLoadedReader<SCEN_ASE>(this, Entities));
        }

        // Modest implementation to primarily support SqlBulkCopy
        private class SCEN_ASEDataReader : EduHubDataSetDataReader<SCEN_ASE>
        {
            public SCEN_ASEDataReader(IEduHubDataSetReader<SCEN_ASE> Reader)
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
                    case 1: // ID_RETURN
                        return Current.ID_RETURN;
                    case 2: // REGISTRATION
                        return Current.REGISTRATION;
                    case 3: // ASE_TYPE
                        return Current.ASE_TYPE;
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
                    case 1: // ID_RETURN
                        return Current.ID_RETURN == null;
                    case 2: // REGISTRATION
                        return Current.REGISTRATION == null;
                    case 3: // ASE_TYPE
                        return Current.ASE_TYPE == null;
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
                    case 1: // ID_RETURN
                        return "ID_RETURN";
                    case 2: // REGISTRATION
                        return "REGISTRATION";
                    case 3: // ASE_TYPE
                        return "ASE_TYPE";
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
                    case "ID_RETURN":
                        return 1;
                    case "REGISTRATION":
                        return 2;
                    case "ASE_TYPE":
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
