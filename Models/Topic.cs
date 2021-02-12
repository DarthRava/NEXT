using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class Topic
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Topic title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Topic description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Topic creator
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// Topic creation date
        /// </summary>
        public DateTime InsertDate { get; set; }

        /// <summary>
        /// Topic update date
        /// </summary>
        public DateTime UpdateDate { get; set; }
    }
}
