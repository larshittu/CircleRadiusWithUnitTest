using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private static int radius;

        /// <summary>
        /// Present circle Constructor
        /// </summary>
        public Circle()
        {
            radius = 1;
        }

        /// <summary>
        /// Circle Constructor for User to set Circle Radius
        /// </summary>
        /// <param name="Radius"></param>
        public Circle(int Radius)
        {
            radius = Radius;
        }

        /// <summary>
        /// Get present Circle Radius
        /// </summary>
        /// <returns>Circle Radius</returns>
        public static int GetRadius()
        {
            return radius;
        }

        /// <summary>
        /// Set new Circle Radius
        /// </summary>
        /// <returns>circle new radius</returns>
        public static void SetRadius(int Radius)
        {
            radius = Radius;
        }

        /// <summary>
        /// Get present circle Circumference
        /// </summary>
        /// <returns>circle Circumference</returns>
        public static double GetCircumference()
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }


        /// <summary>
        /// Get new circle area
        /// </summary>
        /// <returns>circle area</returns>
        public static double GetArea()
        {
            double Area = Math.PI * radius * radius;
            return Area;
        }

    }
}
