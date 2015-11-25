using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EduHub.Data
{
    internal class NullDictionary<TKey, TValue>
            : IDictionary<TKey, TValue>
    {
        private bool nullValueSet = false;
        private TValue nullValue;
        private Dictionary<TKey, TValue> dictionary;

        public NullDictionary()
        {
            dictionary = new Dictionary<TKey, TValue>();
        }

        public TValue this[TKey key]
        {
            get
            {
                if (key == null)
                {
                    if (nullValueSet)
                    {
                        return nullValue;
                    }
                    else
                    {
                        throw new KeyNotFoundException();
                    }
                }

                return dictionary[key];
            }
            set
            {
                if (key == null)
                {
                    nullValue = value;
                    nullValueSet = true;
                }
                else
                {
                    dictionary[key] = value;
                }
            }
        }

        public int Count
        {
            get
            {
                if (nullValueSet)
                {
                    return dictionary.Count + 1;
                }
                else
                {
                    return dictionary.Count;
                }
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public ICollection<TKey> Keys
        {
            get
            {
                if (nullValueSet)
                {
                    var keys = new List<TKey>(dictionary.Count + 1);
                    keys.Add(default(TKey));
                    keys.AddRange(dictionary.Keys);
                    return keys;
                }
                else
                {
                    return dictionary.Keys;
                }
            }
        }

        public ICollection<TValue> Values
        {
            get
            {
                if (nullValueSet)
                {
                    var values = new List<TValue>(dictionary.Count + 1);
                    values.Add(nullValue);
                    values.AddRange(dictionary.Values);
                    return values;
                }
                else
                {
                    return dictionary.Values;
                }
            }
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            Add(item.Key, item.Value);
        }

        public void Add(TKey key, TValue value)
        {
            if (key == null)
            {
                if (nullValueSet)
                {
                    throw new ArgumentException("An item with the same key has already been added.");
                }
                else
                {
                    nullValue = value;
                    nullValueSet = true;
                }
            }
            else
            {
                dictionary.Add(key, value);
            }
        }

        public void Clear()
        {
            dictionary.Clear();
            nullValue = default(TValue);
            nullValueSet = false;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            if (item.Key == null)
            {
                if (nullValueSet)
                {
                    return EqualityComparer<TValue>.Default.Equals(nullValue, item.Value);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return dictionary.Contains(item);
            }
        }

        public bool ContainsKey(TKey key)
        {
            if (key == null)
            {
                return nullValueSet;
            }
            else
            {
                return dictionary.ContainsKey(key);
            }
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(TKey key)
        {
            if (key == null)
            {
                if (nullValueSet)
                {
                    nullValue = default(TValue);
                    nullValueSet = false;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return dictionary.Remove(key);
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (key == null)
            {
                if (nullValueSet)
                {
                    value = nullValue;
                    return true;
                }
                else
                {
                    value = default(TValue);
                    return false;
                }
            }
            else
            {
                return dictionary.TryGetValue(key, out value);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
