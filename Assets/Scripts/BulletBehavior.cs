using UnityEngine;

public class BulletBehavior : MonoBehaviour
{

    public float onescreenDelay = 3f;

    void Start()
    {
        Destroy(this.gameObject, onescreenDelay);
    }

    void Update()
    {
        
    }
}
