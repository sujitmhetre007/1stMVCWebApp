using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace Core_WebApp.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "Category Row Id is required..")]
        public int CategoryRowId { get; set; }
        [Required(ErrorMessage = "Category Id is required..")]
        public String CategoryId { get; set; }
        [Required(ErrorMessage = "Category Name is required..")]
        public String CategoryName { get; set; }
        [Required(ErrorMessage = "Base Price is required..")]
        public int BasePrice { get; set; }
        public IList<Product> Products { get; set; }
    }

    public class Product
    {
        [Key]
        [Required(ErrorMessage = "Product Row Id is required..")]
        public int ProductRowId { get; set; }
        [Required(ErrorMessage = "Product Id is required..")]
        public String ProductId { get; set; }
        [Required(ErrorMessage = "Product Name is required..")]
        public String ProductName { get; set; }
        [Required(ErrorMessage = "manufacturer is required..")]
        public String Manufacturer { get; set; }
        [Required(ErrorMessage = "Description is required..")]
        public String Description { get; set; }
        [Required(ErrorMessage = "Price is required..")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Category Row Id is required..")]
        public int CategoryRowId { get; set; }
        public Category Category { get; set; }
    }
}
