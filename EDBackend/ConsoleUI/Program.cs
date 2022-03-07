using System;
using DataAccess.Repositories;
using Business.Repositories;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Business.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


          
           ProductManager productManager = new ProductManager(new ProductDal(),new CategoryDal(),new ChildCategoryDal());
           
           foreach (var item in productManager.GetByCategoryId(2))
           {
               Console.WriteLine(item.ProductName +" "+ item.ChildCategoryId);
           }

        }
    }
}
