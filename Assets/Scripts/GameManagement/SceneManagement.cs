using UnityEngine;

namespace GameManagement
{
    public class SceneManagement : MonoBehaviour
    {
        public static void LoadScene(int index)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(index);
        }
        
        public static void Exit()
        {
            Application.Quit();
        }
    }
}
