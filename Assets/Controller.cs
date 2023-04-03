using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// For Scene Management
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{

    public static Controller Instance;
    private static System.Random rand = new System.Random();
    private int numberOfScenes;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
        numberOfScenes = SceneManager.sceneCountInBuildSettings;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            Debug.Log("Switching to scene: " + 1);
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.Alpha2))
        {
            Debug.Log("Switching to scene: " + 2);
            SceneManager.LoadScene(1);
        }

        if (Input.GetKey(KeyCode.Alpha3))
        {
            Debug.Log("Switching to scene: " + 3);
            SceneManager.LoadScene(2);
        }

        if (Input.GetKey(KeyCode.Alpha4))
        {
            Debug.Log("Switching to scene: " + 4);
            SceneManager.LoadScene(3);
        }

        if (Input.GetKey(KeyCode.Alpha5))
        {
            Debug.Log("Switching to scene: " + 5);
            SceneManager.LoadScene(4);
        }



        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }
    }
}
