using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises_triangle_program
{
    public class Triangle_checker
    {
        public Triangle_checker()
        {
        }

        /// <summary>
        /// Will identify if the 3 side will give a valid triangle, if valid it will tell what type of triangle it is.
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public string IdentifyTriangle(int side1, int side2, int side3)
        {
            if (IsVaildInput(side1, side2, side3))
            {
                // All three sides has equal length
                if (side1 == side2 && side2 == side3)
                {
                    return "This is an Equilateral triangle";
                }
                // Two sides has equal length
                else if (side1 == side2 || side2 == side3 || side1 == side3)
                {
                    return "This is an Isosceles triangle";
                }
                // All sides has different length
                else
                {
                    return "This is a Scalene triangle";
                }
            }

            return "This is not a valid triangle";
        }

        /// <summary>
        /// Check to see if the 3 side can form a triangle
        /// </summary>
        /// <returns></returns>
        private bool IsVaildInput(int a, int b, int c)
        {
            //The triangle inequality Theorem stats that if this is true, then the three side from a valid triangle
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }
    }
}