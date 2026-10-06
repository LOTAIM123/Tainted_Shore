using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauser;
    public GameObject pauseMenu;
    public GameObject inventory;

    public GameObject settingsMenu;
    public GameObject keybindMenu;

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.G) && inventory.activeInHierarchy == true)
        {
            inventory.SetActive(false);

            LockUnlockMouse();
        }
        else if (Input.GetKeyDown(KeyCode.G) && settingsMenu.activeInHierarchy == true)
        {
            CloseAllMenus();
            pauseMenu.SetActive(true);


        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            inventory.SetActive(false);
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
            pauser.SetActive(!pauser.activeInHierarchy);

            LockUnlockMouse();

            if(pauser.activeInHierarchy)
            {
                PauseGame();
            }
            if(!pauser.activeInHierarchy)
            {
                ContinueGame();
            }
        }
        
    }
    private void PauseGame()
    {
        Time.timeScale = 0;
   
    } 

    private void ContinueGame()
    {
        Time.timeScale = 1;
    }

    private void LockUnlockMouse()
    {
        Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
        Cursor.visible = !Cursor.visible;
        Player_camera.Instance.updatingRotation = !Player_camera.Instance.updatingRotation;
    }

    private void CloseAllMenus()
    {
        keybindMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }
}
