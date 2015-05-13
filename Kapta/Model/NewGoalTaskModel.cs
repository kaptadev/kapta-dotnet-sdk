using System;

namespace Kapta.Model
{
    /// <summary>
    /// Information about a new task
    /// </summary>
    public class NewGoalTaskModel
    {
        /// <summary>
        /// The text of the task. It describes the action that needs to be taken.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The due date of the task.
        /// </summary>
        public DateTime? DueDate { get; set; }
    }
}
