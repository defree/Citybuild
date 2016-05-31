using UnityEngine;
using System.Collections;

public class Cube {

    private int status;
    private int coordX;
    private int coordY;

    public Cube (int status, int coordX, int coordY)
    {
        this.status = status;       // 0 = Unused
                                    // 1 = Used
                                    //

        this.coordX = coordX;
        this.coordY = coordY;
    }

    public void setStatus(int status)
    {
        this.status = status;
    }

    public int getStatus()
    {
        return status;
    }
}
