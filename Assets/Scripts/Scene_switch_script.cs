using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_switch_script : MonoBehaviour
{
    public string scene_name;

    public void Load()
    {
        SceneManager.LoadScene(scene_name);
    }
}
