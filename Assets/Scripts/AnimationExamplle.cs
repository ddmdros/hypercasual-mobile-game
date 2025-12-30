using UnityEngine;

public class AnimationExamplle : MonoBehaviour
{

    public Animation animation;
    public AnimationClip run;
    public AnimationClip idle;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimation(run);

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayAnimation(idle);
        }


    }
        private void PlayAnimation(AnimationClip c)
    {
        animation.CrossFade(c.name);

    }

}
