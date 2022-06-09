using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
    public void PlayButton() 
    {
        SceneManager.LoadScene("Game");
    }
    public void ExitButton() // После билда
    {
        Application.Quit();
        Debug.Log("Exit pressed!");
    }
}
