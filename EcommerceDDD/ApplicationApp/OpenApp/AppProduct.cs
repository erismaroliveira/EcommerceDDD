using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _product;
        IServiceProduct _serviceProduct;

        public AppProduct(IProduct product, IServiceProduct serviceProduct)
        {
            _product = product;
            _serviceProduct = serviceProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            await _serviceProduct.AddProduct(produto);
        }

        public async Task UpdateProduct(Produto produto)
        {
            await _serviceProduct.UpdateProduct(produto);
        }

        public async Task<Produto> Add(Produto Objeto)
        {
            return await _product.Add(Objeto);
        }

        public async Task<Produto> Update(Produto Objeto)
        {
            return await _product.Update(Objeto);
        }

        public async Task Delete(Produto Objeto)
        {
            await _product.Delete(Objeto);
        }

        public async Task<Produto> GetEntityById(int Id)
        {
            return await _product.GetEntityById(Id);
        }

        public async Task<List<Produto>> List()
        {
            return await _product.List();
        }
    }
}
