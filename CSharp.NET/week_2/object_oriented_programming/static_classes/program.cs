double area = Mathematics.RectangleArea(4, 6);
Console.WriteLine(area);

static class Mathematics
{
    public static double RectangleArea(double width, double height)
    {
        return width * height;
    }
}
