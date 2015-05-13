using System;

namespace Kapta.Model
{
    /// <summary>
    /// Information about a goal
    /// </summary>
    public class GoalModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal GoalModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Goal's ID</param>
        /// <param name="name">Goal's name</param>
        /// <param name="description">Goal's description</param>
        /// <param name="startDate">Goal's start date</param>
        /// <param name="dueDate">Goal's due date</param>
        /// <param name="endDate">Goal's end date</param>
        /// <param name="state">Goal's current state</param>
        /// <param name="status">Goal's current status</param>
        /// <param name="percentageComplete">Goal's current percentage complete</param>
        /// <param name="isPrivate">Flag that indicates whether this goal is public or private</param>
        /// <param name="assignedTo">The person to which the goal is assigned</param>
        /// <param name="objective">The objective to which the efforts of this goal contribute</param>
        public GoalModel(string id, string name, string description, DateTime startDate, DateTime dueDate, DateTime endDate, string state, string status, int percentageComplete, bool isPrivate, 
            PersonLightModel assignedTo, ObjectiveLightModel objective)
        {
            ID = id;
            Name = name;
            Description = description;
            StartDate = startDate;
            DueDate = dueDate;
            EndDate = endDate;
            State = state;
            Status = status;
            PercentageComplete = percentageComplete;
            IsPrivate = isPrivate;
            AssignedTo = assignedTo;
            Objective = objective;
        }

        /// <summary>
        /// The goal's unique identifier.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The goal's name, which should be five to seven action-oriented words.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The goal's description, which contains detailed information about what it will take to achieve this goal.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// The date when the goal starts.
        /// </summary>
        public DateTime StartDate { get; private set; }

        /// <summary>
        /// The date when the goal is due.
        /// </summary>
        public DateTime DueDate { get; private set; }

        /// <summary>
        /// The date when the goal was completed.
        /// </summary>
        public DateTime? EndDate { get; private set; }

        /// <summary>
        /// The state of the goal (e.g., Upcoming, Completed).
        /// </summary>
        public string State { get; private set; }

        /// <summary>
        /// The status of the goal (e.g., On Track, In Caution).
        /// </summary>
        public string Status { get; private set; }

        /// <summary>
        /// The percentage of the goal that is complete.
        /// </summary>
        public int PercentageComplete { get; private set; }

        /// <summary>
        /// Flag that indicates whether this goal is public or private. Private goals are visible to the user's
        /// manager and above. They are not visible to the user's peer or subordinates.
        /// </summary>
        public bool IsPrivate { get; private set; }

        /// <summary>
        /// The person to which the goal is assigned.
        /// </summary>
        public PersonLightModel AssignedTo { get; private set; }

        /// <summary>
        /// The objective to which the efforts of this goal contribute.
        /// </summary>
        public ObjectiveLightModel Objective { get; private set; }
    }
}
