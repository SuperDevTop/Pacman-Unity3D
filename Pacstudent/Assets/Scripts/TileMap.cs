using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileMap : MonoBehaviour
{
    int[,] levelMap1 =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 }; 
     int[,] levelMap2 =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 }; 
      int[,] levelMap3 =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 }; 
       int[,] levelMap4 =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 }; 

    

    
    public GameObject zero;
    public GameObject one;
    public GameObject two;
    public GameObject three;
    public GameObject four;
    public GameObject five;
    public GameObject six;
    public GameObject seven;
    public Transform grid;
    // Start is called before the first frame update
    void Start()
    {
        int[,] levelMap = new int[levelMap1.GetLength(0)*2,levelMap1.GetLength(1)*2];
        int[,] temp = new int[levelMap1.GetLength(0),levelMap1.GetLength(1)];
        for(int y = 0; y < levelMap1.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap1.GetLength(1);x++)
            {
                temp[levelMap1.GetLength(0)-1-y, x] = levelMap1[y, x];
            }
        }
        levelMap2 = temp;
        temp = new int[levelMap1.GetLength(0),levelMap1.GetLength(1)];
        for(int y = 0; y < levelMap1.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap1.GetLength(1);x++)
            {
                temp[y,levelMap1.GetLength(1)-1-x] = levelMap1[y, x];
            }
        }
        levelMap3 = temp;
        temp = new int[levelMap2.GetLength(0),levelMap2.GetLength(1)];
        for(int y = 0; y < levelMap2.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap2.GetLength(1);x++)
            {
                temp[y,levelMap2.GetLength(1)-1-x] = levelMap2[y, x];
            }
        }
        levelMap4 = temp;

        for(int y = 0; y < levelMap1.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap1.GetLength(1);x++)
            {
                levelMap[y,x] = levelMap1[y, x];
            }
        }
        for(int y = 0; y < levelMap2.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap2.GetLength(1);x++)
            {
                levelMap[y+levelMap2.GetLength(0),x] = levelMap2[y, x];
            }
        }
        for(int y = 0; y < levelMap3.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap3.GetLength(1);x++)
            {
                levelMap[y,x+levelMap3.GetLength(1)] = levelMap3[y, x];
            }
        }
        for(int y = 0; y < levelMap4.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap4.GetLength(1);x++)
            {
                levelMap[y+levelMap4.GetLength(0),x+levelMap4.GetLength(1)] = levelMap4[y, x];
            }
        }
        for(int y = 0; y < levelMap.GetLength(0);y++)
        {
            for(int x = 0; x < levelMap.GetLength(1);x++)
            {
                switch(levelMap[y,x])
                {
                    case 0:
                        GameObject clone = Instantiate(zero);
                        clone.transform.parent = grid.transform;
                        clone.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        break;

                    case 1:
                        GameObject clone1 = Instantiate(one);
                        clone1.transform.parent = grid.transform;
                        clone1.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        try
                        {
                            if(levelMap[y-1,x] == 2 && levelMap[y,x+1] == 2)
                            {
                                clone1.transform.Rotate(new Vector3(0,0,90));
                            }
                        }
                        catch{}
                        try
                        {
                            if(levelMap[y+1,x] == 2 && levelMap[y,x-1] == 2)
                            {
                                clone1.transform.Rotate(new Vector3(0,0,-90));
                            }
                        }
                        catch{}
                        try
                        {
                            if(levelMap[y-1,x] == 2 && levelMap[y,x-1] == 2)
                            {
                                clone1.transform.Rotate(new Vector3(0,0,180));
                            }
                        }
                        catch{}
                        break;

                    case 2:
                        GameObject clone2 = Instantiate(two);
                        clone2.transform.parent = grid.transform;
                        clone2.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        try
                        {
                            if((levelMap[y,x-1] == 2 || levelMap[y,x-1] == 1) || (levelMap[y,x+1] == 2 || levelMap[y,x+1] == 1))
                            {
                                clone2.transform.Rotate(new Vector3(0,0,-90));
                            }
                        }
                        catch{}
                        break;

                    case 3:
                        GameObject clone3 = Instantiate(three);
                        clone3.transform.parent = grid.transform;
                        clone3.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        try
                        {
                            if((levelMap[y-1,x] == 4 || levelMap[y-1,x] == 3) && (levelMap[y,x+1] == 4 || levelMap[y,x+1] == 3))
                            {
                                clone3.transform.Rotate(new Vector3(0,0,90));
                            }
                        }
                        catch{}
                        try
                        {
                            if((levelMap[y+1,x] == 4 || levelMap[y+1,x] == 3) && (levelMap[y,x-1] == 4 || levelMap[y,x-1] == 3))
                            {
                                clone3.transform.Rotate(new Vector3(0,0,-90));
                            }
                        }
                        catch{}
                        try
                        {
                            if((levelMap[y-1,x] == 4 || levelMap[y-1,x] == 3) && (levelMap[y,x-1] == 4 || levelMap[y,x-1] == 4))
                            {
                                clone3.transform.Rotate(new Vector3(0,0,180));
                            }
                        }
                        catch{}
                         
                        try
                        {
                            if((levelMap[y-1,x] == 3))
                            {
                                clone3.transform.Rotate(new Vector3(0,0,90));
                            }
                        }
                        catch{}
                        try
                        {
                            if(levelMap[y+1,x] == 3)
                            {
                                clone3.transform.Rotate(new Vector3(0,0,-90));
                            }
                        }
                        catch{}
                        try
                        {
                            if(levelMap[y-1,x] == 3)
                            {
                                clone3.transform.Rotate(new Vector3(0,0,180));
                            }
                        }
                        catch{}
                        break;
                        
                    case 4:
                        GameObject clone4 = Instantiate(four);
                        clone4.transform.parent = grid.transform;
                        clone4.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        try
                        {
                            if((levelMap[y,x-1] == 3 || levelMap[y,x-1] == 4) || (levelMap[y,x+1] == 3 || levelMap[y,x+1] == 4))
                            {
                                clone4.transform.Rotate(new Vector3(0,0,-90));
                            }
                        }
                        catch
                        {

                        }
                        break;

                    case 5:
                        GameObject clone5 = Instantiate(five);
                        clone5.transform.parent = grid.transform;
                        clone5.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        break;

                    case 6:
                        GameObject clone6 = Instantiate(six);
                        clone6.transform.parent = grid.transform;
                        clone6.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        break;

                    case 7:
                        GameObject clone7 = Instantiate(seven);
                        clone7.transform.parent = grid.transform;
                        clone7.transform.position = new Vector2(x - 8.5f, (y-4.5f) * -1);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}

