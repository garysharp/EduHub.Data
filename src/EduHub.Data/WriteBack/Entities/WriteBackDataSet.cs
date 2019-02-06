using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EduHub.Data.WriteBack.Entities
{
    /// <summary>
    /// Base Data Set for Write-Back Entities
    /// </summary>
    /// <typeparam name="T">A Write-Back Entity derived from <see cref="WriteBackEntity"/></typeparam>
    public abstract class WriteBackDataSet<T> : IWriteBackDataSet, IReadOnlyList<T> where T : WriteBackEntity
    {
        /// <summary>
        /// Write-Back Context
        /// </summary>
        protected readonly WriteBackContext Context;

        /// <summary>
        /// Write-Back Records
        /// </summary>
        protected readonly Lazy<List<T>> Items;

        internal WriteBackDataSet(WriteBackContext Context)
        {
            this.Context = Context;
            Items = new Lazy<List<T>>(Load);
        }

        /// <inheritdoc />
        public abstract string Name { get; }

        /// <inheritdoc />
        public abstract string Description { get; }

        /// <inheritdoc />
        public string Filename => Path.Combine(Context.WriteBackDirectory, $"{Context.EduHubContext.EduHubSiteIdentifier}_{Name}.CSV");

        /// <inheritdoc />
        public bool IsPresent => File.Exists(Filename);

        /// <inheritdoc />
        public DateTime? Age => IsPresent ? File.GetCreationTime(Filename) : (DateTime?)null;

        /// <summary>
        /// Responsible for loading the current write-back dataset
        /// </summary>
        protected abstract List<T> Load();

        /// <inheritdoc />
        public IWriteBackResponse LatestResponse => WriteBackResponse.Create(Context, this);

        /// <inheritdoc />
        public bool IsReadOnly { get { return true; } }

        /// <inheritdoc />
        public bool IsFixedSize { get { return true; } }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public object SyncRoot { get { throw new NotSupportedException("The data set is read-only"); } }

        /// <inheritdoc />
        public bool IsSynchronized { get { return true; } }

        /// <inheritdoc />
        public int Count
        {
            get
            {
                return Items.Value.Count;
            }
        }

        /// <summary>
        /// Gets the Seamless Views entity at the specified index in the data set.
        /// </summary>
        /// <param name="index">The zero-based index of the entity to get.</param>
        /// <returns>The entity at the specified index in the data set.</returns>
        public T this[int index]
        {
            get
            {
                return Items.Value[index];
            }
        }

        /// <summary>
        /// Gets the Seamless Views entity at the specified index in the data set.
        /// </summary>
        /// <param name="index">The zero-based index of the entity to get.</param>
        /// <returns>The entity at the specified index in the data set.</returns>
        object IList.this[int index]
        {
            get
            {
                return Items.Value[index];
            }
            set
            {
                throw new NotSupportedException("The data set is read-only");
            }
        }

        /// <summary>
        /// Returns an enumerator that iterates through the data set.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the data set.</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a data set.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/> object that can be used to iterate through the data set.</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return Items.Value.GetEnumerator();
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public int Add(object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <inheritdoc />
        public bool Contains(object value)
        {
            T entity = value as T;
            if (entity != null)
            {
                return Items.Value.Contains(entity);
            }
            return false;
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Clear()
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <inheritdoc />
        public int IndexOf(object value)
        {
            T entity = value as T;
            if (entity != null)
            {
                return Items.Value.IndexOf(entity);
            }
            return -1;
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Insert(int index, object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void Remove(object value)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported. All eduHub data sets are read-only.
        /// </summary>
        public void RemoveAt(int index)
        {
            throw new NotSupportedException("The data set is read-only");
        }

        /// <summary>
        /// Not Supported.
        /// </summary>
        public void CopyTo(Array array, int index)
        {
            throw new NotSupportedException();
        }
    }
}
