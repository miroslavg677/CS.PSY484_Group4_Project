using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingText : MonoBehaviour
{
    public TMP_Text remainingText;
    public CompassManager Compass_Manager;

    // Start is called before the first frame update
    void Start()
    {
        remainingText = GetComponent<TMP_Text>();
       // remainingText.text = Compass_Manager.NumOfCompsLeft.ToString() + "            Remain";
    }
    //10            Remain
    // Update is called once per frame
    void Update()
    {
        //remainingText.text = Compass_Manager.NumOfCompsLeft.ToString() + "            Remain";
    }
}
