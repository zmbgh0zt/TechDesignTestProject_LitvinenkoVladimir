using UnityEngine;

public class Start_animation_script : MonoBehaviour
{
   public GameObject firstAstro;
   public GameObject secondAstro;

    private Animator firstAstroAnim;
    private Animator secondAstroAnim;

    private void Awake()
    {
        firstAstroAnim = firstAstro.GetComponent<Animator>();
        secondAstroAnim= secondAstro.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        gameObject.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        firstAstroAnim.Play("astronaut_jump_animation");
        secondAstroAnim.Play("astronaut_jump_animation");
    }

    private void OnMouseUp()
    {
        gameObject.transform.localScale = Vector3.one;
    }
}
