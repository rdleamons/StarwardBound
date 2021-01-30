using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReturnToMain : MonoBehaviour
{
    public Button backButton;
    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
