using System;

namespace DotNetCoreAPI
{
    /// <summary>
    /// Commercial Campaign
    /// </summary>
    public class CommercialCampaign
    {
        /// <summary>
        /// Gets or sets the campaign identifier.
        /// </summary>
        /// <value>
        /// The campaign identifier.
        /// </value>
        public int CampaignId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the external identifier.
        /// </summary>
        /// <value>
        /// The external identifier.
        /// </value>
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public CommercialCampaignState State { get; set; }

        /// <summary>
        /// Gets or sets the corporation identifier.
        /// </summary>
        /// <value>
        /// The corporation identifier.
        /// </value>
        public short CorporationId { get; set; }

        /// <summary>
        /// Gets or sets the contratual budget.
        /// </summary>
        /// <value>
        /// The contratual budget.
        /// </value>
        public decimal? ContratualBudget { get; set; }

        /// <summary>
        /// Gets or sets the off contract budget.
        /// </summary>
        /// <value>
        /// The off contract budget.
        /// </value>
        public decimal? OffContractBudget { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.
        /// </value>
        public DateTimeOffset? CreationDate { get; set; }

        /// <summary>
        /// Gets or sets the update date.
        /// </summary>
        /// <value>
        /// The update date.
        /// </value>
        public DateTimeOffset? UpdateDate { get; set; }
    }
}
