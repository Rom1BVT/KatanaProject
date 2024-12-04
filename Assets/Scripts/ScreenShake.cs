using UnityEngine;
using Cinemachine;

public class ScreenShake : MonoBehaviour
{

    [SerializeField] private CinemachineImpulseSource sliceShake;
    //[SerializeField] private float direction;

    public void SliceScreenShake(Vector3 dir)
    {
        sliceShake.GenerateImpulseWithVelocity(dir);
    }

}
