using UnityEngine;

public class Sound_on_click_script : MonoBehaviour
{
    private AudioSource audioData;

    private void Awake()
    {
        audioData = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        audioData.Play(0);
    }

    private void OnMouseUp()
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
