using System;
using System.Collections.Generic;

namespace DotNetCoreAPI
{
    /// <summary>
    /// Commercial Operation Create Request
    /// </summary>
    public class CommercialOperationCreateRequest
    {
        /// <summary>
        ///  Gets or sets the commercial operation name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the commercial operation start date.
        /// </summary>
        public DateTimeOffset StartDate { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation end date.
        /// </summary>
        public DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Gets or sets the commercial operation type.
        /// </summary>
        public CommercialOperationTypeEnum OperationType { get; set; }

        /// <summary>
        /// Gets or sets the Priority
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Commercial Campaign
        /// </summary>
        public CommercialCampaign Campaign { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the Comments
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Extended property list
        /// </summary>
        public IReadOnlyDictionary<CommercialOperationExtendedPropertyType, string> ExtendedPropertyList { get; set; }

        /// <summary>
        /// Gets or sets if marketplace enabled
        /// </summary>
        public bool IsMkpEnabled { get; set; }

        /// <summary>
        /// Boolean used to define, in the case of a mandate contract, whether the displayed price is the discounted price (true)
        /// or the non-discounted price (false)
        /// </summary>
        public bool IsDisplayDiscountMandateContract { get; set; }

        /// <summary>
        /// Promotion params.
        /// </summary>
        public PromotionParameters PromotionParameters { get; set; }

        /// <summary>
        ///  Gets or sets the siteId and the catalogid list for the operation
        /// </summary>
        public IReadOnlyCollection<SiteCatalog> SiteCatalogList { get; set; }

        /// <summary>
        /// Gets or sets the criterion list.
        /// </summary>
        public IReadOnlyCollection<Criterion> CriterionList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image icon URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image icon URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageIconUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image banner URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image banner URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageBannerUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image banner full URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image banner full URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageBannerFullUrl { get; set; }

        /// <summary>
        /// Gets or sets the commercial operation banner text (text displayed on product sheet instead  of the banner).
        /// </summary>
        public string BannerText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image smartphone product banner URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image smartphone product banner URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageSmartphoneProductBannerUrl { get; set; }

        /// <summary>
        /// Gets or sets the smartphone text associated to the smartphone Banner.
        /// </summary>
        public string SmartphoneBannerText { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation FlagId.
        /// </summary>
        public int? FlagId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image cover image URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image cover image URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageCoverImageUrl { get; set; }

        /// <summary>
        /// Gets or sets the Prefix Description
        /// </summary>
        public string PrefixDescription { get; set; }

        /// <summary>
        /// Gets or sets the 
        /// </summary>
        public string HTMLDescription { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [set image rules URL].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set image rules URL]; otherwise, <c>false</c>.
        /// </value>
        public bool SetImageRulesUrl { get; set; }

        /// <summary>
        ///  Gets or sets the commercial operation Special Page URL .
        /// </summary>
        public Uri SpecialPageUrl { get; set; }

        /// <summary>
        /// Gets or sets the Partner Siren.
        /// </summary>
        public string PartnerSiren { get; set; }

        /// <summary>
        /// Gets or sets the Partner Address.
        /// </summary>
        public string PartnerAddress { get; set; }

        /// <summary>
        /// Gets or sets the Purchasing Manager Signatory.
        /// </summary>
        public string PurchasingManagerSignatory { get; set; }
    }
}
