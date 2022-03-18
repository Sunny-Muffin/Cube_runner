
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelComleted : MonoBehaviour
{

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
