using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLevel6 : MonoBehaviour
{
    public void GoToAtherLevel() {
        SceneManager.LoadScene("Level 5");
    }
}
