﻿using HAYNARESTAURANT.Domain.Infrastructure;
using HAYNARESTAURANT.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYNARESTAURANT.Domain.BBL
{
    public class ProductBLL : BaseModel
    {
        private static DataAccess db = new DataAccess();

        public static List<Products> GetAll()
        {
            return db.Products.ToList();
        }

        public static Page<Products> Search(long pageSize = 3, long pageIndex = 1, SortOrder sortOrder = SortOrder.Ascending, string keyword = "", Guid? categoryId = null)
        {
            Page<Products> result = new Page<Products>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Products> prodQuery = (IQueryable<Products>)db.Products;

            if (categoryId != null)
            {
                prodQuery = prodQuery.Where(c => c.CategoryId == categoryId.Value);
            }
            else
            {
                return result;
            }

            if (string.IsNullOrEmpty(keyword) == false)
            {
                prodQuery = prodQuery.Where(c => c.Name.Contains(keyword));
            }

            long queryCount = prodQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Products> products = new List<Products>();

            if (sortOrder == SortOrder.Ascending)
            {
                products = prodQuery.OrderBy(c => c.Name).ToList();
            }
            else
            {
                products = prodQuery.OrderByDescending(u => u.Name).ToList();
            }


            result.Items = products.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;

            return result;
        }
    }
}
