namespace Kapta.Model
{
    /// <summary>
    /// Information about a person
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal PersonModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Person's ID</param>
        /// <param name="employeeID">Person's employee ID</param>
        /// <param name="firstName">Person's first name</param>
        /// <param name="lastName">Person's last name</param>
        /// <param name="email">Person's email</param>
        /// <param name="jobTitle">Person's job title</param>
        /// <param name="location">Person's location</param>
        /// <param name="isNew">Flag to indicate whether this is a new user</param>
        /// <param name="team">Person's team</param>
        /// <param name="manager">Person's manager</param>
        public PersonModel(string id, string employeeID, string firstName, string lastName, string email, string jobTitle, string location, bool isNew, TeamModel team, PersonLightModel manager)
        {
            ID = id;
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            JobTitle = jobTitle;
            Location = location;
            IsNew = isNew;
            Team = team;
            Manager = manager;
        }

        /// <summary>
        /// The person's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The unique identifier of the employee as specified
        /// when the person was created.
        /// </summary>
        public string EmployeeID { get; private set; }

        /// <summary>
        /// The person's first name.
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// The person's last name.
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// The person's email address.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// The person's job title.
        /// </summary>
        public string JobTitle { get; private set; }

        /// <summary>
        /// The person's location.
        /// </summary>
        public string Location { get; private set; }

        /// <summary>
        /// True, if the person is a new user. False, otherwise.
        /// </summary>
        public bool IsNew { get; private set; }

        /// <summary>
        /// The person's team.
        /// </summary>
        public TeamModel Team { get; private set; }

        /// <summary>
        /// The person's manager.
        /// </summary>
        public PersonLightModel Manager { get; private set; }
    }
}
