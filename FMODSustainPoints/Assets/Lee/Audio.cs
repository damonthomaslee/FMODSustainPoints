using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Audio : MonoBehaviour
{

    public FMOD.Studio.EventInstance Voice; //this is public so trigger can reference it

    // Start is called before the first frame update
    void Start()
    {
        Voice = FMODUnity.RuntimeManager.CreateInstance("event:/Reading");
        Voice.start();

    }

    // Update is called once per frame
    void Update()
    {
        FMODUnity.RuntimeManager.AttachInstanceToGameObject(Voice, GetComponent<Transform>(),
            GetComponent<Rigidbody>());

        

    }
}
