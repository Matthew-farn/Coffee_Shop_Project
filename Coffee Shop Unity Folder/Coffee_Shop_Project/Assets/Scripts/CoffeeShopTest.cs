using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    Random rnd = new Random();
    public int coffeeSold = rnd.Next(1, 13);

    public float coffeePrice = 3.50f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Coffees sold: " + coffeeSold);
        coffeeSold++;
        Debug.Log("Oops, I actually sold " + coffeeSold + " coffees.");

    }

    void AddCoffee()
    {
        coffeeSold += 1;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
