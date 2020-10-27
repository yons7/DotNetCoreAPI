namespace DotNetCoreAPI
{
    /// <summary>
    /// Voucher Family Class
    /// </summary>
    public class VoucherFamily
    {
        /// <summary>
        /// Gets or sets the voucher family identifier.
        /// </summary>
        /// <value>
        /// The voucher family identifier.
        /// </value>
        public int VoucherFamilyId { get; set; }

        /// <summary>
        /// Gets or sets the name of the voucher family.
        /// </summary>
        /// <value>
        /// The name of the voucher family.
        /// </value>
        public string VoucherFamilyName { get; set; }

        /// <summary>
        /// Gets or sets the voucher family group.
        /// </summary>
        /// <value>
        /// The voucher family group.
        /// </value>
        public string VoucherFamilyGroup { get; set; }
    }
}
