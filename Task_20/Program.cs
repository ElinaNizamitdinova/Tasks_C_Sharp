Console.WriteLine("Введите координаты первой точки, сначало x, затем y");
double x1 = Convert.ToInt32(Console.ReadLine());
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки, сначало x, затем y");
double x2 = Convert.ToInt32(Console.ReadLine());
double y2 = Convert.ToInt32(Console.ReadLine());
double SegmentLenght2 =Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2);
double SegmentLenght = Math.Sqrt(SegmentLenght2);
Console.WriteLine(SegmentLenght);
