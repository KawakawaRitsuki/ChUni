using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour {

    public float speed;
    private int bpm;

    public void Create(NotesModel nm,int speed)
    {
        if(nm.getColor() == 2)
        {
            transform.localScale = new Vector3(nm.getSize(), 0.01f, nm.getHold() * speed * 1.5f + 1);
            Debug.Log(nm.getHold());
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (transform.localScale.z - 1) / 2);
        }
        else
            transform.localScale = new Vector3(nm.getSize() - 0.2f, 0.01f, 1);
        this.bpm = nm.getBPM();
        this.speed = speed;
    }

    void FixedUpdate()
    {
        transform.position += new Vector3(0, 0, bpm / -3 / 5 * 1.5f * Time.deltaTime * speed);
    }
}
