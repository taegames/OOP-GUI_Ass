using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardCodePauseMenu : MonoBehaviour
{
    //boolean for paused
    public bool paused;
    //boolean for showOptions
    public bool showOptions;
    //bool for showResolutions
    public bool showResolutions;
    //bool for fullScreen
    public bool fullScreen;
    //bool for mute
    public bool mute;
    //float values for brightness and volume
    public float values, brightness, volume;
    //int index
    public int index;
    //int array for both x and y resolutions
    public int[] resoultionsX, resolutionsY;
    //keycodes for your keybinding 
    public KeyCode movementUp, movementDown, movementLeft, movementRigt, pause;
    //void OnGUI()
    public void OnGUI()
    {
        float scrW = Screen.width / 16;//x
        float scrH = Screen.height / 9;//y

        #region Special Countin Grid
        for (int h = 0; h < 9; h++)
        {
            for (int w = 0; w < 16; w++)
            {
                GUI.Box(new Rect(w * scrW, h * scrH, scrW, scrH), "");
            }
        }
        for (int h = 0; h < 10; h++)
        {
            GUI.Label(new Rect(0.1f * scrW, (scrH * 0.5f) + scrH * h + 0.3f * scrH - scrH, scrW, scrH), h.ToString());
        }
        for (int i = 0; i < 17; i++)
        {
            GUI.Label(new Rect((0.5f * scrW) + scrW * i + scrW * 0.4f - scrW, 0.01f * scrH, scrW, scrH), i.ToString());
        }
        #endregion
        if (paused)
        {
            // GUI button  return 10/16     0/9    6/16   9/9...Y covers the whole screen
            if (GUI.Button(new Rect(2.25f * scrW, 1.5f * scrH, 6 * scrW, 1 * scrH), "Return to Game"))
            {
                //toggle paused and timescale

            }
            //GUI button options
            if (GUI.Button(new Rect(2.25f * scrW, 3.5f * scrH, 6 * scrW, 1 * scrH), "Options"))
            {
                //toggle bool  showOptions
            }
            //GUI button quit to menu
            if (GUI.Button(new Rect(2.5f * scrW, 5.5f * scrH, 5 * scrW, 1 * scrH), "Menu"))
            {

            }
                //change scenes
                //GUI button quit to desktop
          
            // quit application
        }


 
    }
    /*
     * IF PAUSED
     button for return
        -toggle paused and timescale
     button for options
        -toggle bool for show options
     button for quit to menu
        -change scenes
     button for quit to desktop
        -quit
     IF SHOWOPTIONS
     back ground box
     sliders for volume
     sliders for brightness                                     cur pos    min  max
        -floatValue = GUI.HorizontalSlider(new Rect(x,y,x,y), floatValue, 0.0F, 1.0F);
    buttons for Keybinding
    movement and actions
    Dropdown for resolutions
        -Button that has a showResolutions bool
        if show resolutions
            -Box as a background
           Together we will make a for loop
           that has buttons which are labeled our resolutions and set the resolution
     Button toggle for mute
     button toggle for fullscreen
     button for back
        -showOptions bool toggle
     */

    /*
     bool TogglePause()

        return true and false
        if paused
            start time
            unpause
            lock cursor
            hider cursor
            false
        else
            stop time
            pause
            unlock cursor
            show cursor
            true
     */
}