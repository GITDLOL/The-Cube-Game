using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel5 : MonoBehaviour
{
    public void GoToOtherOtherLevel() {
        SceneManager.LoadScene("Level 4");
    }
}
