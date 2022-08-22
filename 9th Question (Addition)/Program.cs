class Addition
{
    private double a1, a2, a3;
    private double b1, b2, b3;
    private double c1, c2, c3;
    private double delta, d1, d2, d3;
    private double delta1, delta2, delta3;


    public void aSetValues(int[] aArray)
    {
        this.a1 = aArray[0];
        this.a2 = aArray[0];
        this.a3 = aArray[0];
    }

    public void bSetValues(int[] bArray)
    {
        this.b1 = bArray[0];
        this.b2 = bArray[0];
        this.b3 = bArray[0];
    }

    public void cSetValues(int[] cArray)
    {
        this.c1 = cArray[0];
        this.c2 = cArray[0];
        this.c3 = cArray[0];
    }

    public void dSetValues(int[] dArray)
    {
        this.d1 = dArray[0];
        this.d2 = dArray[0];
        this.d3 = dArray[0];
    }

    private void matcDelta ()
    {
        this.delta = a1 * b2 * c3 + b1 * c2 * a3 + c1 * a2 * b3 - c1 * b2 * a3 - b1 * a2 * c3 - a1 * c2 * b3;
    }

    private void matcDelta123 ()
    {
        this.delta1 = d1 * b2 * c3 + b1 * c2 * d3 + c1 * d2 * b3 - c1 * b2 * d3 - b1 * d2 * c3 - d1 * c2 * b3;
        this.delta2 = a1 * d2 * c3 + d1 * c2 * a3 + c1 * a2 * d3 - c1 * d2 * a3 - d1 * a2 * c3 - a1 * c2 * d3;
        this.delta3 = a1 * b2 * d3 + b1 * d2 * a3 + d1 * a2 * b3 - d1 * b2 * a3 - b1 * a2 * d3 - a1 * d2 * b3;
    }

    public void resultSystem()
    {
        double x, y, z;

        matcDelta();
        matcDelta123();

        if (delta != 0)
        {
            x = delta1 / delta;
            y = delta2 / delta;
            z = delta3 / delta;
            Console.WriteLine("x = {0}; y = {1}; z = {2}", x, y, z);
        }
        else Console.WriteLine("Ошибка. Определитель равен нулю.");

    }
}