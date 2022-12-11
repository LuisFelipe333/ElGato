using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    Vector2 startPos, endPos, direction;
    float touchTimeStart, touchTimeFinish, timeInterval;
    public AudioSource audioSource;

    [Range (0.05f, 1f)]
    public float throwForce = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    

    void Update(){
        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) {
            touchTimeStart = Time.time;
            startPos = Input.GetTouch (0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) {
            touchTimeFinish = Time.time;
            timeInterval = touchTimeFinish - touchTimeStart;
            endPos = Input.GetTouch (0).position;
            direction = startPos - endPos;
            GetComponent<Rigidbody2D> ().AddForce (-direction / timeInterval * throwForce);

            if(!audioSource.isPlaying)
                audioSource.Play();
        }
    }
}
