using DAL.Entity.Base;
using System;

namespace DAL.Entity
{
    public class Category:CoreEntity
    {
        //Burada bir Kategorinin birden fazla alt kategorisi olmasına olanak sağlanıcak.
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public Guid? MainCategory { get; set; }
    }
}