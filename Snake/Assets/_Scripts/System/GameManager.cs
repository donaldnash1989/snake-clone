using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField]
    private GameObject player;

    private static bool isOriginal = false, isInstanced = false;
    private static GameObject _player;

    private void Awake()
    {
        if (!isOriginal) DontDestroyOnLoad(gameObject);
        else Destroy(gameObject);
        isOriginal = true;
        _player = player;
    }

    public static void CreatePlayer(Vector3 spawnPosition)
    {
        if(!isInstanced) _player = Instantiate(_player, spawnPosition, Quaternion.identity);
    }

    public static GameObject GetPlayer()
    {
        return _player;
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
