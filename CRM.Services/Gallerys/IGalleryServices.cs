using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Gallerys;

namespace CRM.Services.Gallerys
{
  public partial interface IGalleryServices
    {
        IList<Gallery> GetAllGallery(byte[] GalleryImage=null,string AltText=null,string Status=null);

        Gallery GetGalleryById(int GalleryId);


        /// <summary>
        /// Insert a Gallery
        /// </summary>
        /// <param name="Gallery">Gallery</param>
        void InsertGallery(Gallery gallery);

        /// <summary>
        /// Updates the Gallery
        /// </summary>
        /// <param name="Gallery">Gallery</param>
        void UpdateGallery(Gallery gallery);


        /// <summary>
        /// Delete a Gallery
        /// </summary>
        /// <param name="Gallery">Gallery</param>
        void DeleteGallery(Gallery gallery);
    }
}
