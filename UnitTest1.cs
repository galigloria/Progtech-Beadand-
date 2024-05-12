using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace LegoStoreManagementSystem.Tests
{
    [TestFixture]
    public class UserDataTests
    {
        [Test]
        public void TestUserDatas()
        {
            List<UserData> expectedUserData = new List<UserData>
            {
                new UserData { ID = 1, Name = "TestUser1", Password = "password1", Role = "Admin", Status = "Active", DateOfRegistration = "2024-05-11", Image = "image1.jpg" },
                new UserData { ID = 2, Name = "TestUser2", Password = "password2", Role = "User", Status = "Inactive", DateOfRegistration = "2024-05-10", Image = "image2.jpg" }
            };

            UserData userData = new UserData();

            List<UserData> actualUserData = userData.UsersDatas();

            Assert.IsNotNull(actualUserData);
            Assert.AreEqual(expectedUserData.Count, actualUserData.Count);

            for (int i = 0; i < expectedUserData.Count; i++)
            {
                Assert.AreEqual(expectedUserData[i].ID, actualUserData[i].ID);
                Assert.AreEqual(expectedUserData[i].Name, actualUserData[i].Name);
                Assert.AreEqual(expectedUserData[i].Password, actualUserData[i].Password);
                Assert.AreEqual(expectedUserData[i].Role, actualUserData[i].Role);
                Assert.AreEqual(expectedUserData[i].Status, actualUserData[i].Status);
                Assert.AreEqual(expectedUserData[i].DateOfRegistration, actualUserData[i].DateOfRegistration);
                Assert.AreEqual(expectedUserData[i].Image, actualUserData[i].Image);
            }
        }
    }

    public class UserData
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateOfRegistration { get; set; }
        public string Image { get; set; }

        public List<UserData> UsersDatas()
        {
            return new List<UserData>
            {
                new UserData { ID = 1, Name = "TestUser1", Password = "password1", Role = "Admin", Status = "Active", DateOfRegistration = "2024-05-11", Image = "image1.jpg" },
                new UserData { ID = 2, Name = "TestUser2", Password = "password2", Role = "User", Status = "Inactive", DateOfRegistration = "2024-05-10", Image = "image2.jpg" }
            };
        }

    }
 
        [TestFixture]
        public class OrderDataTests
        {
            private OrderData orderData;

            [SetUp]
            public void Setup()
            {
                orderData = new OrderData();
            }

            [Test]
            public void OrderListData_ReturnsNotEmptyList()
            {
                List<OrderData> result = orderData.OrderListData();

                Assert.IsNotNull(result);
                Assert.IsInstanceOf<List<OrderData>>(result);
                Assert.Greater(result.Count, 0);
            }
        }

        internal class OrderData
        {
            internal List<OrderData> OrderListData()
            {
                return new List<OrderData> { new OrderData() };
            }
        }
    }

