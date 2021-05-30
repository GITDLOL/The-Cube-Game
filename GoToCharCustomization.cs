using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCharCustomization : MonoBehaviour
{
    public void GoToCharCustomize() {
        SceneManager.LoadScene("CharacterCustomization");
    }
}
