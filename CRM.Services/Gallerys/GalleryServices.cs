using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Gallerys;
using CRM.Data.Interfaces;
using System.Linq;


namespace CRM.Services.Gallerys
{
  public  class GalleryServices:IGalleryServices
    {

        #region fields

        private readonly IRepository<Gallery> _GalleryRepository;

        #endregion


        #region ctor

        public GalleryServices(IRepository<Gallery> galleryRepogitory)
        {
            this._GalleryRepository = galleryRepogitory;
        }

        #endregion



        public Gallery GetGalleryById(int GalleryId)
        {
            if (GalleryId == 0)
                return null;

            return _GalleryRepository.GetById(GalleryId);

        }


        public IList<Gallery> GetAllGallery(byte[] GalleryImage = null, string AltText = null, string Status = null)
        {
            var query = _GalleryRepository.Table;

            if (!string.IsNullOrWhiteSpace(AltText))

                query = from alt in _GalleryRepository.Table
                        orderby alt.AltText
                        select alt;

            var Gallery_list = query.ToList();
            return Gallery_list;

        }

        public void InsertGallery(Gallery gallery)
        {
            if (gallery == null)
                throw new ArgumentNullException(nameof(gallery));

            _GalleryRepository.Insert(gallery);
        }


        public void UpdateGallery(Gallery gallery)
        {
            if (gallery == null)
                throw new ArgumentNullException(nameof(gallery));

            _GalleryRepository.Update(gallery);
        }


        public void DeleteGallery(Gallery gallery)
        {
            if (gallery == null)
                throw new ArgumentNullException(nameof(gallery));

            _GalleryRepository.Delete(gallery);
        }



    }
}
