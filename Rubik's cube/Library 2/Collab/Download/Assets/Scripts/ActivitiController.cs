using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivitiController : MonoBehaviour
{
    private KeyboardActivities keyboardActivities;
    private MouseActivities mouseActivities;
    // Start is called before the first frame update
    void Start()
    {
        keyboardActivities = GetComponent<KeyboardActivities>();
        mouseActivities = GetComponent<MouseActivities>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mouseActivities.BUSY()){
            mouseActivities.MouseInputUpdate();
        }
        else if(keyboardActivities.KeyboardInputUpdate()){ // True if no input(s)
            mouseActivities.MouseInputUpdate();
        }
    }
}
