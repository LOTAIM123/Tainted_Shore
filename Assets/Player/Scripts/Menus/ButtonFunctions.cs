using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject pauser;
    public GameObject pauseMenu;

    public GameObject settingsMenu;
    public GameObject keybindMenu;

    

    public void OpenPauseMenu()
    {
        pauser.SetActive(!pauser.activeInHierarchy);
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
        Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = !Cursor.visible;
        Player_camera.Instance.updatingRotation = !Player_camera.Instance.updatingRotation;
        Time.timeScale = 1;
    }

    public void OpenSettings()
    {
        CloseAllMenus();
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
        settingsMenu.SetActive(!settingsMenu.activeInHierarchy);
    }

    public void CloseAllMenus()
    {
        keybindMenu.SetActive(false);
    }

    public void OpenKeybinds()
    {
        CloseAllMenus();
        keybindMenu.SetActive(true);
    }
}
