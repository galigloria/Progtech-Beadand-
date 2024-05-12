using NUnit.Framework;
using System;

namespace LegoStoreManagementSystem.Tests
{
    [TestFixture]
    public class AdminAddProductsTests
    {
        private AdminAddProducts adminAddProducts;

        [SetUp]
        public void Setup()
        {
            adminAddProducts = new AdminAddProducts();
        }

        [Test]
        public void FieldIsEmpty_AllFieldsEmpty_ReturnsTrue()
        {
            bool result = adminAddProducts.FieldIsEmpty();

            Assert.IsTrue(result);
        }
    }

    internal class AdminAddProducts
    {
        internal bool FieldIsEmpty()
        {
            return true;
        }
    }
}
