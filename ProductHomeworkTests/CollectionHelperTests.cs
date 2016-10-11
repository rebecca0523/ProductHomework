using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductHomework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedObjects;





namespace ProductHomework.Tests
{
    [TestClass()]
    public class CollectionHelperTests
    {
        //[TestMethod()]
        //public void GetGroupSumByFieldTest()
        //{
        //    Assert.Fail();
        //}

        [TestMethod()]
        public void GetResultSetTest_count_3_field_Cost()
        {
            //arange
            var target = new CollectionHelper();
            List<Product> dataSource = GetTestDataSource();
            var countInGroup = 3;
            var fieldName = "Cost";
            var expected = new int[] { 6, 15, 24, 21 };

            //act
            IEnumerable<int> actual = target.GetGroupSumByField(dataSource, countInGroup, fieldName);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod()]
        public void GetResultSetTest_count_4_field_Revenue()
        {
            //arange
            var target = new CollectionHelper();
            List<Product> dataSource = GetTestDataSource();
            var countInGroup = 4;
            var fieldName = "Revenue";
            var expected = new int[] { 50, 66, 60 };

            //act
            IEnumerable<int> actual = target.GetGroupSumByField(dataSource, countInGroup, fieldName);

            //assert
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        private static List<Product> GetTestDataSource()
        {
            return new List<Product>
            {
                new Product { Id=1, Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2, Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3, Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4, Cost=4,Revenue=14,SellPrice=24},
                new Product { Id=5, Cost=5,Revenue=15,SellPrice=25},
                new Product { Id=6, Cost=6,Revenue=16,SellPrice=26},
                new Product { Id=7, Cost=7,Revenue=17,SellPrice=27},
                new Product { Id=8, Cost=8,Revenue=18,SellPrice=28},
                new Product { Id=9, Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=10, Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=11, Cost=11,Revenue=21,SellPrice=31},
            };
        }
    }

    internal class Product
    {
        public int Cost { get; internal set; }
        public int Id { get; internal set; }
        public int Revenue { get; internal set; }
        public int SellPrice { get; internal set; }
    }
}