using UnityEngine;

namespace GameManagement
{
    public class SceneManagement : MonoBehaviour
    {
        public static void LoadMainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
        }
        
        public static void LoadMainScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        }
        
        public static void LoadCreditScene()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("CreditScene");
        }
    }
}
