using Shoppy.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoppy.Catalog.Domain.Brands.Enums;

namespace Shoppy.Catalog.Domain.Brands
{
    public class Brand : AggregateRoot<long>
    {
        #region Constructors

        private Brand()
        {
        }

        public Brand(long id, string name, string number, bool isLuxury, string manufacturerOriginCountry,
            string manufacturerCountry)
        {
            Id = id;
            Name = name;
            Number = number;
            IsLuxury = isLuxury;
            ManufacturerOriginCountry = manufacturerOriginCountry;
            ManufacturerCountry = manufacturerCountry;
            VisibilityState = BrandVisibilityState.Draft;
        }

        #endregion

        #region Peroperties

        /// <summary>
        /// Name of the brand
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Brand Code
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// Brand Level
        /// </summary>
        public bool IsLuxury { get; private set; }

        /// <summary>
        /// Brand origin of country
        /// </summary>
        public string ManufacturerOriginCountry { get; private set; }

        /// <summary>
        /// Brand manufacturer country
        /// </summary>
        public string ManufacturerCountry { get; private set; }

        /// <summary>
        /// Brand visibility state
        /// </summary>
        public BrandVisibilityState VisibilityState { get; private set; }

        /// <summary>
        /// List of categories
        /// </summary>
        public IReadOnlyCollection<ValidCategory> ValidCategories => _validCategories;

        private readonly List<ValidCategory> _validCategories = new();

        #endregion

        #region Public Behaviors

        public void AddCategory(ValidCategory category)
        {
            _validCategories.Add(category);
        }

        public void RemoveCategory(ValidCategory category)
        {
            _validCategories.Remove(category);
        }

        #endregion
    }
}