using HW3EX1B4.Exercise_2;
using HW3EX1B4.Model;
using HW3EX1B4.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace HW3EX1.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestExceptionisThrownByMethod()
        {
            var pointSaleOrder = new PointOfSaleOrder();
            var cart = new Cart();
            try
            {
                pointSaleOrder.NotifyCustomer(cart);
            }
            catch (Exception ex)
            {
                Assert.Fail("Expected no exception" + ex.Message);
            }
            
        }

        [TestMethod]
        public void TestCashMethod()
        {
            var order = new CashSaleOrder();
            var cart = new Cart();
            Exception ex = Assert.ThrowsException<InsufficientInventoryException>(() => order.Checkout(cart, ));
        }
            [TestMethod]
        public void ChargeCardIsInstanceTest()
        {
            //Arrange
            List<PaymentGateway> expectedCreditials = new List<PaymentGateway>();

            //act
            expectedCreditials.Add(new PaymentGateway()
            {
                Credentials = "account creditial",
                CardNumber = "4567",
                ExpiresMonth = "January",
                NameOnCard = "Faizan",
                AmountToCharge = 1000.00m
            });

            //Assert
            CollectionAssert.AllItemsAreInstancesOfType(expectedCreditials, typeof(PaymentGateway));

        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangle()
        {
            Shape myShape = new Rectangle() { Height = 4, Width = 5 };
            Assert.AreEqual(20, myShape.Area());
        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
                             {
                                 new Rectangle {Height = 4, Width = 5},
                                 new Square {SideLength = 3}
                             };
            var areas = new List<int>();
            foreach (Shape shape in shapes)
            {
                areas.Add(shape.Area());
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
        [TestMethod]
        public void SixFor2X3Rectangle()
        {
            var myRectangle = new Rectangle { Height = 2, Width = 3 };
            Assert.AreEqual(6, AreaCalculator.CalculateRectArea(myRectangle));
        }

        [TestMethod]
        public void NineFor3X3Square()
        {
            var mySquare = new Square() { Height = 3 };
            Assert.AreEqual(9, AreaCalculator.CalculateSquareArea(mySquare));
        }

        [TestMethod]
        public void TwentyFor4X5RectangleFromSquare()
        {
            Rectangle newRectangle = new Square();
            newRectangle.Width = 4;
            newRectangle.Height = 5;
            Assert.AreEqual(20, AreaCalculator.CalculateRectArea(newRectangle));
        }


    }
}
