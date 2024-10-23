using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    public Vector3 camOffSet = new Vector3(0f, 1.2f, -2.6f);

    private Transform target;
    
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }
    
    void Update()
    {
        this.transform.position = target.TransformPoint(camOffSet);
        
        this.transform.LookAt(target);
    }
}
