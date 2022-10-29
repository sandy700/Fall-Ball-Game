using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    void Start()
    {
        Animation anim = GetComponent<Animation>();


        anim.Play("New Animation2");
        
        
    }
}