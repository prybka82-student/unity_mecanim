using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControler : MonoBehaviour
{
    const string openDoorParameterName = "openDoor";
    const string closeDoorParameterName = "closeDoor";

    public Transform Door;

    Animator _doorAnimator;

    // Start is called before the first frame update
    void Start()
    {
        _doorAnimator = Door.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) 
    {
        _doorAnimator.SetBool(openDoorParameterName, true);
    }

    void OnTriggerExit(Collider other) 
    {
        _doorAnimator.SetBool(openDoorParameterName, false);
    }
}
