using UnityEngine;
using UnityEditor;
using FMODUnity;


namespace GameManagement
{
    public class SceneManagement : MonoBehaviour
    {

        [SerializeField]
        private EventReference sfxClick;

        public /*static*/ void LoadMainMenu()
        {
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }

        public /*static*/ void IntroScene()
        {
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }

        public /*static*/ void LoadMainScene()
        {
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        
        public /*static*/ void LoadCreditScene()
        {
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
            UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }

        public /*static*/ void GameExit()
        {
            #if UNITY_EDITOR
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
            EditorApplication.isPlaying = false;
            #else
            RuntimeManager.PlayOneShotAttached(sfxClick, gameObject);
                Application.Quit();
            #endif
        }
    }
}
