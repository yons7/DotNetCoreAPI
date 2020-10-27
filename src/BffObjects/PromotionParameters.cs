using System.Collections.Generic;

namespace DotNetCoreAPI
{
    /// <summary>
    /// PromotionParameters Class
    /// </summary>
    public class PromotionParameters
    {
        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or sets the type of the amount.
        /// </summary>
        /// <value>
        /// The type of the amount.
        /// </value>
        public AmountType? AmountType { get; set; }

        /// <summary>
        /// Gets or sets the operation maximum amount.
        /// </summary>
        /// <value>
        /// The operation maximum amount.
        /// </value>
        public decimal? OperationMaximumAmount { get; set; }

        /// <summary>
        /// Gets or sets the minimum amount.
        /// </summary>
        /// <value>
        /// The minimum amount.
        /// </value>
        public decimal? MinimumAmount { get; set; }

        /// <summary>
        /// Gets or sets the maximum amount.
        /// </summary>
        /// <value>
        /// The maximum amount.
        /// </value>
        public decimal? MaximumAmount { get; set; }

        /// <summary>
        /// Gets or sets the operation code.
        /// </summary>
        /// <value>
        /// The operation code.
        /// </value>
        public string OperationCode { get; set; }

        /// <summary>
        /// Gets or sets the voucher family.
        /// </summary>
        /// <value>
        /// The voucher family.
        /// </value>
        public VoucherFamily VoucherFamily { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is promotion accumulative.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is promotion accumulative; otherwise, <c>false</c>.
        /// </value>
        public bool IsPromotionAccumulative { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is unique use code.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is unique use code; otherwise, <c>false</c>.
        /// </value>
        public bool? IsUniqueUseCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is exclude product in sales.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is exclude product in sales; otherwise, <c>false</c>.
        /// </value>
        public bool? IsExcludeProductInSales { get; set; }

        /// <summary>
        /// Gets or sets the progressive targeting mode.
        /// </summary>
        /// <value>
        /// The progressive targeting mode.
        /// </value>
        public ProgressiveTargetingMode? ProgressiveTargetingMode { get; set; }

        /// <summary>
        /// Gets or sets the amount list.
        /// </summary>
        /// <value>
        /// The amount list.
        /// </value>
        public IReadOnlyDictionary<int, decimal> AmountList { get; set; }

        /// <summary>
        /// Gets or sets the duration of the voucher validity.
        /// </summary>
        /// <value>
        /// The duration of the voucher validity.
        /// </value>
        public int? VoucherValidityDuration { get; set; }

        /// <summary>
        /// Gets or sets the margin promo.
        /// </summary>
        /// <value>
        /// The margin promo.
        /// </value>
        public decimal? MarginPromo { get; set; }

        /// <summary>
        /// Gets or sets the generated vouchers count.
        /// </summary>
        /// <value>
        /// The generated vouchers count.
        /// </value>
        public int? GeneratedVouchersCount { get; set; }        
    }
}
