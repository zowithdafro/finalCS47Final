using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject imagemenu;
    public GameObject upartmenu;


    private void Start(){
        pauseMenu.SetActive(false);
        upartmenu.SetActive(false);
    }

    public void TogglePauseMenu(){
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
    public void ToggleArtMenu(){
        upartmenu.SetActive(!upartmenu.activeSelf);
    }

    public void toMenu(){
        SceneManager.LoadScene("Game Menu");
    }

    public void exitImage(){
        imagemenu.SetActive(false);
    }
}
