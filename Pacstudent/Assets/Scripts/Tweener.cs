using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    private float timeElapsed;
    private Vector3 move; 
    private float ease;
    public Animator animator;
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }
   public void  AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null) {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
    // Update is called once per frame
    void Update()
    {
        //if (activeTween != null) 
        //{
        //    timeElapsed += Time.deltaTime;
        //    ease = cubicEaseIn(timeElapsed,0.0f,Time.deltaTime,activeTween.Duration);
        //    if(Vector3.Distance(activeTween.Target.position, activeTween.EndPos) > 0.1f)
        //    {
        //        move = Vector3.Lerp(activeTween.StartPos,activeTween.EndPos , Time.deltaTime);
//
        //        activeTween.Target.position = activeTween.Target.position + move;
        //    }
//
        //    Debug.LogError(Vector3.Distance(activeTween.Target.position, activeTween.EndPos));
        //    if(Vector3.Distance(activeTween.Target.position, activeTween.EndPos) <= 0.1f)
        //    {
        //        activeTween.Target.position = activeTween.EndPos;
        //        activeTween = null;
        //    }
        //}

        // if(activeTween.Target.position.y <= 3.5f && count == 0)
        // {
        //     animator.SetInteger("Direction", 1);
        //     activeTween.Target.position = activeTween.Target.position + new Vector3(0.0f, 5f,0.0f)*Time.deltaTime;
        // }
        // else if(activeTween.Target.position.x <= -2.5f && activeTween.Target.position.y >= 3.5f )
        // {
        //     animator.SetInteger("Direction", 2);
        //     activeTween.Target.position = activeTween.Target.position + new Vector3(5f, 0.0f,0.0f)*Time.deltaTime;
        //     count = 1;

        // }
        // else if(activeTween.Target.position.y >= -0.5f )
        // {
        //     animator.SetInteger("Direction", 3);
        //     activeTween.Target.position = activeTween.Target.position + new Vector3(0.0f, -5f,0.0f)*Time.deltaTime;
        // }
        // else if(activeTween.Target.position.x >= -7.5f )
        // {
        //     animator.SetInteger("Direction", 4);
        //     activeTween.Target.position = activeTween.Target.position + new Vector3(-5f, 0.0f,0.0f)*Time.deltaTime;
        // }
        // else
        // {
        //     count = 0;
        // }

        if(Input.GetKey(KeyCode.W) && count == 0)
        {
            animator.SetInteger("Direction", 1);
            activeTween.Target.position = activeTween.Target.position + new Vector3(0.0f, 5f,0.0f)*Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("Direction", 2);
            activeTween.Target.position = activeTween.Target.position + new Vector3(5f, 0.0f,0.0f)*Time.deltaTime;
            count = 1;

        }
        else if(Input.GetKey(KeyCode.S))
        {
            animator.SetInteger("Direction", 3);
            activeTween.Target.position = activeTween.Target.position + new Vector3(0.0f, -5f,0.0f)*Time.deltaTime;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("Direction", 4);
            activeTween.Target.position = activeTween.Target.position + new Vector3(-5f, 0.0f,0.0f)*Time.deltaTime;
        }
        else
        {
            count = 0;
        }        
    }    

    private float cubicEaseIn(float t, float b, float c, float d)
    {
        t /= d;
        return -c * t*(t-2) + b;
    }

}


