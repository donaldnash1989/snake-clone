using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    private static bool isOriginal = false;
    private static GameObject _player;
    private static GameObject i_player;

    private void Awake()
    {
        if (!isOriginal) DontDestroyOnLoad(gameObject);
        else Destroy(gameObject);
        isOriginal = true;
    }

    private void Start()
    {
        GetComponent<CursorManager>().InitCursor();
        _player = player;
    }

    public static void CreatePlayer(Vector3 spawnPosition)
    {
        i_player = Instantiate(_player, spawnPosition, Quaternion.identity);
    }

    public static GameObject GetPlayer()
    {
        return i_player;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PrevScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public static void ExitGame()
    {
        Application.Quit();
    }
}
