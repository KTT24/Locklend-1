using System.Collections.Generic;

namespace Improbable.Gdk.Core.Editor
{
    /// <summary>
    /// Unity's GUIUtility.GetStateObject changes based on the structure of the GUI, for example when expanding or collapsing foldouts.
    /// Even with hints, tracking the state objects goes awry.
    /// This is a simpler implementation, meant to be used with object hashes generated by the call site, which at least has insight into
    /// what parts of the object will be stable enough to track.
    /// </summary>
    public class UIStateManager
    {
        private readonly Dictionary<int, object> stateObjects = new Dictionary<int, object>();

        /// <summary>
        ///     Attempts to get the state object associated with the hash, else returns a default constructed copy of
        ///     the state object.
        /// </summary>
        /// <remarks>
        ///     If no object is associated with <see cref="hash"/> then a default constructed one is inserted.
        /// </remarks>
        /// <param name="hash">The hash to fetch the state object.</param>
        /// <typeparam name="T">The type of the state object.</typeparam>
        /// <returns>The state object associated with the hash, or a default constructed object of type <see cref="T"/>.</returns>
        public T GetStateObjectOrDefault<T>(int hash) where T : new()
        {
            if (!stateObjects.TryGetValue(hash, out var value))
            {
                value = new T();
                stateObjects.Add(hash, value);
            }

            return (T) value;
        }

        /// <summary>
        ///     Sets the state object for a hash.
        /// </summary>
        /// <param name="hash">The hash to associate the state object with.</param>
        /// <param name="obj">The object to store with the hash.</param>
        /// <typeparam name="T">The type of the state object.</typeparam>
        public void SetStateObject<T>(int hash, T obj)
        {
            stateObjects[hash] = obj;
        }
    }
}
