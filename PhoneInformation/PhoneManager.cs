using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneInformation
{
    class PhoneManager
    {
        public void GetBrand(Brand[] brands)
        {
            foreach (Brand brand in brands)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        public void GetModel(Model[] models)
        {
            foreach (Model model in models)
            {
                Console.WriteLine(model.ModelName);
                Console.WriteLine(model.UnitPrice);
                Console.WriteLine("********");
            }
        }

        public void GetInformation(Brand brand, Model model)
        {
                Console.WriteLine("Model ID: " + model.Id);               
                Console.WriteLine("Brand Name: " + brand.BrandName);
                Console.WriteLine("Model Name: " + model.ModelName);
                Console.WriteLine("Model ID: " + model.UnitPrice);
        }
    }
}
