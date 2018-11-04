using System;
using System.Collections.Generic;

namespace dev4
{
    //makes a new record about the car and checks this record for uniqueness and correctness
    public class NewCar
    {
        //type input
        public string EnterBrand()
        {
            Console.Write("Enter the car type: ");
            string brand = Console.ReadLine();
            return brand;
        }

        //model input
        public string EnterModel()
        {
            Console.Write("Enter the car model: ");
            string model = Console.ReadLine();
            return model;
        }

        //count input
        public int EnterCount()
        {
            Console.Write("Enter the count of cars: ");
            int count = Int32.Parse(Console.ReadLine());
            return count;
        }

        //price input
        public int EnterPrice()
        { 
            Console.Write("Enter the price of product: ");
            int price = Int32.Parse(Console.ReadLine());
            return price;
        }

        //makes a new record about the car and checks this record for uniqueness and correctness
        public void CreateCar(List<string> brands, List<string> models, List<int> counts, List<int> prices)
        { 
            EnterData:
            string brand = EnterBrand();
            string model = EnterModel();
            int count = EnterCount();
            int price = EnterPrice();

            bool uniqueCar = true;
            bool correctCar = true;
            int currentCarsAmount = 0;

            //checks that all data has been entered
            if (brand.Length == 0 || model.Length == 0 || count == 0 || price == 0)
            {
                correctCar = false;
                Console.Write("\nUncorrect data. Try again.\n");
                goto EnterData;
            }

            foreach (var item in brands)
                currentCarsAmount++;

            //checks new car for uniqueness
            for (int i = 0; i < currentCarsAmount; i++)
            {
                if (brands[i].Contains(brand) && models[i].Contains(model) && (prices[i] == price))
                {
                    uniqueCar = false;
                    counts[i] += count;
                    break;
                }
            }

            //if the car passed the test writes it
            if (uniqueCar && correctCar)
            {
                brands.Add(brand);
                models.Add(model);
                counts.Add(count);
                prices.Add(price);
            }
        }
    }
}
