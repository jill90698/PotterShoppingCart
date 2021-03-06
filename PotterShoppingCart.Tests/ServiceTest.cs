﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PotterShoppingCart.Tests
{
    /// <summary>
    /// Summary description for ServiceTest
    /// </summary>
    [TestClass]
    public class ServiceTest
    {
        public ServiceTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Test_PotterShoppingCart_Only_1_first_book_should_be_100()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);

            decimal expected = 100;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_and_1_second_book_should_be_190()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 1);

            decimal expected = 190;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_and_1_second_and_1_third_book_should_be_270()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 1);
            order.Add(PotterEpisode.Third, 1);

            decimal expected = 270;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_and_1_second_and_1_third_and_1_fourth_book_should_be_320()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 1);
            order.Add(PotterEpisode.Third, 1);
            order.Add(PotterEpisode.Fourth, 1);

            decimal expected = 320;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_1_second_1_third_1_fourth_1_fifth_book_should_be_375()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 1);
            order.Add(PotterEpisode.Third, 1);
            order.Add(PotterEpisode.Fourth, 1);
            order.Add(PotterEpisode.Fifth, 1);

            decimal expected = 375;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_1_second_2_third_book_should_be_370()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 1);
            order.Add(PotterEpisode.Third, 2);

            decimal expected = 370;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_PotterShoppingCart_1_first_2_second_2_third_book_should_be_460()
        {
            //Arrange
            var target = new PotterShoppingCart();

            var order = new Dictionary<PotterEpisode, int>();
            order.Add(PotterEpisode.First, 1);
            order.Add(PotterEpisode.Second, 2);
            order.Add(PotterEpisode.Third, 2);

            decimal expected = 460;

            //Act
            decimal actual = target.ComputeOrderAmount(order);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
