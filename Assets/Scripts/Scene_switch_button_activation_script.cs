using UnityEngine;

public class Scene_switch_button_activation_script : MonoBehaviour
{
    public GameObject button;
    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        button.SetActive(true);
    }

    private void OnMouseUp()
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
