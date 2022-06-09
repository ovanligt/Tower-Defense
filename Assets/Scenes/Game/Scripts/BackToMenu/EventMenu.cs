using UnityEngine;
using UnityEngine.SceneManagement;
public class EventMenu : MonoBehaviour
{
    public delegate void IDelegate();
    public static event IDelegate IEventMenu;

    public void OnMenu()
    {
        IEventMenu += BackToMenu;
        IEventMenu?.Invoke();
        IEventMenu -= BackToMenu;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnMenu();
        }

    }
    private void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
