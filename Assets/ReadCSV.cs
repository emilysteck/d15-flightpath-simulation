using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCSV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile();
    }

    void ReadCSVFile()
    {
        StreamReader strReader = new StreamReader(""); //need to add file location
        bool endOfFile = false;
        while(!endOfFile){
            string data_String = trReader.ReadLine();
            if(data_String == null){
                endOfFile = true;
                break;
            }
            var data_values = data_String.Split(',');
            Debug.Log(data_values[0].ToString() + " " + data_values[1].ToString() + " " + data_values[2].ToString() + " " + data_values[3].ToString());
        }
    }
}
