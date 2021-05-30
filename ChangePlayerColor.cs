using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColor : MonoBehaviour
{
    public Material playermat;
    public GameObject player;

    // Update is called once per frame
    public void ChangeColor()
    {
        Color colornewset = new Color(0, 0, 255);
        playermat.SetColor("_Color", colornewset);
    }
}
