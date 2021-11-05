using Circle;
using NUnit;
using NUnit.Framework;

namespace Circle.Test
{
    [TestFixture]
    public class CircleTest
    {

        [Test]
        public void GetRadiusOfCircleLessOrEqual()
        {
            int rad = 6;
            var r = Circle.GetRadius();
            Assert.LessOrEqual(r, rad);
        }


        [Test]
        public void SetRadiusAreNotEqual()
        {
            int rad = 2;
            Circle.SetRadius(rad);
            Assert.AreNotEqual(rad, 0);
        }


        [Test]
        public void GetAreaOfCircleGreaterOrEqual()
        {
            int rad = 5;
            Circle.SetRadius(rad);
            int r = (int)Circle.GetArea();
            Assert.GreaterOrEqual(r, 78);
        }

        [Test]
        public void GetCircumferenceOfCircleIsLess()
        {
            int rad = 2;
            Circle.SetRadius(rad);
            int r = (int)Circle.GetCircumference();
            Assert.Less(r, 20);
        }

        [Test]
        public void GetCircumferenceOfCircleAreEqual()
        {
            int rad = 5;
            Circle.SetRadius(rad);
            int r = (int)Circle.GetCircumference();
            Assert.AreEqual(r, 31);
        }
    }
}

