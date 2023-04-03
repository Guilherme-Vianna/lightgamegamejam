using UnityEngine;
using UnityEditor;

namespace GameManagement
{
    public class SceneManagement : MonoBehaviour
    {
        public static void LoadMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        
        public static void LoadMainScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        
        public static void LoadCreditScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        public static void GameExit()
        {
            #if UNITY_EDITOR
                EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
