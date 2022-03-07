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


          
            ColorManager colorManager = new ColorManager(new ColorDal());
            Color color = new Color();

            int deletedColor = 1002;
            foreach (var hakki in colorManager.GetAll())
            {
                if (hakki.ColorId == deletedColor)
                {

                    colorManager.Delete(hakki);
                }

            }

        }
    }
}
