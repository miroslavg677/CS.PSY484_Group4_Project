using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUpdate : MonoBehaviour
{
    public TextMeshProUGUI NumText;
    public TextMeshProUGUI endText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateNum(int N)
    {
        NumText.text = N.ToString();
    }
    public void DisplayGameOverMessage()
    {
        endText.text = "Congratulations!\n\nYou found all the compasses!";
    }
}
