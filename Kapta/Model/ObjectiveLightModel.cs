namespace Kapta.Model
{
    /// <summary>
    /// Basic information about an objective
    /// </summary>
    public class ObjectiveLightModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal ObjectiveLightModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Objective's ID</param>
        /// <param name="name">Objective's name</param>
        public ObjectiveLightModel(string id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// The objective's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The objective's name.
        /// </summary>
        public string Name { get; private set; }
    }
}
