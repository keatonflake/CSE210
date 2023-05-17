public class Fraction{
   private int _top;
   private int _bottom;

   public Fraction(){
    _top = 1;
    _bottom = 1;
   }
   public Fraction(int whole){
    _top = whole;
    _bottom = 1;
   }
   public Fraction(int top, int bottom){
    _top = top;
    _bottom = bottom;
   }

   public int GetTop(){
      return _top;
   }
    public int GetBottom(){
      return _bottom;
   }
  public void SetTop(int top){
      _top = top;
   }
    public void SetBottom(int bottom){
      _bottom = bottom;
   }
   
   public string GetFractionString(){
      return $"{_top}/{_bottom}";
   }
   public double GetDecimalValue(){
      return ((double)_top/_bottom);
   }

}
// Create a method called GetFractionString that returns the fraction in the form 3/4.
// Create a method called GetDecimalValue that returns a double that is the result of dividing the top number by the bottom number, such as 0.75.
// Verify that you can call each constructor and that you can retrieve and display the different representations for a few different fractions. For example, you could try:
