namespace Inheritance
{
  public class Shape{
    private float length;
    protected float breadth;
    public Shape(){
        length=0;
        breadth=0;
    }
    public Shape(float l,float b){
        this.length=l;
        this.breadth=b;
        Console.WriteLine("class base cunstroctor");
    }
    public void display(){
        float area=length*breadth;
        Console.WriteLine($"Area is:{area}");
    }
  }
}
