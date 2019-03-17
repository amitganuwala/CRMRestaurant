using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Addons;
using CRM.Data.Interfaces;
using System.Linq;

namespace CRM.Services.Addons
{
    public class AddonServices : IAddonServices   
    {
        #region fields     
        private readonly IRepository<Addon> _AddonRepository;
        #endregion

        #region ctor
        public AddonServices(
           IRepository<Addon> addonRepository)
        {
            this._AddonRepository = addonRepository;
        }

        public void DeleteAddon(Addon addon)
        {
            if (addon == null)
                throw new ArgumentNullException(nameof(addon));

            //productytype.Deleted = true;
            UpdateAddon(addon);

        }

        public Addon GetAddonById(int AddonId)
        {
            if (AddonId == 0)
                return null;

            return _AddonRepository.GetById(AddonId);
        }

        public IList<Addon> GetAllAddons(string Addonname = null, string Price = null, string Description = null, byte[] AddonImage = null, string Status = null)
        {
            var query = _AddonRepository.Table;

            if (!string.IsNullOrWhiteSpace(Addonname))

                query = from adn in _AddonRepository.Table
                        orderby adn.AddonName
                        select adn;

            var ProductType_list = query.ToList();
            return ProductType_list;
        }

        public void InsertAddon(Addon addon)
        {
            if (addon == null)
                throw new ArgumentNullException(nameof(addon));

            _AddonRepository.Insert(addon);

        }

        public void UpdateAddon(Addon addon)
        {
            if (addon == null)
                throw new ArgumentNullException(nameof(addon));

            _AddonRepository.Update(addon);
        }
        #endregion
        

    }
}
