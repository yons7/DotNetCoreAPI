using System.Runtime.Serialization;

namespace DotNetCoreAPI
{
    /// <summary>
    /// Nature of the extended property to store
    /// </summary>
    public enum CommercialOperationExtendedPropertyType
    {
        /// <summary>
        /// In case of unspecified type
        /// </summary>
        [EnumMember(Value = "unknow")]
        Unknow = 0,
        /// <summary>
        /// Credit code to transmit to BCA when subscribing to the card
        /// </summary>
        [EnumMember(Value = "cdiscount_card_bca_credit_code")]
        CdiscountCardBcaCreditCode = 1,
        /// <summary>
        /// Type of welcome offer for subscription to the Cdiscount card
        /// </summary>
        [EnumMember(Value = "cdiscount_card_welcome_offer_type")]
        CdiscountCardWelcomeOfferType = 2,
        /// <summary>
        /// Target type for shipping operations: on eligible products or on delivery groups with eligible products
        /// </summary>
        [EnumMember(Value = "shipping_fees_target_type")]
        ShippingFeesTargetType = 3,
        /// <summary>
        /// Value of the welcome offer (whether it is a discount or a percentage)
        /// </summary>
        [EnumMember(Value = "cdiscount_card_welcome_offer_value")]
        CdiscountCardWelcomeOfferValue = 4,
        /// <summary>
        /// Name of the supplier for a commercial transaction of type "Contract mandate"
        /// </summary>
        [EnumMember(Value = "mandat_partner_name")]
        MandatPartnerName = 5,
        /// <summary>
        /// Id subscription type for "Free subscription" commercial operation
        /// </summary>
        [EnumMember(Value = "subscription_type")]
        SubscriptionType = 6,
        /// <summary>
        /// Subscription duration for "Free subscription" commercial operation
        /// </summary>
        [EnumMember(Value = "subscription_duration")]
        SubscriptionDuration = 7,
        /// <summary>
        /// Subscription delay for "Free subscription" commercial operation
        /// </summary>
        [EnumMember(Value = "subscription_delay")]
        SubscriptionDelay = 8,
        /// <summary>
        /// The percentage discount on the second product of a lot
        /// </summary>
        [EnumMember(Value = "percentage_discount")]
        PercentageDiscount = 9,
        /// <summary>
        /// The number of product x for the operation "X products for the price of Y products" .
        /// </summary>
        [EnumMember(Value = "number_of_product_x")]
        NumberOfProductX = 10,
        /// <summary>
        /// The number of product x for the operation "X products for the price of Y products" .
        /// </summary>
        [EnumMember(Value = "number_of_product_y")]
        NumberOfProductY = 11,
        /// <summary>
        /// The order maximum products count
        /// </summary>
        [EnumMember(Value = "order_max_products_count")]
        OrderMaxProductsCount = 12,
        /// <summary>
        /// The boa automatic validation
        /// </summary>
        [EnumMember(Value = "boa_auto_validation")]
        BoaAutoValidation = 13,
        /// <summary>
        /// The boa generation start date
        /// </summary>
        [EnumMember(Value = "boa_generation_start_date")]
        BoaGenerationStartDate = 14,
        /// <summary>
        /// The boa generation mode
        /// </summary>
        [EnumMember(Value = "boa_generation_mode")]
        BoaGenerationMode = 15,
        /// <summary>
        /// The boa generation wave amount
        /// </summary>
        [EnumMember(Value = "boa_generation_wave_amount")]
        BoaGenerationWaveAmount = 16,
        /// <summary>
        /// The boa generation days
        /// </summary>
        [EnumMember(Value = "boa_generation_days")]
        BoaGenerationDays = 17,
        /// <summary>
        /// The number of generated code
        /// </summary>
        [EnumMember(Value = "boa_copy_number")]
        BoaCopyNumber = 18,
        /// <summary>
        /// The triple price CDAV enabled
        /// </summary>
        [EnumMember(Value = "triple_price_cdav_enabled")]
        TriplePriceCdavEnabled = 19,
        /// <summary>
        /// Indicates if new subscribers can benefit from the operation or not
        /// </summary>
        [EnumMember(Value = "allow_new_subscriptions")]
        AllowNewSubscriptions = 20,
        /// <summary>
        /// Indicates if the promotion must be displayed on the Front
        /// </summary>
        [EnumMember(Value = "is_displayed_front")]
        IsDisplayedFront = 21,
        /// <summary>
        /// Indicates if we must generate the BOA for products purchased via gift list
        /// </summary>
        [EnumMember(Value = "must_buy_from_gift_list")]
        MustBuyFromGiftList = 22,
        /// <summary>
        /// Indicates if the user choose the default sentence
        /// </summary>
        [EnumMember(Value = "voucher_terms_use_is_default")]
        VoucherTermsUseIsDefault = 23,
        /// <summary>
        /// Indicates if the user choose the libre sentence
        /// </summary>
        [EnumMember(Value = "voucher_terms_use")]
        VoucherTermsUse = 24,
        /// <summary>
        /// The dedicated offer subscription type identifier
        /// </summary>
        [EnumMember(Value = "dedicate_offer_subscription_type_id")]
        DedicateOfferSubscriptionTypeId = 25,
        /// <summary>
        /// The internal Operation Code (reserved for Banque Casino)
        /// </summary>
        [EnumMember(Value = "bca_internal_operation_code")]
        BCAInternalOperationCode = 26,
        /// <summary>
        /// The Legal Mentions
        /// </summary>
        [EnumMember(Value = "operation_terms_use")]
        OperationTermsUse = 27,
        /// <summary>
        /// Display opeco front details informations
        /// </summary>
        [EnumMember(Value = "front_description")]
        FrontDescription = 28,
        /// <summary>
        /// The Legal Notice
        /// </summary>
        [EnumMember(Value = "legal_notice")]
        LegalNotice = 29,
        /// <summary>
        /// Alert mail threshold
        /// </summary>
        [EnumMember(Value = "alert_mail_threshold")]
        AlertMailThreshold = 30,
        /// <summary>
        /// Is mandat with partner refund.
        /// </summary>
        [EnumMember(Value = "is_mandate_with_partner_refund")]
        IsMandateWithPartnerRefund = 31,
        /// <summary>
        /// Is original operationId.
        /// </summary>
        [EnumMember(Value = "original_operation_id")]
        OriginalOperationId = 32,
        /// <summary>
        /// The boa generation partner
        /// </summary>
        [EnumMember(Value = "boa_generation_partner")]
        BoaGenerationPartner = 33,
        /// <summary>
        /// The boa generation capping per day
        /// </summary>
        [EnumMember(Value = "boa_generation_capping_per_day")]
        BoaGenerationCappingPerDay = 34,
        /// <summary>
        /// Is department management.
        /// </summary>
        [EnumMember(Value = "is_department_management_operation")]
        IsDepartmentManagementOperation = 35,
        /// <summary>
        /// Is an E-Card GiftVoucher.
        /// </summary>
        [EnumMember(Value = "is_e_card_gift_voucher")]
        IsECardGiftVoucher = 36,
        /// <summary>
        /// Delay to add to EndDate for Reassurance Email
        /// </summary>
        [EnumMember(Value = "delay_date_action")]
        DelayDateAction = 38,

        /// <summary>
        /// The price calendar planning list
        /// </summary>
        [EnumMember(Value = "price_calendar_planning_list")]
        PriceCalendarPlanningList = 41
    }
}
