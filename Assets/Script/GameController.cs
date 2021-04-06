using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public int[] thePoints;
    public int[] numPlaceHolders;
    public int theScore;
    public int tries;
    public int gameLenght = 24;

    public int days;
    public bool gameOn;

    public Button theButton;

    // Start is called before the first frame update
    void Start()
    {
        
        DistributePoints();
    }

    // Update is called once per frame
    void Update()
    {
        
         
                
                
     }
    

    public void DistributePoints()
    {
        for (int i = 0; i < gameLenght; i++)
        {
            int randomNumber = thePoints[Random.Range(0, thePoints.Length - 1)];

            if (thePoints[randomNumber] == 0)

            numPlaceHolders[i] = thePoints[Random.Range(0, thePoints.Length - 1)];
        }
    }
}
