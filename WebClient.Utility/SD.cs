namespace WebClient.Utility
{
    public class SD
    {
        public const string CONNECTION_STRING_NAME = "ApplicationDbContext";

        #region TABLE NAMES

        public const string TABLE_CITY = "Cities";
        public const string TABLE_SUPPLIER = "Suppliers";
        public const string TABLE_PURCHASE_REQUISITION = "PurchaseRequisitions";
        public const string TABLE_CURRENCY = "Currencies";
        public const string TABLE_PURCHASE_REQUISITION_LINE_ITEM = "PurchaseRequisitionLineItems";
        public const string TABLE_UNIT_OF_MEASUREMENT = "UnitOfMeasurements";
        public const string TABLE_PRODUCT = "Products";
        public const string TABLE_PURCHASE_ORDER = "PurchaseOrders";
        public const string TABLE_PURCHASE_ORDER_LINE_ITEM = "PurchaseOrderLineItems";
        public const string TABLE_APPROVAL = "Approvals";
        public const string TABLE_STATUS = "Statuses";

        #endregion

        #region SCHEMAS

        public const string DEFAULT_SCHEMA = "proc";

        #endregion

        #region SEED DATA

        public const string ADMIN_FIRST_NAME = "Administrator";
        public const string ADMIN_SURNAME = "";
        public const string ADMIN_USERNAME = "admin";
        public const string ADMIN_PHONE_NUMBER = "0123456789";
        public const string ADMIN_EMAIL = "admin@acme.co.za";
        public const string ADMIN_PASSWORD = "<admin@ACME2021>";

        #endregion

        #region ROLES

        public const string ROLE_ADMIN = "Administrator";
        public const string ROLE_SITE_USER = "Site User";
        public const string ROLE_APPROVER = "Approver";

        #endregion
    }
}
