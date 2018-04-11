using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopupMenuToggle : MonoBehaviour
{

    #region Variables

    [Header("Level")]
    [Space(10)]
    public int menuToLoad;

    [Header("Options")]
    [Space(10)]
    public bool showBindingsMenu;
    public GameObject keybindingMenu;

    #endregion

    public void ChangeScene()
    {
        SceneManager.LoadScene(menuToLoad);
    }

    public void KeybindingToggle()
    {
        ToggleOptions();
    }

    bool ToggleOptions()
    {
        if (showBindingsMenu)
        {
            showBindingsMenu = false;
            keybindingMenu.SetActive(false);
            return false;
        }
        else
        {
            showBindingsMenu = true;
            keybindingMenu.SetActive(true);
            return true;
        }
    }

}
