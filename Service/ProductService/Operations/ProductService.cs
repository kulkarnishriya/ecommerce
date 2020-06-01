using ProductService.Interface;
using ProductService.EntityFrameworkCore.EFRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductService.EntityFrameworkCore;
using ProductService.Models;

namespace Services.ProductService.Operations
{
    public class MyProductService : IProductService
    {
        #region Fields

        private readonly ApplicationDbContext _context;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<History> _historyRepository;

        #endregion

        #region Constructor

        public MyProductService(
            ApplicationDbContext context,
            IRepository<Product> productRepository,
            IRepository<History> historyRepository)
        {
            _context = context;
            _productRepository = productRepository;
            _historyRepository = historyRepository;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns>List of product entities</returns>
        public IList<Product> GetAllProducts()
        {
            var entities = _context.Product
                .AsNoTracking()
                .ToList<Product>();

            return entities;
        }

        /// <summary>
        /// Get product usind id
        /// </summary>
        /// <param name="id">Product id</param>
        /// <returns>Product entity</returns>
        public Product GetProductById(int id)
        {
            if (id == null)
                return null;


            // TODO: update when lazy loading is available
            var entity = _context.Product
                .AsNoTracking()
                .SingleOrDefault(x => x.Id == id);

            return entity;
        }

        /// <summary>
        /// Insert product
        /// </summary>
        /// <param name="product">Product entity</param>
        public void InsertProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");
            product.DateAdded = DateTime.Now;

            _productRepository.Insert(product);
            _productRepository.SaveChanges();
        }

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="product">Product entity</param>
        public void UpdateProduct(Product product)
        {
            if (product == null)
                throw new ArgumentNullException("product");

            _productRepository.Update(product);
            _productRepository.SaveChanges();
        }

        /// <summary>
        /// Delete products
        /// </summary>
        /// <param name="ids">Ids of product to delete</param>
        public void DeleteProducts(int id)
        {
            if (id == null)
                throw new ArgumentNullException("id");

             _productRepository.Delete(GetProductById(id));

            _productRepository.SaveChanges();
        }

        /// <summary>
        /// Search products
        /// </summary>
        /// <param name="nameFilter">Name filter</param>
        public IList<Product> SearchProduct(
            string nameFilter = null)
        {
            var result = _context.Product
                .AsNoTracking().ToList<Product>();


            // name filter
            if(nameFilter != null && nameFilter.Length > 0)
            {
                result = result.Where(x => x.Name.ToLower().Contains(nameFilter.ToLower())).ToList<Product>();
            }
            return result.ToList<Product>();
        }

        public void CheckOutProduct(History history)
        {
            if (history == null)
                throw new ArgumentNullException("history");
            history.DateofPurchase = DateTime.Now;
            _historyRepository.Insert(history);
            _historyRepository.SaveChanges();
        }

        public IList<History> GetProductHistory()
        {
             var entities = _context.History
                .AsNoTracking()
                .ToList<History>();

            return entities;
        }

        #endregion
    }
}
