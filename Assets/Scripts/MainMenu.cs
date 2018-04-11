using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IMGUI.MainMenu
{

    [AddComponentMenu("IMGUI/MainMenu")]
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        [Header("MAIN MENU")]
        [Space(5)]
        [Header("screens")]
        public float scrW;
        public float scrH;
        public bool loadScreen;
        public bool showOpitons;
        [Header("Styles")]
        [Header("Keys")]
        public KeyCode forward;
        public KeyCode backward;
        public KeyCode left;
        public KeyCode right;
        public KeyCode jump;
        public KeyCode crouch;
        public KeyCode interact;
        public KeyCode sprint;
        public KeyCode temKey;
        [Header("Audio and Lighting")]
        public AudioSource mainMusic;
        public Light brightness;
        public float audioSlider, brightnessSlider;
        public float amBrghtSlider;
        public bool mute;
        [Header("Resolation and FullScreen")]
        public int resIndex;
        public int[] resX, resY;
        public bool fullScreen, windowed;
        public bool showDropdown;
        public Vector2 scollPos;
        public string resolution = "Resolution";
        #endregion
        // Use this for initialization
        void Start()
        {
            loadScreen = true;
            scrW = Screen.width / 16;
            scrH = Screen.height / 9;

        }
        // Update is called once per frame
        void Update()
        #region References Set Up
        {
            brightness = GameObject.FindGameObjectWithTag("Light").GetComponent<Light>();
            mainMusic = GameObject.Find("Music").GetComponent<AudioSource>();
            #endregion

            #region Key Set Up
            forward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Forward", "W"));
            backward = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("BackWard", "S"));
            left = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Left", "A"));
            right = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Right", "Space"));
            jump = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Jump", "Space"));
            crouch = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Crouch", "C"));
            crouch = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Interact", "E"));
            crouch = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("Sprint", "LeftShift"));
            #endregion

            #region Audio and Brightness setup
            if (PlayerPrefs.HasKey("Mute"))
            {
                amBrghtSlider = RenderSettings.ambientIntensity = PlayerPrefs.GetFloat("AmLight");
            }
            #endregion

        }
        private void OnGUI()
        {
            if (loadScreen)
            {
                GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "");
                GUI.Box(new Rect(2 * scrW, 0.5f * scrH, 12 * scrW, 3 * scrH), "Logo / Title");
                GUI.Box(new Rect(4 * scrW, 4.5f * scrH, 8 * scrW, 1 * scrH), "Press AnyKey");
            }
            else
            {
                if (!showOpitons)
                {

                }
                else
                {

                }
                {
                    float scrW = Screen.width / 16;
                    float scrH = Screen.height / 9;

                    if(GUI.Button(new Rect(scrW, scrH, 2 * scrW, 0.5f * scrH), "Resolution"))
                    {

                    }
                }
                 
            }
        }
    }
}
