namespace Kapta.Model
{
    /// <summary>
    /// Basic information about a goal
    /// </summary>
    public class GoalLightModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal GoalLightModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Goal's ID</param>
        /// <param name="name">Goal's name</param>
        public GoalLightModel(string id, string name)
        {
            ID = id;
            Name = name;
        }

        /// <summary>
        /// The goal's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The goal's name, which should be five to seven action-oriented words.
        /// </summary>
        public string Name { get; private set; }
    }
}
