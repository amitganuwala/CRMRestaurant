using System;
using System.Collections.Generic;
using System.Text;
using CRM.Data.Interfaces;
using CRM.Core.Domain.ProductTypes;
using System.Linq;
using CRM.Core.Domain.Options;

namespace CRM.Services.Options
{
    public class OptionServices : IOptionServices
    {
        #region fields     
        private readonly IRepository<Option> _optionRepository;
        #endregion

        #region ctor
        public OptionServices(
           IRepository<Option> optionRepository)
        {
            this._optionRepository = optionRepository;
        }
        #endregion


        /// <summary>-
        /// Delete a Option
        /// </summary>
        /// <param name="Option">Option</param>
        public void DeleteOption(Option option)
        {
            if (option == null)
                throw new ArgumentNullException(nameof(option));

            //productytype.Deleted = true;
            UpdateOption(option);
        }

      
        #region Option
        public IList<Option> GetAllOption(string OptionName = null, string Status = null)
        {
            var query = _optionRepository.Table;

            if (!string.IsNullOrWhiteSpace(OptionName))

                query = from op in _optionRepository.Table
                        orderby op.OptionName
                        select op;

            var Option_list = query.ToList();
            return Option_list;
        }
        #endregion


        /// <summary>-
        /// Update a Option
        /// </summary>
        /// <param name="Option">Option</param>
        public Option GetOptionById(int OptionId)
        {
            if (OptionId == 0)
                return null;

            return _optionRepository.GetById(OptionId);
        }

        public void InsertOption(Option option)
        {
            if (option == null)
                throw new ArgumentNullException(nameof(option));

            _optionRepository.Insert(option);

        }

        /// <summary>-
        /// Update a Option
        /// </summary>
        /// <param name="Option">Option</param>
        public void UpdateOption(Option option)
        {
            if (option == null)
                throw new ArgumentNullException(nameof(option));

            _optionRepository.Update(option);
        }
    }
}
