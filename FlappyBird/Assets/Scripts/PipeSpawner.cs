using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float Timer = 1;
    public GameObject Pipe;
    public float height;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Timer > maxTime)
        {
            GameObject newpipe = Instantiate(Pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            Destroy(newpipe, 10);
            Timer = 0;

            
        }
        Timer += Time.deltaTime;
    }

    
}
