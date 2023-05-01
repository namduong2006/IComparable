using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ComperableCircle[] circles = new ComperableCircle[3];
            //circles[0] = new ComperableCircle(3.6);
            //circles[1] = new ComperableCircle();
            //circles[2] = new ComperableCircle(3.5, "indigo", false);

            //Console.WriteLine("Pre-sorted:");
            //foreach (ComperableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}

            //Array.Sort(circles);

            //Console.WriteLine("After-sorted:");
            //foreach (ComperableCircle circle in circles)
            //{
            //    Console.WriteLine(circle);
            //}
            //Rectangle[] rectangles = new Rectangle[3];
            //rectangles[0] = new Rectangle(4, 9);
            //rectangles[1] = new Rectangle();
            //rectangles[2] = new Rectangle(5, 7, "Red", false);
            //Console.WriteLine("Pre-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}
            
            //Array.Sort(rectangles);

            //Console.WriteLine("After-sorted:");
            //foreach (Rectangle rectangle in rectangles)
            //{
            //    Console.WriteLine(rectangle);
            //}
            /////////////////////////////////////////////////////////////
            Circle[] circles = new Circle[3];
            circles[0] = new Circle(3.6);
            circles[1] = new Circle();
            circles[2] = new Circle(3.5, "indigo", false);

            Console.WriteLine("Pre-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }

            IComparer<Circle> circleComparator = new CircleComparer();
            Array.Sort(circles, circleComparator);

            Console.WriteLine("After-sorted:");
            foreach (Circle circle in circles)
            {
                Console.WriteLine(circle);
            }
            Rectangle[] rectangles = new Rectangle[3];
            rectangles[0] = new Rectangle(4,9);
            rectangles[1] = new Rectangle();
            rectangles[2] = new Rectangle(5,7,"Red",false);
            Console.WriteLine("Pre-sorted:");
            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine(rectangle);
            }
            IComparer<Rectangle> rectanglesComparator = new RectangleComparer();
            Array.Sort(rectangles, rectanglesComparator);

            Console.WriteLine("After-sorted:");
            foreach (Rectangle rectangle in rectangles)
            {
                Console.WriteLine(rectangle);
            }
            Console.ReadLine();
        }
    }
}
