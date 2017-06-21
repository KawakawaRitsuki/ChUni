

using UnityEngine;

public class FileLoader{

    private string data = ":SONGNAME=ウミユリ海底譚\n:ARTIST=n-buna\n:BPM=120\n\n:START\n----L==LY==Y----\n----L==L--------\n----L==L--------\n----L==L--------\n----L==LR==R----\n----L==LR==R----\n----L==LR==R----\nR==R--------R==R\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nY==Y--------Y==Y\n-\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R------\n--\nR==R--------R==R\n--------R==R----\nR==R--------R==R\n----R==R--------\nR==R--------R==R\n--------R==R----\nY==Y--------Y==Y\n:END";

    private string songname;
    private string artist;
    private int bpm;

    private int start = 0;
    private int end = 0;

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
            if (split[i] == ":END")
            {
                end = i - 1;
            }
            if (split[i].StartsWith(":SONGNAME="))
            {
                songname = split[i].Substring(10);
            }
            if (split[i].StartsWith(":ARTIST="))
            {
                artist = split[i].Substring(8);
            }
            if (split[i].StartsWith(":BPM="))
            {
                // 数字チェック
                bpm = int.Parse(split[i].Substring(5));
            }
        }
        Debug.Log(songname);
        Debug.Log(artist);
        Debug.Log(bpm);
    }
}
