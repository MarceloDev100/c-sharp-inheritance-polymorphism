using Activity3.Entities.Enums;

namespace Activity3.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        /*
          Abstract methods doesn't have implementation.
          They must be implemented in concrete subclasses.
          When a class method is abstract, the current type must be abstract too. 
         */
        public abstract double Area();
       
    }
}
