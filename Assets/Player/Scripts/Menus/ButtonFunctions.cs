using UnityEngine;

public class ButtonFunctions : MonoBehaviour
{
    public GameObject pauser;
    public GameObject pauseMenu;
    public GameObject settingsMenu;

    

    public void CloseMenu()
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
        pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
        settingsMenu.SetActive(!settingsMenu.activeInHierarchy);
    }
}
