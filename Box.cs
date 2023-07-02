namespace ConsoleApp
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box() : this(1, 1, 1) { }

        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth,
            };
            return newBox;
        }
        // Through operator overloading you can allow users to interact with your custom objects in interesting ways
        // You can overload +, -, *, /, %, !, ==, !=, >, <, >=, <=, ++ and --

        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth,
            };
            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length)
            && (box1.Width == box2.Width)
            && (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length)
            || (box1.Width != box2.Width)
            || (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        // You define how your object is converted into a string by overridding ToString
        public override string ToString()
        {
            return String.Format($"\nBox w/ following dimensions\n\tHeight : {Length}\n\tWidth : {Width}\n\tBreadth : {Breadth}");
        }


        // You can convert from a Box into an int like this even though this wouldn't make sense
        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        // Convert from an int to a Box
        public static implicit operator Box(int i)
        {
            // Return a box with the lengths all set to the int passed
            return new Box(i, i, i);
        }
    }
}
