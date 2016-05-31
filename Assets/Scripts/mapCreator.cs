using UnityEngine;
using System.Collections;

public class mapCreator : MonoBehaviour {

    public Transform groundcube;

    //Default mapsize at start
    private int mapX = 5;
    private int mapY = 5;

    private int cubeSize = 1;

    private Cube[,] cubeMap = new Cube[100,100]; //Create maps of cubes and limits map size to 100x100

	// Use this for initialization
	void Start () {

        //Create map
        Cube cube;
        for (int y = 0; y < mapY; y++)
        {
            for (int x = 0; x < mapX; x++)
            {
                cube = new Cube(0,x,y);
                cubeMap[x, y] = cube;
                Instantiate(groundcube, new Vector3(x, 0, y), Quaternion.identity);
            }
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
