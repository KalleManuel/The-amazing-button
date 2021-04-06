using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // ThePoints = Create an array of possible points to earn (24 in total): 100, 200, 300, 400 and so on until 2400
    // DistrubutePoints() = Scramble these numbers and distrubute them in a new array (numPlaceHolders) with an determined order from 1 - 24
    // A number can't occour more then once in the new array
    // Thegame should have an active score that changes every hour starting with numPlaceHoldes[0] and ending with numPlaceHoldes[23] 
    // Every new day (at 00.00) Scramblethe numbers again


    public int[] thePoints;
    public int[] numPlaceHolders;
    public int gameLenght = 24;

    // if the player pushes the button they will gain the score assigned to that hour.
    // The score gaind shall be added to a total score.
    // the player can only push the button twice each hour
    // The player can only puch the button ten times a day
    // Theplayer shall be able to see they score in a UI.

    public Button theButton;
    public int theScore;
    public bool canPushButton;
    public int tries;



    // Start is called before the first frame update
    void Start()
    {
        DoTheShuffle();

       // DistributePoints();
    }

    // Update is called once per frame
    void Update()
    {
        
         
                
                
     }
    

    public void DoTheShuffle()
    {
        int replacements = Random.Range(100, 1000);

        for (int i = 0; i < replacements; i++)
        {
            int A = Random.Range(0, thePoints.Length);
            int B = Random.Range(0, thePoints.Length);

            int a = thePoints[A];
            int b = thePoints[B];
            int c = thePoints[A];

            a = b;
            b = c;

            thePoints[A] = a;
            thePoints[B] = b;
        }
    }
}

