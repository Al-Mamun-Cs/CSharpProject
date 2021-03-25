using ConPJ1.DTO;
using ConPJ1.MyApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConPJ1.Utility
{
    public class Factory
    {
        public static Packages SelectedPackage;
        public static IMyApps  GetApp()
        {
            IMyApps app = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Product:
                    app = new AppProducts();
                    break;
                default:
                    app = null;
                    break;
            }
            return app;
        }
        public static IRepository GetRepo()
        {
            IRepository repo = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Product:
                    repo = new RepoProduct();
                    break;
                default:
                    repo = null;
                    break;
            }
            return repo;
        }

        public static IObject GetDTO()
        {
            IObject dto = null;
            switch (Factory.SelectedPackage)
            {
                case Packages.Product:
                    dto = new Product();
                    break;
                default:
                    dto = null;
                    break;
            }
            return dto;
        }
    }
}
