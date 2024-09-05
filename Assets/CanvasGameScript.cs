using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasGameScript : MonoBehaviour
{
    public void FromGameToMainMenuButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
