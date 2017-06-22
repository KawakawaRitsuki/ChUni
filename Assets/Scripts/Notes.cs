using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

    public float speed;

    public void Create(NotesModel nm)
    {
        if(nm.getColor() == 2)
        {
            transform.localScale = new Vector3(nm.getSize(), 0.01f, (nm.getHold() - 1) * 10 + 1);
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (transform.localScale.z - 1) / 2);
        }
        else
            transform.localScale = new Vector3(nm.getSize(), 0.01f, 1);
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, -36f / speed * 0.5f * Time.deltaTime);
    }
}
