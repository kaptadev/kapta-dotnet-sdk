namespace Kapta.Model
{
    /// <summary>
    /// Information about a team
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal TeamModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Team's ID</param>
        /// <param name="name">Team's name</param>
        public TeamModel(string id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// The team's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The team's name.
        /// </summary>
        public string Name { get; private set; }
    }
}
