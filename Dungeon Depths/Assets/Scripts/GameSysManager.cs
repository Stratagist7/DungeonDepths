using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSysManager : MonoBehaviour
{
    [SerializeField] private List<string> levels = new List<string>();
    [SerializeField] private string menuName;
    [SerializeField] private string bestName;
    private static AudioSource music;
    private static GameSysManager _instance;
    

    public enum GameState
    {
        MENU, START, PLAYING, WIN
    }

    public static GameState state;
    
    // Checks to ensure there is only one active GameSysManager at a time in a scene. Sets the music component.
    void Awake()
    {
        if (_instance == null) {
            _instance = this;
            DontDestroyOnLoad(this);
        }  else
            Destroy(gameObject);

        if (music == null) {
            music = gameObject.GetComponentInChildren<AudioSource>();
        }
    }

    // Loads the start room
    public static void NewGame()
    {
        state = GameState.START;

        if(_instance.levels.Count > 0) {
            SceneManager.LoadScene(_instance.levels[0]);
        }
    }

    // Loads the Floor Puzzle and resets the platform counter. By default, the cut scene is off for reloading this scene.
    public static void LoadFloorPuzzle()
    {
        if(state != GameState.PLAYING)
            state = GameState.PLAYING;

        if (_instance.levels.Count > 1) {
            SceneManager.LoadScene(_instance.levels[1]);
            Platform_Collision.platformCount = 0;

            Camera_ShutDown.showCam = false;
        }
    }

    // Loads the Six to Nine puzzle, clears the lists of torches so that the solution script works when reloading the scene.
    public static void LoadSixToNine()
    {
        if (state != GameState.PLAYING)
            state = GameState.PLAYING;

        if (_instance.levels.Count > 2) {
            Torch_Solution.fullTorchList.Clear();
            Torch_Solution.torchList.Clear();
            Torch_Movement.currentTorches = 0;
            SceneManager.LoadScene(_instance.levels[2]);
        }
    }

    // Loads the Maze
    public static void LoadMaze()
    {
        if (state != GameState.PLAYING)
            state = GameState.PLAYING;

        if (_instance.levels.Count > 3) {
            SceneManager.LoadScene(_instance.levels[3]);
        }
    }

    // Loads the Rising Puzzle
    public static void LoadRisingPuzzle()
    {
        if (state != GameState.PLAYING)
            state = GameState.PLAYING;

        if (_instance.levels.Count > 4) {
            SceneManager.LoadScene(_instance.levels[4]);
        }
    }

    // Loads the Fire Puzzle
    public static void LoadFirePuzzle()
    {
        if (state != GameState.PLAYING)
            state = GameState.PLAYING;

        if (_instance.levels.Count > 5) {
            SceneManager.LoadScene(_instance.levels[5]);
        }
    }

    // Loads the Win World and changes the game state to WIN. Stops the music so Win World's music can play.
    public static void LoadWinWorld()
    {
        if (state != GameState.WIN)
            state = GameState.WIN;

        if (_instance.levels.Count > 6) {
            SceneManager.LoadScene(_instance.levels[6]);
            if (music != null)
                music.Stop();
        }
    }

    // Quits to the menu, ensures the background music is playing, and unlocks the cursor.
    public static void QuitToMenu()
    {
        if(state != GameState.MENU)
            state = GameState.MENU;

        if (_instance.menuName != "") {
            SceneManager.LoadScene(_instance.menuName);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            if (music != null && !music.isPlaying)
                music.Play();
        }
    }

    // Loads the Best Time scene.
    public static void LoadBestTime()
    {
        if (state != GameState.MENU)
            state = GameState.MENU;
        if (_instance.bestName != "") {
            SceneManager.LoadScene(_instance.bestName);
        }
    }
}
