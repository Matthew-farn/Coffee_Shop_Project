using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    //camelCasing i.e Variables
    public int coffeeAmountOrdered;

    public float totalOrderAmount;

    private float _costOfCoffee = 3.5f;

    // Pascal Casing i.e Method, Classes, Properties
    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderAmount = coffeeAmountOrdered * _costOfCoffee;
        Debug.Log("Your Order Amount Today Is" + "£" + totalOrderAmount);
    }
}
//Access Modifiers
//void -> private void
//void
//public void -> public void

//if public, can be seen outside of class (script)
//if private, cannot be seen outside of class (script)
