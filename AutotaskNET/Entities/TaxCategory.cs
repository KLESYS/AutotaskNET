﻿using System;

namespace AutotaskNET.Entities
{
    /// <summary>
    /// The TaxCategory entity describes the tax rate for a specific billing item.<br />
    /// A TaxCategory associated with a TaxRegion determines the tax charged to customers.
    /// </summary>
    /// <seealso cref="AutotaskNET.Entities.Entity" />
    public class TaxCategory : Entity
    {
        #region Properties

        public override bool CanCreate => true;
        public override bool CanUpdate => true;
        public override bool CanQuery => true;
        public override bool CanDelete => false;
        public override bool CanHaveUDFs => false;

        #endregion //Properties

        #region Constructors

        public TaxCategory() : base() { } //end TaxCategory()
        public TaxCategory(net.autotask.webservices.TaxCategory entity) : base(entity)
        {

        } //end TaxCategory(net.autotask.webservices.TaxCategory entity)

        public override net.autotask.webservices.Entity ToATWS()
        {
            return new net.autotask.webservices.TaxCategory()
            {
                id = this.id,

            };

        } //end ToATWS()

        #endregion //Constructors

        #region Fields

        #region Required Fields

        public string Name; //Required Length:200

        #endregion //Required Fields

        #region Optional Fields

        public string Description; //Length:200
        public bool? Active;

        #endregion //Optional Fields

        #endregion //Fields

    } //end TaxCategory

}
