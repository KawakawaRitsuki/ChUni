using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour {
    public void Create(int place,int size)
    {
        transform.localScale = new Vector3(size, 0.01f, 1);
        transform.position = new Vector3((float)(- 8 + size / 2 + place), 0, 35);
    }

    void Update()
    {
        transform.position += new Vector3(0, 0, -25f * Time.deltaTime);
        if(transform.position.z < -7.5)
        {
            Destroy(this.gameObject);
        }
    }
}
