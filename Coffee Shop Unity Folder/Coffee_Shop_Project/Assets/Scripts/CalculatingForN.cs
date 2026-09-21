using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    // creates a private integer called _n with its value being 24
    private int _n = 24;

    //when the script starts it will set _n's value from 24 to 4 and call the CalculateForN method where itts value is the same as _n times 3
    void Start()
    {
        _n = 4;
        CalculateForN(_n * 3);

    }

    //Puts a message in the debug menu saying that N = whatever value _n is 
    private void CalculateForN(int _n)
    {
        Debug.Log("N = " + _n);
    }
}
