using System.Collections.Generic;

namespace Task3
{
    // gets products that meet specified conditions
    class SuitableProducts
    {
        public List<string> GetSuitableProducts(List<string> names, List<int> prices, List<string> types, List<int> expirationDate)
        {
            //products that meet specified conditions
            List<string> suitableProducts = new List<string>();
            //total products
            const int productsCount = 4;

            //conditions
            const int maxPrice = 2;
            const int minExpirationDate = 6;

            //find products that meet specified conditions
            for (int i = 0; i < productsCount; i++)
            {
                if (prices[i] <= maxPrice && expirationDate[i] >= minExpirationDate)
                {
                    suitableProducts.Add(names[i] + ", " + types[i] + ", price: " + prices[i] + ", expiration date: " + expirationDate[i]);
                }
            }
            return suitableProducts;
        }
    }
}
