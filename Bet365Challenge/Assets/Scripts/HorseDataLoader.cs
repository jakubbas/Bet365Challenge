using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class HorseData
{
    public int K;

    //Time
    public string T;

    //ID
    public string I;

    //Position
    public double X, Y;

    public float V;

    //Distance Till End
    public float P;

    public float SF;
}


public class HorseDataLoader : MonoBehaviour
{
    struct dataNeeded
    {
        int ID;
        double posX, posY;
        float distanceToEnd;
    }



    FileInfo raceData;
    StreamReader dataReader = null;

    private void Start()
    {
        raceData = new FileInfo("Assets/Files/58202301211800.txt");
        dataReader = raceData.OpenText();
        //LoadData(dataReader);
    }

    private void Update()
    {
        HorseData data = LoadData(dataReader);
        if (data != null)
        Debug.Log(data.K + " | " + data.T + " | " + data.I + " | " + data.X + " | " + data.Y + " | " + data.V + " | " + data.P + " | " + data.SF);
    }

    public static HorseData LoadData(StreamReader data)
    {
        string readData = data.ReadLine();
        //Debug.Log(readData);
        //readData = JsonUtility.ToJson(readData);
        HorseData currentLoaded = JsonUtility.FromJson <HorseData>(readData);

        return currentLoaded;
    }
}
