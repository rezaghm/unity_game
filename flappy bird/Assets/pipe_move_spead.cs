using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move_spead : MonoBehaviour
{
    public float move_spead = 5;
    private float dead_zone = -30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.left * move_spead) * Time.deltaTime;
        if (transform.position.x < dead_zone)
        {
            Debug.Log("pipe deleted");
            Destroy(gameObject);
        }
    }
}
