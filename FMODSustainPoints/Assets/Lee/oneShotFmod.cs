using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;
using FMOD.Studio;

public class oneShotFmod : MonoBehaviour
{
    FMOD.Studio.EventInstance _sound;

    // Start is called before the first frame update
    void Start()
    {
        _sound = FMODUnity.RuntimeManager.CreateInstance(("event:/Stinger"));
    }

    // Update is called once per frame
    void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(_sound, GetComponent<Transform>(),
            GetComponent<Rigidbody>());
    }

    void OnTriggerEnter()
    {
        _sound.start();
    }
    void OnTriggerExit()
    
    { _sound.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
        //  _sound.stop(FMOD.Studio.STOP_MODE.IMMEDIATE);
        
        
    }




 /* void Update3DAttributes()
    {
        if (_sound.isValid ())
        {
            var attributes = FMOD.Studio.UnityUtil.to3DAttributes(gameObject, cachedRigidBody);
             ERRCHECK(_sound.set3DAttributes(attributes));
        }
    }
*/
}
    