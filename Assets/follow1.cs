using System.Collections;
using UnityEngine;

public class follow1 : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5f;
    public float cameraHeight = 5f;
    public float distanceBehindPlayer = 10f;
    public float lookAtHeightOffset = 2f;
    void Start()
    {
        StartCoroutine(DelayedLookAt());
    }

    IEnumerator DelayedLookAt()
    {

        while (true)
        {
            if (target != null)
            {
                Vector3 behindPosition = target.position - target.forward * distanceBehindPlayer;
        Vector3 desiredPosition = new Vector3(behindPosition.x, target.position.y + cameraHeight, behindPosition.z);


        transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);


        Vector3 lookAtPosition = new Vector3(target.position.x, target.position.y + lookAtHeightOffset, target.position.z);
        transform.LookAt(lookAtPosition);
            }

            yield return null;
        }
    }
}