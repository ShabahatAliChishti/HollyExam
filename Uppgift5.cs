using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exam2022._2
{

    public class Uppgift5
    {
        [Fact]
        public void Uppgift()
        {
            /*
            OBS!!
             Hi there! just want to remind you that 
            you do not have to do the uppgift7.cs. but only do the tasks in uppgift5.cs as you see here
            and I'm grateful for your help
            */

            // For the task, there is a data file that contains a product database
            // Write the code as if you do not know the data.If more 
            //products are added in the future, the code should give correct answers for it

            // Requirements: The following information is searched for separately, stored in a variable.
            // - Number of Products costing over € 20
            // - How many products are in stock in total (UnitsInStock), the sum of all products' stock levels.
            // - Average price of products in the category "Beverages"
            // - Which product is most expensive in the category "Seafood"
            // - How many different products are there that cost over € 25 and are in stock.
            // - A & B should give the same answer, comment out the tests at the bottom to ensure.
            // - Replace 0 with the known correct values when you are done.

            List<Product> products = Products.ProductList;

            // A. Retrieve wanted information from the list in the task, use common control structures, such as `for`,` if`.

            // B. Retrieve the same information with a LINQ expression. 

            // Use the tests to make sure you get the same answer in A and B.
            // Feel free to add your own tests with actual values. not so importan

            // Assert.Equal(numValuableProducts, linqNumValuableProducts);
            // Assert.Equal(numProductsInStock, linqNumProductsInStock);
            // Assert.Equal(avgBeveragePrice, linqAvgBeveragePrice);
            // Assert.Equal(maxSeafoodPrice, linqMaxSeafoodPrice);
            // Assert.Equal(numStockedProductsWithPrice, linqNumStockedProductsWithPrice);

            // Fyll i med faktiska värden istället för 0
            // Assert.Equal(0, numValuableProducts);
            // Assert.Equal(0, numProductsInStock);
            // Assert.Equal(0, avgBeveragePrice);
            // Assert.Equal(0, maxSeafoodPrice);
            // Assert.Equal(0, linqNumStockedProductsWithPrice);

            


        }


    }
}