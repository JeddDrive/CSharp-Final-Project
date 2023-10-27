using JeddoreProject; //saves time for referring to classes in that namespace

namespace FinalProjectTests
{
    [TestClass]
    public class FinalProjectUnitTests
    {
        [TestMethod]
        public void Comic1PriceLess()
        {
            //testing two comics where their prices are compared
            //a -1 should be returned from the CompareTo() ftn
            //when comicOne's price is less than comicTwo's price
            //arrange
            ComicBooks comicOne = new ComicBooks();
            ComicBooks comicTwo = new ComicBooks();
            int intExpected = -1, intActual;

            //act
            comicOne.Price = 14.99m; // calls set
            comicTwo.Price = 29.99m; // calls set
            intActual = comicOne.CompareTo(comicTwo);

            //assert - 1 assert
            Assert.AreEqual(intExpected, intActual, "Invalid price amount(s). Check that productOne's price is less than " +
                "productTwo's price.");
        }

        [TestMethod]
        public void Comic1PriceMore()
        {
            //testing two comics where their prices are compared
            //a 1 should be returned from the CompareTo() ftn
            //when comicOne's price is more than comicTwo's price
            //arrange
            ComicBooks comicOne = new ComicBooks();
            ComicBooks comicTwo = new ComicBooks();
            int intExpected = 1, intActual;

            //act
            comicOne.Price = 39.99m; // calls set
            comicTwo.Price = 12.99m; // calls set
            intActual = comicOne.CompareTo(comicTwo);

            //assert - 1 assert
            Assert.AreEqual(intExpected, intActual, "Invalid price amount(s). Check that productOne's price is more than " +
                "productTwo's price.");
        }

        [TestMethod]
        public void ComicPricesEqual()
        {
            //testing two comics where their prices are compared
            //a 0 should be returned from the CompareTo() ftn
            //when comicOne's price is equal to comicTwo's price
            //arrange
            ComicBooks comicOne = new ComicBooks();
            ComicBooks comicTwo = new ComicBooks();
            int intExpected = 0, intActual;

            //act
            comicOne.Price = 6.99m; // calls set
            comicTwo.Price = 6.99m; // calls set
            intActual = comicOne.CompareTo(comicTwo);

            //assert - 1 assert
            Assert.AreEqual(intExpected, intActual, "Invalid price amount(s). Check that productOne's price is equal to " +
                "productTwo's price.");
        }
    }
}