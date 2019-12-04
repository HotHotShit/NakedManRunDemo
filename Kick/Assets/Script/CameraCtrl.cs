using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl: MonoBehaviour
{

    public float distanceAway = 2;
    public float distanceUp = 1;
    public float smooth = 2;
    public float rotateSense = 1;

    private Vector3 targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (PlayerFrame.Player == null) return;

        Transform targetTransform = PlayerFrame.Player.transform;
        
        targetPosition = targetTransform.position - targetTransform.forward * distanceAway + targetTransform.up * distanceUp;
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth);
        

       
        transform.LookAt(PlayerFrame.Player.transform);

    }
}
