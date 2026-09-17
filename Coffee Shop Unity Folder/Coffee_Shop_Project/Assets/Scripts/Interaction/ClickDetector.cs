//This is Script A
using UnityEngine;

public class ClickDetector : MonoBehaviour
{

    //Every frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        //If the left mouse button is clicked then do the stuff below
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //This is tagged "Main Camera" on the default camera - only one camera should be the "Main Camera"
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                IClickable clickable = hit.collider.GetComponent<IClickable>();
                
                clickable?.OnClick();
                //calls the interface "IClickable"
            }
        }
    }
}