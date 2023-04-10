namespace PudelkoLibrary;

public class Pudelko
{
    public double A { get; init; }
    public double B { get; init; }
    public double C { get; init; }
    public UnitOfMeasure Unit { get; init; }
    
    public Pudelko(double a ,UnitOfMeasure unit)
    {
        switch (unit)
        {
            case UnitOfMeasure.meter:
                A = Math.Floor(a * 1000) / 1000.0;
                B = 0.1;
                C = 0.1;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.centimeter:
                A = Math.Floor(a * 100) / 10000.0;
                B = 0.1;
                C = 0.1;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.milimeter:
                A = Math.Floor(a) / 1000.0;
                B = 0.1;
                C = 0.1;
                Unit = unit; 
                break;
        }
        
    }
    public Pudelko(double a , double b , UnitOfMeasure unit)
    {
        switch (unit)
        {
            case UnitOfMeasure.meter:
                A = Math.Floor(a * 1000) / 1000.0;
                B = Math.Floor(b * 1000) / 1000.0;
                C = 0.1;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.centimeter:
                A = Math.Floor(a * 100) / 10000.0;
                B = Math.Floor(b * 100) / 10000.0;
                C = 0.1;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.milimeter:
                A = Math.Floor(a) / 1000.0;
                B = Math.Floor(b) / 1000.0;
                C = 0.1;
                Unit = unit; 
                break;
        }
        
    }
    public Pudelko(double a = 0.1, double b = 0.1, double c = 0.1, UnitOfMeasure unit = UnitOfMeasure.meter)
    {
        switch (unit)
        {
            case UnitOfMeasure.meter:
                A = Math.Floor(a * 1000) / 1000.0;
                B = Math.Floor(b * 1000) / 1000.0;
                C = Math.Floor(c * 1000) / 1000.0;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.centimeter:
                A = Math.Floor(a * 100) / 10000.0;
                B = Math.Floor(b * 100) / 10000.0;
                C = Math.Floor(c * 100) / 10000.0;
                Unit = unit; 
                break;
            
            case UnitOfMeasure.milimeter:
                A = Math.Floor(a) / 1000.0;
                B = Math.Floor(b) / 1000.0;
                C = Math.Floor(c) / 1000.0;
                Unit = unit; 
                break;
        }
        
    }
}