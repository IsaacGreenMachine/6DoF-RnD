using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePig : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pig;
    public int rotation_speed;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float rotation_amount = rotation_speed * Time.deltaTime;
        pig.transform.Rotate(new Vector3(0, rotation_amount, 0));
    }
}
