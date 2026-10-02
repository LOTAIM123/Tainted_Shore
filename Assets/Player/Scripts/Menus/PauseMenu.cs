using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject inventory;

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.G) && inventory.activeInHierarchy == true)
        {
            inventory.SetActive(false);

            LockUnlockMouse();
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            inventory.SetActive(false);
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);

            LockUnlockMouse();

            if(pauseMenu.activeInHierarchy)
            {
                PauseGame();
            }
            if(!pauseMenu.activeInHierarchy)
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
}
