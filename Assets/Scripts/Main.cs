using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

    public GameObject redPrefub;
    public GameObject yellowPrefub;
    public GameObject holdPrefub;
    public TextAsset textAsset;
    
    int i = 0;
    List<List<NotesModel>> list;
    int notes = 0;

    public int speed;

    private void Start()
    {
        var textAsset = Resources.Load("umiyurikaiteitan-expert") as TextAsset;
        FileLoader fl = new FileLoader(textAsset.text);
        list = fl.getList();

        foreach (List<NotesModel> lnm in list)
        {
            foreach (NotesModel rn in lnm)
            {
                Vector3 v = new Vector3((float)(-8 + rn.getSize() / 2 + rn.getPos()),0, 30.5f + notes * speed * 1.5f);

                if (rn.getColor() == 0)
                {
                    GameObject red = Instantiate(redPrefub, v, transform.rotation);
                    Notes r = red.GetComponent<Notes>();
                    r.Create(rn,speed);
                }
                else if (rn.getColor() == 1)
                {
                    GameObject yellow = Instantiate(yellowPrefub,v,transform.rotation);
                    Notes r = yellow.GetComponent<Notes>();
                    r.Create(rn, speed);
                }
                else if (rn.getColor() == 2)
                {
                    GameObject hold = Instantiate(holdPrefub, v, transform.rotation);
                    Notes r = hold.GetComponent<Notes>();
                    r.Create(rn, speed);
                }
            }
            notes++;
        }

    }

    void Update()
    {
    }
}
