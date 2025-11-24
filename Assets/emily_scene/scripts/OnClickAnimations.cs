using UnityEngine;

public class OnClickAnimations : MonoBehaviour
{
    Animator thisAnimator;
    public GameObject myAnimatedObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        thisAnimator = myAnimatedObj.GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        thisAnimator.SetBool("IsClicked", true);
    }

    public void ReverseCameraMovement()
    {
        thisAnimator.SetBool("IsClicked", false);
    }
}
