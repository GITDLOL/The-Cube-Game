using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSys : MonoBehaviour
{
   void OnTriggerEnter() {
       Debug.Log("TEST");
       FindObjectOfType<GameManagement>().DisableCoin();
   }
}
