using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Compass : MonoBehaviour
{
    public CompassManager Compass_Manager;
    public ScoreUpdate Score_Update;
    
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
        Compass_Manager.NumOfCompsLeft --; //Update the number
        Score_Update.UpdateNum(Compass_Manager.NumOfCompsLeft); //Update the UI
        Destroy(this.gameObject);
    }

    IEnumerator ObjectPickedUp()
    {
        Compass_Manager.NumOfCompsLeft -= 1; //Update the number
        Score_Update.UpdateNum(Compass_Manager.NumOfCompsLeft); //Update the UI
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);

    }
}
