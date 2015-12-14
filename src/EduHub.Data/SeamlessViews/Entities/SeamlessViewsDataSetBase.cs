using System;
using System.Collections;
using System.Collections.Generic;

namespace EduHub.Data.SeamlessViews.Entities
{
    /// <summary>
    /// Base Data Set for Seamless Views Entities
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class SeamlessViewsDataSetBase<T> : IReadOnlyList<T> where T : SeamlessViewsEntityBase
    {
        /// <summary>
        /// Seamless Views Context
        /// </summary>
        protected readonly SeamlessViewsContext Context;

        private Lazy<List<T>> Items;

        internal SeamlessViewsDataSetBase(SeamlessViewsContext Context)
        {
            this.Context = Context;
            Items = new Lazy<List<T>>(Load);
        }

        /// <summary>
        /// Responsible for loading the data set entities
        /// </summary>
        /// <returns>The list of entities for this data set</returns>
        protected abstract List<T> Load();

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
        /// Gets the number of entities in the data set.
        /// </summary>
        /// <returns>The number of entities in the data set.</returns>
        public int Count
        {
            get
            {
                return Items.Value.Count;
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
    }
}
