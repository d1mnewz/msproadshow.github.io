﻿namespace RoadShowHardCode.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// The session.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the speeches.
        /// </summary>
        public virtual ICollection<Speech> Speeches { get; set; }
    }
}