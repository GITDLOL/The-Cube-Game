using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColorToPurple : MonoBehaviour
{
    public Material playermat;
    public GameObject player;

    // Update is called once per frame
    public void ChangeColorAgain()
    {
        Color colornewset = new Color(128,0,128);
        playermat.SetColor("_Color", colornewset);
    }
}
