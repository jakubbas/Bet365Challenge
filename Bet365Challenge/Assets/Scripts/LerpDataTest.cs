using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDataTest : MonoBehaviour
{
    double posX;
    double posY;

    double endX;
    double endY;

    // Start is called before the first frame update
    void Start()
    {
        posX = -2.1405885;
        posY = 52.6051042;

        //posX = -2.1419724;
        //posY = 52.6039755;

        endX = -2.1422225;
        endY = 52.6038468;




        Vector2 currentPos = GetVector2Coordinate(posX, posY);
        Vector2 endPos = GetVector2Coordinate(endX, endY);

        //float distance = 

        //currentPos = currentPos / 1000;
        //endPos = endPos / 1000;

    }

    public float Remap(float from, float fromMin, float fromMax, float toMin, float toMax)
    {
        var fromAbs = from - fromMin;
        var fromMaxAbs = fromMax - fromMin;

        var normal = fromAbs / fromMaxAbs;

        var toMaxAbs = toMax - toMin;
        var toAbs = toMaxAbs * normal;

        var to = toAbs + toMin;

        return to;
    }



    // Update is called once per frame
    void Update()
    {
        //Vector2.Lerp(new Vector2(posX, posY), endX, endY, Time.deltaTime);
    }



    Vector2 GetVector2Coordinate(double posX, double posY)
    {
        string stringX = posX.ToString();
        string stringY = posY.ToString();

        stringX = stringX.Remove(1, 2);
        stringY = stringY.Remove(0, 3);

        float x = float.Parse(stringX);
        float y = float.Parse(stringY);


        return new Vector2(x,y);
    }
}
