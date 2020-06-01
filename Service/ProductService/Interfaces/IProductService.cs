using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.Models;

namespace ProductService.Interface
{
    public interface IProductService
    {
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of product entities</returns>
        IList<Product> GetAllProducts();

        /// <summary>
        /// Get product usind id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product entity</returns>
        Product GetProductById(int id);

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        void InsertProduct(Product product);

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product entity</param>
        void UpdateProduct(Product product);

        /// <summary>
        /// Delete products
        /// </summary>
        /// <param name="ids">Ids of product to delete</param>
        void DeleteProducts(int id);

        /// <summary>
        /// Search products
        /// </summary>
        /// <param name="nameFilter">Name filter</param>
        IList<Product> SearchProduct(
            string nameFilter = null);

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        void CheckOutProduct(History history);

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        IList<History> GetProductHistory();


    }
}
