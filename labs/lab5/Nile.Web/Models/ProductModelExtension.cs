/*
 * Geoffrey Kio
 * ITSE 1430
 * 12/8/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nile.Web.Models
{
    public static class ProductModelExtension
    {
        public static Product ToDomain ( this ProductModel source )
        {
            if (source == null)
                return null;

            return new Product () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                IsDiscontinued = source.IsDiscontinued,
                Price = source.Price,
            };
        }

        public static ProductModel ToModel ( this Product source )
        {
            if (source == null)
                return null;

            return new ProductModel () {
                Id = source.Id,
                Name = source.Name,
                Description = source.Description,
                IsDiscontinued = source.IsDiscontinued,
                Price = source.Price,
            };
        }
    }
}