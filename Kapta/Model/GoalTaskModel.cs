using System;

namespace Kapta.Model
{
    /// <summary>
    /// Information about a goal's task.
    /// </summary>
    public class GoalTaskModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal GoalTaskModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Task's ID</param>
        /// <param name="text">Task's text</param>
        /// <param name="dueDate">Task's due date</param>
        /// <param name="isCompleted">Flag to indicate whether the task has been completed</param>
        /// <param name="goal">Goal to which the task is associated</param>
        public GoalTaskModel(string id, string text, DateTime? dueDate, bool isCompleted, GoalLightModel goal)
        {
            ID = id;
            Text = text;
            DueDate = dueDate;
            IsCompleted = isCompleted;
            Goal = goal;
        }

        /// <summary>
        /// The task's ID.
        /// </summary>
        public string ID { get; private set; }

        /// <summary>
        /// The text of the task. It describes the action that needs to be taken.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// The due date of the task.
        /// </summary>
        public DateTime? DueDate { get; private set; }

        /// <summary>
        /// Flag that indicates whether this task has been completed.
        /// </summary>
        public bool IsCompleted { get; private set; }

        /// <summary>
        /// The goal to which the task is associated.
        /// </summary>
        public GoalLightModel Goal { get; private set; }
    }
}
