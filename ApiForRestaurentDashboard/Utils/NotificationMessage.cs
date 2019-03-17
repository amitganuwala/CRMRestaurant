using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiForRestaurentDashboard.Utils
{
    public static class NotificationMessage
    {
        public static string TitleSuccess = "Success";
        public static string TypeSuccess = "success";

        public static string TitleError = "Error";
        public static string TypeError = "error";


        public static string Titlewarning = "Warning";
        public static string Typewarning = "warning";

        public static string msgAddProductType = "The new ProductType has been added successfully.";
        public static string msgEditProductType = "The ProductType info has been updated successfully.";
        public static string ErrormsgEditProductType = "The ProductType info has not been updated successfully.";

        public static string msgAddOption = "The new Option has been added successfully.";
        public static string msgEditOption = "The Option info has been updated successfully.";
        public static string ErrormsgEditOption = "The Option info has not been updated successfully.";

        public static string msgAddAddon = "The new Addon has been added successfully.";
        public static string msgEditAddon = "The Addon info has been updated successfully.";
        public static string ErrormsgEditAddon = "The Addon info has not been updated successfully.";

        public static string msgAddGallery = "The new Images has been added successfully.";
        public static string msgEditGallery = "The Gallery info has been updated successfully.";
        public static string ErrormsgEditGallery = "The Gallery info has not been updated successfully.";

        //public static string msgAddRFQ = "The new quote has been added successfully.";
        //public static string ErrormsgAddVendor = "The new vendor has not been added to database.";
        //public static string msgCreateCatalogProduct = "The new catalog product has been added successfully.";
        //public static string ErrormsgCreateCatalogProduct = "The new catalog product has not been added to database.";
        //public static string msgEditCatalogProduct = "The catalog product has  been edited successfully.";
        //public static string ErrormsgEditCatalogProduct = "The catalog product has not been edited.";
        //public static string msgCreateCategory = "The new category has  been added successfully.";
        //public static string ErrormsgCreateCategory = "The new category has not been added to database.";
        //public static string msgEditCategory = "The category has  been edited successfully.";
        //public static string ErrormsgEditCategory = "The category has not been edited.";
        //public static string msgAddCustomer = "The new customer has been added successfully.";
        //public static string ErrormsgAddCustomer = "The new customer has not been added to database.";
        //public static string msgEditCustomer = "The customer info has been edited successfully.";
        //public static string ErrormsgEditCustomer = "The customer info has not been edited.";
        //public static string msgEditManufacturer = "The manufacturer info has been edited successfully.";
        //public static string ErrormsgEditManufacturer = "The manufacturer info has not been edited.";
        //public static string msgCreateManufacturer = "The new manufaturer has been added successfully.";
        //public static string ErrormsgCreateManufacturer = "The new manufacturer has not been added to database.";
        //public static string msgAddProductToOrderDetails = "The product has been added order details.";
        //public static string ErrormsgAddProductToOrderDetails = "The product has not been added order details.";
        //public static string msgAddressEdit = "The address has been edited successfully.";
        //public static string ErrormsgAddressEdit = "The  address has not been edited  to database.";
        //public static string msgCreateSaleInvoice = "The new saleinvoice has been added successfully.";
        //public static string ErrormsgCreateSaleInvoice = "The new saleinvoice has not been added to database.";
        //public static string msgCreateProduct = "The new product has been added successfully.";
        //public static string ErrormsgCreateProduct = "The new product has not been added to database.";
        //public static string msgEditProduct = "The product info has been edited successfully.";
        //public static string ErrormsgEditProduct = "The product info has not been edited.";
        //public static string msgCreateWarehouse = "The new warehouse has been added successfully.";
        //public static string ErrormsgCreateWarehouse = "The new wareouse has not been added to database.";
        //public static string msgEditWarehouse = "The warehouse info has been edited successfully.";
        //public static string ErrormsgEditWarehouse = "The warehouse info has not been edited.";
        //public static string msgCreateCustomerRole = "The new customer role has been added successfully.";
        //public static string ErrormsgCreateCustomerRole = "The new customer role has not been added to database.";
        //public static string msgEditCustomerRole = "The customer role has  been edited successfully.";
        //public static string ErrormsgEditCustomerRole = "The customer role has not been edited.";
        //public static string msgDeleted = "Product has been deleted successfully.";
        //public static string ErrormsgDeleted = "Product is in use.";
    }
}
