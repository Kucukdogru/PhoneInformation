using System;

namespace PhoneInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Brand brand = new Brand
            {
                Id=1,
                BrandName="IPhone"
            };

            Brand brand2 = new Brand
            {
                Id = 2,
                BrandName = "Samsung"
            };

            Brand brand3 = new Brand
            {
                Id = 3,
                BrandName = "General Mobile"
            };

            Brand brand4 = new Brand
            {
                Id = 4,
                BrandName = "Huawei"
            };

            Brand brand5 = new Brand
            {
                Id = 5,
                BrandName = "HTC"
            };

            Brand[] brands = new Brand[] { brand, brand2, brand3, brand4, brand5 };
            Console.WriteLine("****************Phone Brands***********");
            PhoneManager phoneManager = new PhoneManager();
            phoneManager.GetBrand(brands);



            Model model = new Model { 
                Id=1, 
                BrandId=2,
                ModelName="Galaxy S21",
                UnitPrice=9999
            };


            Model model2 = new Model
            {
                Id = 2,
                BrandId=2,
                ModelName = "Galaxy S21 Ultra",
                UnitPrice = 15999
            };

            Model model3 = new Model
            {
                Id = 3,
                BrandId=3,
                ModelName = "GM 20",
                UnitPrice = 1799
            };

            Model model4 = new Model
            {
                Id = 4,
                BrandId=1,
                ModelName = "XS-256",
                UnitPrice = 11435.46
            };

            Model[] models = new Model[] { model, model2, model3, model4 };

            Console.WriteLine("\n**************Phone Models**************");
            PhoneManager phoneManager1 = new PhoneManager();
            phoneManager1.GetModel(models);

            Console.WriteLine("\n**************Phone Information**************");
            PhoneManager phoneManager2 = new PhoneManager();
            phoneManager2.GetInformation(brand2, model);
            Console.WriteLine("------------------------");

            PhoneManager phoneManager3 = new PhoneManager();
            phoneManager3.GetInformation(brand2, model2);
            Console.WriteLine("------------------------");

            PhoneManager phoneManager4 = new PhoneManager();
            phoneManager4.GetInformation(brand3, model3);
            Console.WriteLine("------------------------");

            PhoneManager phoneManager5 = new PhoneManager();
            phoneManager5.GetInformation(brand, model4);


        }
    }
}

