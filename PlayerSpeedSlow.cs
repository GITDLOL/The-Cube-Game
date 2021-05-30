using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpeedSlow : MonoBehaviour
{
    public Rigidbody rbfour;

   void OnTriggerEnter() {
      Time.timeScale = 0.3f;
   }
}
