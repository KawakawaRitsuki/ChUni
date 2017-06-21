using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileLoader{

    string data = ":SONGNAME=ウミユリ海底譚\n:ARTIST=n-buna\n:BPM=120\n\n:START\n----L==LY==Y----\n----L==L--------\n----L==L--------\n----L==L--------\n----L==LR==R----\n----L==LR==R----\n----L==LR==R----\nR==R--------R==R\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nY==Y--------Y==Y\n-\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R------\n--\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nY==Y--------Y==Y\n:END";
    int start = 0;

    public FileLoader(string text)
    {
        // data = text;
        string[] split = data.Split('\n');
        // この辺にちゃんとしたチェック挟む

        for (int i = 0; i < split.Length; ++i)
        {
            if(split[i] == ":START")
            {
                start = i + 1;
            }
        }
    }
}
