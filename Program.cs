using System;
class Ex27
{
    static void Main()
    {
        Console.WriteLine("直方体");
        Box box = new Box(InputFloat("幅"), InputFloat("高さ"),InputFloat("奥行"));
        Console.WriteLine($"表面積は{box.GetSurface()}");
        Console.WriteLine($"体積は{box.GetVolume()}");

        Console.WriteLine("円柱");
        Cylinder cylinder= new Cylinder(InputFloat("底面の半径"), InputFloat("高さ"));
        Console.WriteLine($"表面積は{cylinder.GetSurface()}");
        Console.WriteLine($"体積は{cylinder.GetVolume()}");

        Console.WriteLine("球");
        Sphere sphere = new Sphere(InputFloat("半径"));
        Console.WriteLine($"表面積は{sphere.GetSurface()}");
        Console.WriteLine($"体積は{sphere.GetVolume()}");

        Console.WriteLine("三角柱");
        TriangularPrism triangularPrism = new TriangularPrism(InputFloat("三角形の底辺"),
            InputFloat("三角形の高さ"),InputFloat("三角柱の高さ"));
        Console.WriteLine($"表面積は{triangularPrism.GetSurface()}");
        Console.WriteLine($"体積は{triangularPrism.GetVolume()}");


    }

    static float InputFloat(string outputstring)
    {
        float input;
        while (true)
        {
            Console.Write(outputstring);
            if(float.TryParse(Console.ReadLine(), out input))
            {
                return input;
                Console.WriteLine("エラー");
            }
        }

    }
    class Box
    {
        private float width, height, depth;
        public Box(float width, float height, float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        public float GetVolume()
        {
            return width * height * depth;
        }

        public float GetSurface()
        {
            return (width * height + height * depth + depth * width) * 2;
        }

    }
    class Cylinder
    {
        private float bottom, height;
        public Cylinder(float bottom, float height)
        {
            this.bottom = bottom;
            this.height = height;
        }
        public float GetVolume()
        {
            return bottom * bottom * MathF.PI * height;
        }

        public float GetSurface()
        {
            return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI * 2.0f;
        }

    }
    class Sphere
    {
        private float radius;
        public Sphere(float radius)
        {
            this.radius = radius;
        }
        public float GetVolume()
        {
            return ( 4.0f / 3.0f ) * MathF.PI * radius * radius * radius;
        }

        public float GetSurface()
        {
            return radius * radius * MathF.PI * 4;
        }
    }
    class TriangularPrism
    {
        private float triangleHeight, triangleBottom, height;
        public TriangularPrism(float triangleHeight,float triangleBottom,float height)
        {
            this.triangleHeight = triangleHeight;
            this.triangleBottom = triangleBottom;
            this.height = height;
        }
        public float GetVolume()
        {
            return (triangleHeight * triangleBottom /2 )* height;
        }

        public float GetSurface()
        {
            return (float)((triangleHeight * triangleBottom / 2) * 2 +(triangleHeight * height 
                + triangleBottom * height 
                + Math.Sqrt(triangleHeight * triangleHeight + triangleBottom * triangleBottom)* height));
        }

    }
}
