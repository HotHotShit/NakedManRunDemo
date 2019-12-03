using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.IO;
using System.Collections.Generic;

[Serializable]
public class FrameData
{

    public float dx = 0;
    public float dy = 0;
    public float dz = 0;
    public float mx = 0;
    public float my = 0;
}
public class PlayerInstance
{

    private static PlayerInstance instance;
    private PlayerInstance() { }

    public static PlayerInstance Inst
    {
        get
        {
            if (instance == null) instance = new PlayerInstance();
            return instance;
        }
       
    }

    
    public bool isStart = false;
    private uint userID = 0;
    private string token = "";

    public FrameData frameData = new FrameData();


    public List<Vector3> moveDirectionFrames = new List<Vector3>();

   

    public List<Vector2> mouseAxisFrames = new List<Vector2>();


    public uint UserID
    {
        get { return userID; }
        set { userID = value; }
    }

    public string Token
    {
        get { return token; }
        set { token = value; }
    }

    private GameObject player = null;

    public GameObject Player
    {
        get { return player; }
        set {
           
            player = value; 
        }
    }

    public byte[] getFrameDataSerialize()
    {
        BinaryFormatter bf = new BinaryFormatter();
        MemoryStream st = new MemoryStream();
        bf.Serialize(st, frameData);
        byte[] bt = new byte[st.Length];
        st.Read(bt, 0, (int)(st.Length - 1));
        st.Dispose();
        return bt;
    }

}
