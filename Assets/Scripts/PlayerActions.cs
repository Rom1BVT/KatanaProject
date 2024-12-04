using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
using Cinemachine;


public class PlayerActions : MonoBehaviour
{
    [SerializeField] private Animator katanaAnimator;

    [SerializeField] private ScreenShake screenShake;
    [SerializeField] private Vector3 sliceDirection;
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
        //screenShake.SliceScreenShake(sliceDirection.normalized * sliceIntensity);
        //Debug.Log(katanaAnimator.GetCurrentAnimatorStateInfo(0).IsName("Slice2"));
        AnimatorClipInfo[] animatorClipInfo;
        animatorClipInfo = katanaAnimator.GetCurrentAnimatorClipInfo(0);
        //Debug.Log(animatorClipInfo[0].clip.name);


        if (animatorClipInfo[0].clip.name == "Idle" || animatorClipInfo[0].clip.name == "Slice4")
        {
            Debug.Log("Slice2");           
        }
        else if (animatorClipInfo[0].clip.name == "Slice2")
        {
            Debug.Log("Slice1");
        }
        else if (animatorClipInfo[0].clip.name == "Slice1")
        {
            Debug.Log("Slice3");
        }
        else if (animatorClipInfo[0].clip.name == "Slice3")
        {
            Debug.Log("Slice4");
        }
        
    }
}
