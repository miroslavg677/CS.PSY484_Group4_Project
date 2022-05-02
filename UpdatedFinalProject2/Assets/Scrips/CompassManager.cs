using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CompassManager : MonoBehaviour
{
    public int NumOfCompsLeft;
    // Start is called before the first frame update
    void Start()
    {
        NumOfCompsLeft = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(NumOfCompsLeft == 0)
        {
            //Display game over message
            StartCoroutine(GameOverRoutine());
        }
        
    }

    IEnumerator GameOverRoutine()
    {
        //Activate the end screen

        yield return new WaitForSeconds(30); //Wait for 30 seconds

        Application.Quit(); //Exit the game
    }
}
