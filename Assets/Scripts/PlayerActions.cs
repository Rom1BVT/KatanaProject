using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using Cinemachine;


public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Animator katanaAnimator;

    [SerializeField] private ScreenShake screenShake;
    [SerializeField] private Vector3[] sliceDirections = new Vector3[4];
    [SerializeField] private float sliceIntensity = 1;


    // Update is called once per frame
    void Update()
    {
        Slice();
    }

    private void Slice()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            katanaAnimator.SetTrigger("Slice");
            SliceFeedbacks();

        }        
    }


    private void SliceFeedbacks()
    {
        AnimatorClipInfo[] animatorClipInfo;
        animatorClipInfo = katanaAnimator.GetCurrentAnimatorClipInfo(0);       


        if (animatorClipInfo[0].clip.name == "Idle" || animatorClipInfo[0].clip.name == "Slice4")
        {
            Debug.Log("Slice2");
            screenShake.SliceScreenShake(sliceDirections[0].normalized * sliceIntensity);
        }
        else if (animatorClipInfo[0].clip.name == "Slice2")
        {
            Debug.Log("Slice1");
            screenShake.SliceScreenShake(sliceDirections[1].normalized * sliceIntensity);
        }
        else if (animatorClipInfo[0].clip.name == "Slice1")
        {
            Debug.Log("Slice3");
            screenShake.SliceScreenShake(sliceDirections[2].normalized * sliceIntensity);
        }
        else if (animatorClipInfo[0].clip.name == "Slice3")
        {
            Debug.Log("Slice4");
            screenShake.SliceScreenShake(sliceDirections[3].normalized * sliceIntensity);
        }
        
    }
}
