using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Core.Domain.Addons
{
    public partial class Addon : BaseEntity
    {
        /// <summary>
        /// Gets or sets the ProductTypeName
        /// </summary>
        public string AddonName { get; set; }

        /// <summary>
        /// Gets or sets the PunchLine
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ProductTypeImage
        /// </summary>
        public byte[] AddonImage { get; set; }

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
