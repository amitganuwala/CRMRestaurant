using System;
using System.Collections.Generic;
using System.Text;
using CRM.Core.Domain.Options;

namespace CRM.Services.Options
{
    public partial interface IOptionServices
    {
        IList<Option> GetAllOption(string OptionName = null, string Status = null);

        Option GetOptionById(int OptionId);

        /// <summary>
        /// Insert a Option
        /// </summary>
        /// <param name="Option">Option</param>
        void InsertOption(Option option);

        /// <summary>
        /// Updates the Option
        /// </summary>
        /// <param name="Option">Option</param>
        void UpdateOption(Option option);


        /// <summary>
        /// Delete a Option
        /// </summary>
        /// <param name="Option">Option</param>
        void DeleteOption(Option option);

    }
}
