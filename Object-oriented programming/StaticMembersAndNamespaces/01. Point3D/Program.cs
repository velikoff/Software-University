using System;


class TestProblems
{
    static void Main()
    {
        //01. Point3D
      
        Point p1 = new Point(1, 2, 3);
        Point p2 = new Point(3.4, 4.66, 5.55);

        Console.WriteLine(p1);
        Console.WriteLine(p2);
        Console.WriteLine(Point.StartPoint);
        Console.WriteLine();

        //02. Distance Calculator

        double distance = DistanceCalcolator.CalculateDistance(p1, p2);
        Console.WriteLine(distance);
        Console.WriteLine();

        //03. Paths

        Path path = new Path(p1, p2, Point.StartPoint);
        Console.WriteLine("Save path: {0}", path);
        Storage.SavePathInFile("path.txt", path);
        Path loadPath = Storage.LoadPathOfFile("path.txt");
        Console.WriteLine("Load path: {0}", loadPath);
    }
}