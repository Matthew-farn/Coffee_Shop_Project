//This is our interface
//It acts as a socket between 2 bits of code
//Think of it like a type c charger
//It doesn't matter what it is plugged into, as long as:
//It has a type c port
public interface IClickable
{
    //and then it will look for this piece of code
    //on the other code block
    void OnClick();
}