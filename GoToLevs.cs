using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevs : MonoBehaviour
{
    public void GoToLevMenu() {
        SceneManager.LoadScene("LevMenu");
    }
}
