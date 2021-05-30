using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePlayerColorToGreen : MonoBehaviour
{
    public Material playermat;
    public GameObject player;

    public void ChangePlayerColorAgainAgain() {
        Color colornewnewset = new Color(0,128,0);
        playermat.SetColor("_Color", colornewnewset);
    }
}
