using CRM.Core.Domain.Addons;
using System;
using System.Collections.Generic;
using System.Text;


namespace CRM.Services.Addons
{
    public partial interface IAddonServices
    {
        IList<Addon> GetAllAddons(string Addonname = null, string Price = null, string Description = null, byte[] AddonImage = null, string Status = null);

        Addon GetAddonById(int AddonId);

        /// <summary>
        /// Insert a Addon
        /// </summary>
        /// <param name="Addon">Addon</param>
        void InsertAddon(Addon addon);

        /// <summary>
        /// Updates the Addon
        /// </summary>
        /// <param name="Addon">Addon</param>
        void UpdateAddon(Addon addon);


        /// <summary>
        /// Delete a Addon
        /// </summary>
        /// <param name="Addon">addon</param>
        void DeleteAddon(Addon addon);
    }

}
