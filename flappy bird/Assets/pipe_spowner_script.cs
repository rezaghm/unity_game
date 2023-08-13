using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_spowner_script : MonoBehaviour
{
    public GameObject pipe;
    public float spownrate = 2;
    private float timer = 0;
    public float highest_point = 5;
    // Start is called before the first frame update
    void Start()
    {
        spawnpipe();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer< spownrate)
        {
            timer += Time.deltaTime;

        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }

    void spawnpipe()
    {
        float lowest_hight = transform.position.y - highest_point;
        float highest_hight = transform.position.y + highest_point;
        Instantiate(pipe,new Vector3(transform.position.x, Random.Range(highest_hight,lowest_hight),0), transform.rotation);
    }


}
