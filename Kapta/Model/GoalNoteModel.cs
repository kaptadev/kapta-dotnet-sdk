using System;

namespace Kapta.Model
{
    /// <summary>
    /// Information about a goal note
    /// </summary>
    public class GoalNoteModel
    {
        /// <summary>
        /// Initialize
        /// </summary>
        internal GoalNoteModel() { }

        /// <summary>
        /// Initialize with all values
        /// </summary>
        /// <param name="id">Note's ID</param>
        /// <param name="text">Note's text</param>
        /// <param name="dateCreated">Date when the note was created</param>
        /// <param name="author">Person who authored the note</param>
        /// <param name="goal">Goal to which the note is associated</param>
        public GoalNoteModel(int id, string text, DateTime dateCreated, PersonLightModel author, GoalLightModel goal)
        {
            ID = id;
            Text = text;
            DateCreated = dateCreated;
            Author = author;
            Goal = goal;
        }

        /// <summary>
        /// The goal note's unique identifier.
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// The text of the note.
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// The date the note was created.
        /// </summary>
        public DateTime DateCreated { get; private set; }

        /// <summary>
        /// The person who wrote the note.
        /// </summary>
        public PersonLightModel Author { get; private set; }

        /// <summary>
        /// The goal to which the note is associated.
        /// </summary>
        public GoalLightModel Goal { get; private set; }
    }
}
