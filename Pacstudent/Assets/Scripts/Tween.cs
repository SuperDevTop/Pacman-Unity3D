using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    // Start is called before the first frame update
    public Transform Target { get;  }
    public Vector3 StartPos { get;  }
    public Vector3 EndPos { get;  }
    public float StartTime { get;  }
    public float Duration { get;  }
    
    public Tween(Transform target, Vector3 startPos, Vector3 endPos, float startTime, float duration)
    {
        Target = target;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = startTime;
        Duration = duration;
    }
}
