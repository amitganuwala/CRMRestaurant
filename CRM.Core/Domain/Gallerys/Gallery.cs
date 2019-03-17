using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Core.Domain.Gallerys
{
    public partial class Gallery : BaseEntity
    {
        /// <summary>
        /// Gets or sets the GalleryImage
        /// </summary>
        public byte[] GalleryImage { get; set; }
             
        /// <summary>
        /// Gets or sets the AltText
        /// </summary>
        public string AltText { get; set; }

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
