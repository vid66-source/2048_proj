using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Project.Scripts.MainMenu
{
    public class MainMenu : MonoBehaviour
    {
        public void LoadGame()
        {
            SceneManager.LoadScene(1);
        }
    }
}