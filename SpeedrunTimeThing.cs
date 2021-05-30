using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedrunTimeThing : MonoBehaviour
{
    float currentTime = 0f;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        Debug.Log(currentTime);
    }
}
