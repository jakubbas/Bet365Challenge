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

struct dataNeeded
{
    public int ID;
    public float distanceToEnd;
}

public class HorseDataLoader : MonoBehaviour
{



    FileInfo raceData;
    StreamReader dataReader = null;
    public GameObject[] Horses;

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
        {
            int horseID = int.Parse(data.I.Substring(14));
            Debug.Log("Horse ID: " + horseID);
            Horses[horseID - 1].GetComponent<HorseMovement>().PassInHorseData(data.P);
        }
    }

    public static HorseData LoadData(StreamReader data)
    {
        string readData = data.ReadLine();

        HorseData currentLoaded = JsonUtility.FromJson <HorseData>(readData);

        if (currentLoaded.K == 5 || currentLoaded == null)
        {
            return null;
        }

        return currentLoaded;
    }
}
