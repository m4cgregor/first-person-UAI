using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void StarGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
