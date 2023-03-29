using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseMovement : MonoBehaviour
{

    private Vector2 vectorStartConst;
    public double startXConst;
    public double startYConst;
    private Vector2 vectorEndConst;
    public double endXConst;
    public double endYConst;
    private Vector2 currentPos;

    private float maxDistance;

    private void Update()
    {

    }


    private void Start()
    {

        Debug.Log(Remap(500f, 0, 1441.1f, 0, 100));


        vectorStartConst = GetVector2Coordinate(startXConst, startYConst);
        vectorEndConst = GetVector2Coordinate(endXConst, endYConst);
        maxDistance = Vector2.Distance(vectorStartConst, vectorEndConst);


        PassInHorseData(0, -2.1494445, 52.6032730, 50f);
    }

    public void PassInHorseData(int horseID, double xPos, double yPos, float currentDistance)
    {


        //currentPos = GetVector2Coordinate(-xPos, yPos);
        //float currentDistance = Vector2.Distance(currentPos, vectorEndConst);
        //Debug.Log(currentDistance);
        //Debug.Log(maxDistance);
        //Debug.Log(Remap(currentDistance, 0, 1441.1f, 100, 0));

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

    Vector2 GetVector2Coordinate(double posX, double posY)
    {
        string stringX = posX.ToString();
        string stringY = posY.ToString();

        stringX = stringX.Remove(1, 2);
        stringY = stringY.Remove(0, 3);

        float x = float.Parse(stringX);
        float y = float.Parse(stringY);


        return new Vector2(x, y);
    }

    

}
