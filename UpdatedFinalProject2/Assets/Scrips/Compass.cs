using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Compass : MonoBehaviour
{
    public CompassManager Compass_Manager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickedUp()
    {
        StartCoroutine(ObjectPickedUp());
    }

    IEnumerator ObjectPickedUp()
    {
        Compass_Manager.NumOfCompsLeft -= 1; //Update the number
        //Update the UI Here
            //UIs have their own update script due to connection bugging

        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);

    }
}
