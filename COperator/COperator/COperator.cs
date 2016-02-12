using System;
class COperator
{

    
    public COperator(int myValue)
    {
        Value = myValue;
    }

    //Overdefinition af operator "+"
    public static COperator operator +(COperator x, COperator y)
    {
        return (new COperator(x.Value + y.Value));
    }

    //Overdefinition af operator "++"
    public static COperator operator ++(COperator x)
    {
        return (new COperator(++x.Value));
    }

    public int GetValue()
    {
        return (Value);
    }

    private int Value;
}

class COverdefOper
{
    static void Main(String[] args)
    {
        //Lav to instanser af COperatorClass
        COperator myObjy = new COperator(3);
        COperator myObjz = new COperator(4);

        COperator myObjx = myObjy + myObjz;
        ++myObjx;

        Console.WriteLine("myObjx = {0}", myObjx.GetValue());//Output : myObjx = 8
    }
}
