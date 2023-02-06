using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SaveSystem 
{
    public static void SaveData(Jugador player, int id, string name)
    {
        BinaryFormatter formatter = new ();

        string path = Path(id);

        FileStream stream = new (path, FileMode.Create);
        UserData data = new (player, name);

        try
        {
            //Debug.Log($"Save: {data}{id} -> {data.level}");
            formatter.Serialize(stream, data);
        }
        catch(System.Exception e) {
            Debug.LogException(e);
        }
        stream.Close();
    }
    private static string Path(int id)
    {
        string path = Application.persistentDataPath;
        switch (id)
        {
            case 0:
                path += "\\player1.data";
                break;
            case 1:
                path += "\\player2.data";
                break;
            case 2:
                path += "\\player3.data";
                break;
            case 3:
                path += "\\player4.data";
                break;
        }
        return path;
    }
    public static void EraseData(int id)
    {
        BinaryFormatter formatter = new();

        string path = Path(id);

        FileStream stream = new (path, FileMode.Create);
        UserData data = new ();

        try
        {
            formatter.Serialize(stream, data);
        }
        catch (System.Exception e) 
        {
            Debug.LogException(e);
        }
        stream.Close();
    }

    public static void EraseAllData()
    {
        BinaryFormatter formatter = new ();

        FileStream stream;
        UserData data;

        string path;

        for (int i = 0; i < 4; i++)
        {
            path = Path(i);
            stream = new (path, FileMode.Create);
            data = new ();

            try
            {
                formatter.Serialize(stream, data);
            }
            catch (System.Exception e)
            {
                Debug.LogException(e);
            }

            stream.Close();
        }
    }

     public static void Check()
    {
        BinaryFormatter formatter = new ();

        FileStream stream;
        UserData data;

        string path;

        for (int i = 0; i < 4; i++)
        {
            path = Path(i);

            if(!File.Exists(path))
            {
                data = new ();
                stream = new (path, FileMode.CreateNew);
                formatter.Serialize(stream, data);
                stream.Close();
            }
        }
    }
}
