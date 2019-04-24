﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// This entity describes a Country as defined in the Autotask CRM module.<br />
    /// The Country entity is referenced by the Account, Contact, and Sales Order entities and specifies the preferred display name for the associated country as well as the default address format and invoice template to be used by accounts, contacts, and sales orders that reference the Country ID.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class Country : Entity
    {
        #region Properties

        public override bool CanCreate => false;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public Country() : base() { } //end Country()
        public Country(net.autotask.webservices.Country entity) : base(entity)
        {
            this.AddressFormatID = long.Parse(entity.AddressFormatID.ToString());
            this.DisplayName = entity.DisplayName == null ? default(string) : entity.DisplayName.ToString();
            this.Active = entity.Active == null ? default(bool?) : bool.Parse(entity.Active.ToString());
            this.CountryCode = entity.CountryCode == null ? default(string) : entity.CountryCode.ToString();
            this.InvoiceTemplateID = entity.InvoiceTemplateID == null ? default(int?) : int.Parse(entity.InvoiceTemplateID.ToString());
            this.IsDefaultCountry = entity.IsDefaultCountry == null ? default(bool?) : bool.Parse(entity.IsDefaultCountry.ToString());
            this.Name = entity.Name == null ? default(string) : entity.Name.ToString();
            this.QuoteTemplateID = entity.QuoteTemplateID == null ? default(int?) : int.Parse(entity.QuoteTemplateID.ToString());

        } //end Country(net.autotask.webservices.Country entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.Country()
            {
                id = this.id,
                Active = this.Active,
                AddressFormatID = this.AddressFormatID,
                CountryCode = this.CountryCode,
                DisplayName = this.DisplayName,
                InvoiceTemplateID = this.InvoiceTemplateID,
                IsDefaultCountry = this.IsDefaultCountry,
                Name = this.Name,
                QuoteTemplateID = this.QuoteTemplateID
            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region ReadOnly Fields

        public string CountryCode; //ReadOnly Length:2
        public string Name; //ReadOnly Length:50

        #endregion //ReadOnly Fields

        #region Required Fields

        public string DisplayName; //Required Length:100
        public long AddressFormatID; //Required PickList

        #endregion //Required Fields

        #region Optional Fields

        public bool? Active;
        public bool? IsDefaultCountry;
        public int? QuoteTemplateID; //[QuoteTemplate]
        public int? InvoiceTemplateID; //[InvoiceTemplate]

        #endregion //Optional Fields

        #endregion //Fields

    } //end Country

}
