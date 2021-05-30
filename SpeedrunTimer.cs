using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedrunTimer : MonoBehaviour
{
    public Text text;
    float startTime = 60f;
    bool isDoneWithIf = false;

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        text.text = startTime.ToString();

       if (isDoneWithIf = false) {
            if (startTime >= 60) {
                int minutes = 0;
                minutes++;
                text.text = minutes + ":" + startTime.ToString();
                startTime -= 60;

                isDoneWithIf = true;
            }
       }
    }
}
