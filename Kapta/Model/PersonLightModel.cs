namespace Kapta.Model
{
    /// <summary>
    /// Basic information about a person
    /// </summary>
    public class PersonLightModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal PersonLightModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Person's ID</param>
        /// <param name="firstName">Person's first name</param>
        /// <param name="lastName">Person's last name</param>
        public PersonLightModel(string id, string firstName, string lastName)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// The person's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        public string LastName { get; private set; }
    }
}
