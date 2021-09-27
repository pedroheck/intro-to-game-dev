using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour {

    float roundStartDelayTime = 3;
    
    float roundStartTime;
    int waitTime;
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Press the spacebar once you think the allotted time is up.");

        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted) // If player presses the spacebar
        {
            InputRecieved();   
        }
    }

    void InputRecieved()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("You waited for " + playerWaitTime + " seconds. That's " + error + " seconds off. " + GenerateMessage(error));

        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error < .15f)
        {
            message = "Outstanding!";
        }
        else if (error < .75f)
        {
            message = "Exceeds Expactations.";
        }
        else if (error < 1.25f)
        {
            message = "Acceptable.";
        }
        else
        {
            message = "Dreadful.";
        }

        return message;
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;

        roundStarted = true;

        print(waitTime + " seconds.");
    }
}
