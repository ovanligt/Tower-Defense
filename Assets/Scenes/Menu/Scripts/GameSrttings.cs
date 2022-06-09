using UnityEngine;
using UnityEngine.Audio;

public class GameSrttings : MonoBehaviour
{
    private bool isFullScreen;

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }




}
    