public class NotesModel {
    int size = 0;
    int pos = 0;
    int color = 0;
    // 0 red
    // 1 yellow
    // 2 hold
    int hold = 0;

    int bpm = 0;

    public NotesModel(int size,int pos,int color,int bpm)
    {
        setSize(size);
        setPos(pos);
        setColor(color);
        setBPM(bpm);
    }
    public int getSize()
    {
        return size;
    }
    public void setSize(int s)
    {
        size = s;
    }
    public int getPos()
    {
        return pos;
    }
    public void setPos(int p)
    {
        pos = p;
    }
    public int getColor()
    {
        return color;
    }
    public void setColor(int c)
    {
        color = c;
    }
    public int getHold()
    {
        return hold;
    }
    public void setHold(int h)
    {
        hold = h;
    }
    public int getBPM()
    {
        return bpm;
    }
    public void setBPM(int b)
    {
        bpm = b;
    }
}
