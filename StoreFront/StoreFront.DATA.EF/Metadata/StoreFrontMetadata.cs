﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; //Added for validators & display attributes

namespace StoreFront.DATA.EF.Metadata
{
    #region Category

    public class CategoryMetadata
    {
        public short CategoryID { get; set; }

        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    {

    }

    #endregion

    #region Customer

    public class CustomerMetadata
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "*First Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "*Last Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50, ErrorMessage = "*Cannot exceed 50 characters")]
        public string Address { get; set; }

        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        public string City { get; set; }

        [StringLength(5, ErrorMessage = "*Cannot exceed 5 characters")]
        public string PostalCode { get; set; }

        [StringLength(24, ErrorMessage = "*Cannot exceed 24 characters")]
        public string Phone { get; set; }
    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    {

    }

    #endregion

    #region Department

    public class DepartmentMetadata
    {
        public short DepartmentID { get; set; }

        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        public string DepartmentName { get; set; }
    }

    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {

    }

    #endregion

    #region Employee

    public class EmployeeMetadata
    {
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "*First Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        
        [Required(ErrorMessage = "*Last Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "*Department ID is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "Department ID")]
        public short DeptID { get; set; }

        public bool HasDirectReport { get; set; }
        public Nullable<int> DirectReportID { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }

        [StringLength(24, ErrorMessage = "*Cannot exceed 24 characters")]
        public string Phone { get; set; }
    }

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
        //custom property
        //public string FullName
        //{
        //    get { return FirstName + " " + LastName; }
        
        //}
    }

    #endregion

    #region Product

    public class ProductMetadata
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "*Product Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 50 characters")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "*Supplier ID is required")]
        [Display(Name = "Supplier ID")]
        public int SupplierID { get; set; }

        [Required(ErrorMessage = "*Category ID is required")]
        [Display(Name = "Category ID")]
        public short CategoryID { get; set; }

        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<int> ProductStatusID { get; set; }
    }

    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    {

    }

    #endregion

    #region ProductStatus

    public class ProductStatusMetadata
    {
        public int ProductStatusID { get; set; }

        [Required(ErrorMessage = "*Status Name is required")]
        [StringLength(15, ErrorMessage = "*Cannot exceed 15 characters")]
        [Display(Name = "Status Name")]
        public string StatusName { get; set; }
    }

    [MetadataType(typeof(ProductStatusMetadata))]
    public partial class ProductStatus
    {

    }

    #endregion

}
