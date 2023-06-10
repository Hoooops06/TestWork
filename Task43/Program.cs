static void Program()
{
    double b1 = 2;
    double k1 = 5;

    double b2 = 4;
    double k2 = 9;

    double x;
    double y;

    void ProgramMath()
    {
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}: \nresult = ( x {x}; y {y})");
    }
    ProgramMath();
}
Program();
