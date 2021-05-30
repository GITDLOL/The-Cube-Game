using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpSys : MonoBehaviour
{
    public Rigidbody rb;

    void OnTriggerEnter() {
        Debug.Log("TEST");
        rb.AddForce(0, 10000 * Time.deltaTime, 0);
        if (Input.GetKey(KeyCode.Space)) {
            rb.AddForce(0, 60000 * Time.deltaTime, 0);
        }
    }
}
