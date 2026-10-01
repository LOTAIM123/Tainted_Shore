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
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = !Cursor.visible;
            Player_camera.Instance.updatingRotation = !Player_camera.Instance.updatingRotation;
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            inventory.SetActive(false);
            pauseMenu.SetActive(!pauseMenu.activeInHierarchy);
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = !Cursor.visible;
            Player_camera.Instance.updatingRotation = !Player_camera.Instance.updatingRotation;
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
}
