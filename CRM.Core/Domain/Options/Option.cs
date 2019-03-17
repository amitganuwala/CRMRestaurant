using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Core.Domain.Options
{
    public partial class Option : BaseEntity
    {

        /// <summary>
        /// Gets or sets the OptionName
        /// </summary>
        public string OptionName { get; set; }
               
        /// <summary>
        /// Gets or sets the Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the entity has been deleted
        /// </summary>
        public bool Deleted { get; set; }

    }
}
