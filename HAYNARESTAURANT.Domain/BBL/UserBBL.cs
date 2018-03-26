using HAYNARESTAURANT.Domain.Infrastructure;
using HAYNARESTAURANT.Domain.Models;
using HAYNARESTAURANT.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HAYNARESTAURANT.Domain.BBL
{
    public static class UsersBLL
    {
        private static DataAccess db = new DataAccess();

        public static List<Users> GetAll()
        {
            return db.User.ToList();
        }
        public static Users GetUserByUserName(string userName)
        {
             return db.User.FirstOrDefault(u => u.UserName.ToLower() == userName.ToLower());
         }
 
        public static Users Create(Users users)
         {
             db.User.Add(users);
             db.SaveChanges();
             return users;
         }


        public static Users Update(Users user)
        {
            Users userRecord = db.User.FirstOrDefault(u => u.Id == user.Id);
            if (userRecord != null)
            {
                userRecord.FirstName = user.FirstName;
                userRecord.LastName = user.LastName;
                userRecord.UserName = user.UserName;
                userRecord.Role = user.Role;
                db.SaveChanges();    
            }

            return userRecord;
        }
        public static Page<Users> Search(long pageSize = 3, long pageIndex = 1, UserSortOrder orderBy = UserSortOrder.UserName, SortOrder sortOrder = SortOrder.Ascending, Role? role = null, string keyword = "")
        {
            Page<Users> result = new Page<Users>();


            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Users> userQuery = (IQueryable<Users>)db.User;

            if (role != null)
            {
                userQuery = userQuery.Where(u => u.Role == role.Value);
            }

            if (string.IsNullOrEmpty(keyword) == false)
            {
                userQuery = userQuery.Where(u => u.FirstName.Contains(keyword)
                                            || u.LastName.Contains(keyword)
                                            || u.UserName.Contains(keyword));
            }

            long queryCount = userQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Users> user = new List<Users>();

            if (sortOrder == SortOrder.Ascending && orderBy == UserSortOrder.UserName)
            {
                user = userQuery.OrderBy(u => u.UserName).ToList();
            }
            else if (sortOrder == SortOrder.Descending && orderBy == UserSortOrder.UserName)
            {
                user = userQuery.OrderByDescending(u => u.UserName).ToList();
            }
            else if (sortOrder == SortOrder.Ascending && orderBy == UserSortOrder.FirstName)
            {
                user = userQuery.OrderBy(u => u.FirstName).ToList();
            }
            else if (sortOrder == SortOrder.Descending && orderBy == UserSortOrder.FirstName)
            {
                user = userQuery.OrderByDescending(u => u.FirstName).ToList();
            }
            else if (sortOrder == SortOrder.Ascending && orderBy == UserSortOrder.LastName)
            {
                user = userQuery.OrderBy(u => u.LastName).ToList();
            }
            else if (sortOrder == SortOrder.Descending && orderBy == UserSortOrder.LastName)
            {
                user = userQuery.OrderByDescending(u => u.LastName).ToList();
            }

            result.Items = user.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;

            return result;
        } 

        public static Users Find(Guid? id)
        {
            return db.User.FirstOrDefault(u => u.Id == id);
            
        }
    }
}
