using System;
using System.Collections.Generic;

namespace DotNetCoreAPI
{
#pragma warning disable S1200
    /// <summary>
    /// Commercial Operation Class
    /// </summary>
    public class CommercialOperation
    {
        /// <summary>
        /// Gets or sets the commercial operation identifier.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the commercial operation start date.
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation end date.
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation name and ID.
        /// </summary>
        public string NameWithId { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Description.
        /// </summary>
        public string Description { get; set; }

              /// <summary>
        ///  Gets or sets the commercial operation Rules Url.
        /// </summary>
        public Uri RulesUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Icon Url.
        /// </summary>
        public Uri IconUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Special Page URL .
        /// </summary>
        public Uri SpecialePageUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation FlagUrl.
        /// </summary>
        public Uri FlagUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation FlagId.
        /// </summary>
        public int? FlagId { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Banner Url.
        /// </summary>
        public Uri BannerUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Banner Url (full width).
        /// </summary>
        public Uri BannerFullUrl { get; set; }

        /// <summary>
        /// Gets or sets the smartphone commercial operation banner url.
        /// </summary>
        public Uri SmartphoneProductBannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the smartphone text associated to the smartphone Banner.
        /// </summary>
        public string SmartphoneBannerText { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation GenBoa.
        /// </summary>
        public bool? GenBoa { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation NbBOA.
        /// </summary>
        public int? NbBoa { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation GenMail.
        /// </summary>
        public bool? GenMail { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation MinNbProducts.
        /// </summary>
        public int? MinNbProducts { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Percentage.
        /// </summary>
        public decimal? Percentage { get; set; }

        /// <summary>
        ///  Gets or sets the AbsoluteRefund
        /// </summary>
        public decimal? AbsoluteRefund { get; set; }

        /// <summary>
        ///  Gets or sets the StartRegistrationDate
        /// </summary>
        public DateTimeOffset? StartRegistrationDate { get; set; }

        /// <summary>
        ///  Gets or sets the EndRegistrationDate
        /// </summary>
        public DateTimeOffset? EndRegistrationDate { get; set; }

        /// <summary>
        ///  Gets or sets the BOAMinAmountForUse
        /// </summary>
        public decimal? BOAMinAmountForUse { get; set; }

        /// <summary>
        ///  Gets or sets the AreBOACumulative
        /// </summary>
        public bool? AreBOACumulative { get; set; }

        /// <summary>
        ///  Gets or sets the NBDayBOAValidity
        /// </summary>
        public int? NBDayBOAValidity { get; set; }

        /// <summary>
        ///  Gets or sets the StartDateBOAValidity
        /// </summary>
        public DateTimeOffset? StartDateBOAValidity { get; set; }

        /// <summary>
        ///  Gets or sets the EndDateBOAValidity
        /// </summary>
        public DateTimeOffset? EndDateBOAValidity { get; set; }

        /// <summary>
        /// Gets or sets the IsAllStoreEligible
        /// </summary>
        public bool? IsAllStoreEligible { get; set; }

        /// <summary>
        /// Gets or sets the IsActive
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        ///  Gets or sets the siteId and the catalogid impacted by the operation
        /// </summary>
        public IReadOnlyCollection<SiteCatalog> SiteCatalog { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation PictureTemplateValidatedUrl.
        /// </summary>
        public Uri PictureTemplateValidatedUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation PictureTemplateUnValidatedUrl.
        /// </summary>
        public Uri PictureTemplateUnValidatedUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation PictureTemplateUnValidatedUrl.
        /// </summary> 
        public int PromotionId { get; set; }

        /// <summary>
        /// Gets or set the quantity of scopus eligible for an operation
        /// </summary>
        public int EligibleScopusQuantity { get; set; }

        /// <summary>
        /// Gets or set the maximum vouchers value estimated
        /// </summary>
        public int MaximumVouchersValueEstimated { get; set; }

        /// <summary>
        /// Gets or set the real Vouchers Value generated
        /// </summary>
        public int RealVouchersValueGenerated { get; set; }      
    }
#pragma warning disable S1200
}
