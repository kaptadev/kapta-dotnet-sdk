using Kapta.Client;

namespace Kapta
{
    /// <summary>
    /// Client for accessing the Kapta API
    /// </summary>
    public class KaptaClient : IKaptaClient
    {
        private IPersonsClient m_persons;
        private IObjectivesClient m_objectives;
        private IGoalsClient m_goals;
        private IGoalNotesClient m_goalNotes;
        private IGoalTasksClient m_goalTasks;

        /// <summary>
        /// Provides access to persons
        /// </summary>
        public IPersonsClient Persons
        {
            get
            {
                if (m_persons == null)
                    m_persons = new PersonsClient();

                return m_persons;
            }
        }

        /// <summary>
        /// Provides access to objectives
        /// </summary>
        public IObjectivesClient Objectives
        {
            get
            {
                if (m_objectives == null)
                    m_objectives = new ObjectivesClient();

                return m_objectives;
            }
        }

        /// <summary>
        /// Provides access to goals
        /// </summary>
        public IGoalsClient Goals
        {
            get
            {
                if (m_goals == null)
                    m_goals = new GoalsClient();

                return m_goals;
            }
        }

        /// <summary>
        /// Provides access to goal notes
        /// </summary>
        public IGoalNotesClient GoalNotes
        {
            get
            {
                if (m_goalNotes == null)
                    m_goalNotes = new GoalNotesClient();

                return m_goalNotes;
            }
        }

        /// <summary>
        /// Provides access to goal tasks
        /// </summary>
        public IGoalTasksClient GoalTasks
        {
            get
            {
                if (m_goalTasks == null)
                    m_goalTasks = new GoalTasksClient();

                return m_goalTasks;
            }
        }
    }
}
