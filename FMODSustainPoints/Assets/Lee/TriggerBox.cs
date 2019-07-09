using UnityEngine;

public class TriggerBox : MonoBehaviour {

    //public bool playerInBox = false;

    public GameObject Speaker;
    private Audio _Audio;

    void Start ()
    {
        _Audio = Speaker.GetComponent<Audio>();
    }

    void OnTriggerEnter ()
    {
        _Audio.Voice.triggerCue();
        Debug.Log("cue");
    }
}