using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;
public class Movement : MonoBehaviour
{
    public GameObject box;
    Vector3 endPos;
    Vector3 startPos;
    GameObject i;
    // Start is called before the first frame update
    private SerializedObject item;  
    private Tweener tweener;
    void Start()
    {
        item = new SerializedObject(box);
        tweener = GetComponent<Tweener>();
        startPos = new Vector3(box.transform.position.x, box.transform.position.y);
        Vector3 endpos =  new Vector3(0.0f,0f,0.0f);
        endpos += startPos;
        i = item.targetObject as GameObject;
        float duration = 0.001f;
        tweener.AddTween(box.transform, startPos, endPos, duration);        
    }

    void Update()
    {
    }
}
