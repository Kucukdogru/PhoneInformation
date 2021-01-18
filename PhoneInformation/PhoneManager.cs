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

        public Model AddModel()
        {
            Model model5 = new Model
            {
                Id = 5,
                BrandId = 1,
                ModelName = "iPhone-11",
                UnitPrice = 8999
            };
            return model5;
        }

        public void GetInformation(Brand brand, Model model)
        {
                Console.WriteLine("Model ID: " + model.Id);               
                Console.WriteLine("Brand Name: " + brand.BrandName);
                Console.WriteLine("Model Name: " + model.ModelName);
                Console.WriteLine("Unit Price: " + model.UnitPrice);
        }
    }
}
