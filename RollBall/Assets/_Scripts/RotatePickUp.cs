using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePickUp : MonoBehaviour
{

    /* By definition, Time.deltaTime is the completion time in seconds since the last frame.
    This helps us to make the game frame-independent. That is, regardless of the fps, the
    game will be executed at the same speed. Let’s understand what this means: */

    // Will run automatically in each frame of the game
    void Update()
    {
        // Rotate the pickups to make the game more appealing for the user
        transform.Rotate(new Vector3(15, 20, 45) * Time.deltaTime);
    }

    public string[,] newArray;
    void Start()
    {
        newArray = new string[4, 4];
        newArray[0, 1] = "X";
        newArray[0, 2] = "W";
        newArray[1, 1] = "Z";
        newArray[3, 2] = "Y";

        string str = "";
        for (int a = 0; a < 4; a++)
        {
            for (int b = 0; b < 4; b++)
            {
                if (newArray[a, b] != null)
                {
                    str += "||" + newArray[a, b];
                }
                else
                {
                    str += "||--";
                }
            }
            str += "||" + "\n";
        }
        print(str);
    }


}

