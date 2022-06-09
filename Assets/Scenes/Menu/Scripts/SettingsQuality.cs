using UnityEngine;
using UnityEngine.UI;


public class SettingsQuality : MonoBehaviour
{
public Dropdown dropdown;
public void checkdropdown()
{
QualitySettings.SetQualityLevel(dropdown.value, true);
}
}
