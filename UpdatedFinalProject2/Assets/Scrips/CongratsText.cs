using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CongratsText : MonoBehaviour
{
    public CompassManager Compass_Manager;
    public TextMeshProUGUI endText;

    // Start is called before the first frame update
    void Start()
    {
        endText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Compass_Manager.NumOfCompsLeft == 0)
        {
            endText.text = "Congratulations!\n\nYou found all the compasses!";
        }
    }
}
