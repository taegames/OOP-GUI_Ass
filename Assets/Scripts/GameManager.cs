using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//if you are using Canvas GUI
using UnityEngine.SceneManagement;//you need this to change scenes

public class GameManager : MonoBehaviour
{
    #region Variables
    [Header("Level")]
    [Space(10)]
    public int levelToLoad;
    public bool paused; 
    [Header("OPTIONS")]
    [Space(10)]
    public bool showOptions;
    [Header("Resolution")]
    public int index;
    public int[] resX, resY;
    public bool fullScreen;
    [Header("Keys")]
    public KeyCode forward;
    public KeyCode backward;
    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public KeyCode crouch;
    public KeyCode interact;
    public KeyCode sprint;
    public KeyCode tempey;
    [Header("References")]
    public AudioSource mainMusic;
    public Light brightness;
    [Header("Screen Elements")]
    public Slider brightnessSlider;
    public Slider volumeSlider;
    public GameObject menu;
    public GameObject optionsMenu;
    public Dropdown resolutionDropdown;
    public Toggle fullscreenToggle;

    /*void Start()
     {
         Time.timeScale = 1;
         #region Siders
         brightness = GameObject.FindGameObjectWithTag("Light").GetComponent<Light>();
         mainMusic = GameObject.Find("Music").GetComponent<AudioSource>();
         volumeSlider.value = mainMusic.volume;
         brightnessSlider.value = brightness.intensity;
     }
     public void ChangeMusic()
     {
         mainMusic.volume = volumeSlider.value;
     }
     public void ChangeBrightness()
     {

     }
     public void ResolutionChange()
     {
         index = resolutionDropdown.value;
         Screen.SetResolution(resX[index], resY[index], fullScreen);
     }
     #endregion


     public void ChangeScene()
     {
         SceneManager.LoadScene(levelToLoad);
     }

     public void QuitProgram()
     {
 #if UNITY_EDITOR
         UnityEditor.EditorApplication.isPlaying = false;
 #endif
         Application.Quit();
     }
     public void OptionsToggle()
     {
         if(SceneManager.)
         ToggleOptions();
     }
     bool ToggleOptions()
     {
         if (showOptions)
         {
             showOptions = false;
             menu.SetActive(true);
             optionsMenu.SetActive(false);
             return false;
         }
         else
         {
             showOptions = true;
             menu.SetActive(false);
             optionsMenu.SetActive(true);
             return true;

         }
     }
     public bool Togglefu11screen()
     {
         if (fullScreen)
         {
             fullScreen = false;
             fullscreenToggle.isOn = false;
             return false;
         }
         else
         {
             fullScreen = true;
             Screen.fullScreen = fullScreen;

             fullscreenToggle.isOn = fullScreen;
             return true;
         }
     }
     public void FullscreenToggle()
     {

         Togglefu11screen();
     }
 }

 PLayersPrefs.SetString(:"Forward", forward.ToString());
 PLayersPrefs.SetString(:"Backward", forward.ToString());
 PLayersPrefs.SetString(:"Left", forward.ToString());
 PLayersPrefs.SetString(:"Right", forward.ToString());
 PLayersPrefs.SetString(:"jump", forward.ToString());
 PLayersPrefs.SetString(:"Crouch", forward.ToString());
 PlayersPrefs.SetString(:"Interact", forward.ToString());
 PLayersPrefs.SetString(:"Sprint", forward.ToString());
 PLayersPrefs.SetString(:"Brightness", forward.ToString());
 PLayersPrefs.SetString(:"Volume", forward.ToString());

 public void Fowerd
 /*

 void Awake()
 {

 }
 void Start ()
 {

 }
 void Update ()
 {
 // Debug.Log("Update");

 }
 void FixedUpdate()
 {
 // Debug.Log("Fixed");
 }
 void LateUpdate()
 {
 //  Debug.Log("Late");

 }
 void OnGUI()//OnGui
 {

 }
 void OnCollisionEnter()
 {

 });
 void OnCollisionExit()
 {

 }
 void OnTriggerEnter()
 {

 }
 void OnTriggerExit()
 {

 }

 {
     if(paused)
     {

         paused = false;
         Time.timeScale = 1;
         return false;
     }
     */
    #endregion
}