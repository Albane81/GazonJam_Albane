using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPos.x = Mathf.Clamp(targetPos.x, minPosition.x, maxPosition.x);
            targetPos.y = Mathf.Clamp(targetPos.y, minPosition.y, maxPosition.y);

            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
        }
    }
}
