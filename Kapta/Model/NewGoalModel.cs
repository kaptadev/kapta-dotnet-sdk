using System;

namespace Kapta.Model
{
    /// <summary>
    /// Information about a new goal
    /// </summary>
    public class NewGoalModel
    {
        /// <summary>
        /// The goal's name, which should be five to seven action-oriented words.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The goal's description, which contains detailed information about what it will take to achieve this goal.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date when the goal starts.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The date when the goal is due.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Flag that indicates whether this goal is public or private. Private goals are visible to the user's
        /// manager and above. They are not visible to the user's peer or subordinates.
        /// </summary>
        public bool IsPrivate { get; set; }

        /// <summary>
        /// The ID of the objective to which the efforts of this goal contribute.
        /// </summary>
        public string ObjectiveID { get; set; }
    }
}
