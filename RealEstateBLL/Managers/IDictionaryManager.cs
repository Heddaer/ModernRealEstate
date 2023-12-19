// Author: Hedda Eriksson
// Date: 2023-28-09 
// Malmö University, Bachelor of Engineering - Computer Science & Telecommunications
// info: Inteface for dictionaryManager
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateBLL.Managers
{
    public interface IDictionaryManager<Tkey, Tvalue>
    {
        #region All method definitions
        /// <summary>
        /// Return the number of items in the dictionary.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add an object to the dictionary.
        /// </summary>
        /// <param name="key">key of a type.</param>
        ///  /// <param name="value">value of a type.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool Add(Tkey key, Tvalue value);

        /// <summary>
        /// Removes the value from the dictionary with specified key.
        /// </summary>
        /// <param name="key">key to value that is to be removed.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool DeleteAt(Tkey key, out string errorMsg);

        /// <summary>
        /// Removes all keys and values from the dictionary.
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Determines if the key exist in the dictionary.
        /// </summary>
        /// <param name="key">key to value that is to be removed.</param>
        /// <returns>True if successful, false otherwise.</returns>
        bool CheckKey(Tkey key);

        /// <summary>
        /// Return a value that belongs to given key. 
        /// </summary>
        /// <param name="key">key to value that is to be removed.</param>
        /// <returns>True if successful, false otherwise.</returns>
        Tvalue GetAt(Tkey key);
        #endregion
    }
}
