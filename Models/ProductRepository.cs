using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;


namespace CEDR.WebAPI.Models
{
    /// <summary>
    /// Stores data in .json file so no db is needed.
    /// </summary>

    public class ProductRepository
    {
        /// <summary>
        /// Creates a new product with default vals
        /// </summary>
        /// <returns></returns>  
        internal Product Create()
        {
            
            Product product = new Product
            { 
                ReleaseDate = DateTime.Now
            };
            return product; 
        }

        /// <summary>
        /// Retrieves list of products
        /// </summary>
        /// <returns></returns>  
        internal List<Product> Retrieve()
        {
             
        }
    }
}