using UnityEngine;

public class AnimationController : MonoBehaviour
{
    [SerializeField] private Animator animationController;
    private bool animationOne = true;

    public void OnClick()
    {
        if(animationOne)
        {
            animationController.SetTrigger("PlayOne");
        }

        else
        {
            animationController.SetTrigger("PlayTwo");
        }

        animationOne = !animationOne;
    }
   
}
