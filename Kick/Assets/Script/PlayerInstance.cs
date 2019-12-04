using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using System.IO;
using System.Collections.Generic;
using pb = global::Google.Protobuf;
[Serializable]
public class FrameData
{

    public float dx = 0;
    public float dy = 0;
    public float dz = 0;
    public float mx = 0;
    public float my = 0;
}
public class PlayerFrame
{

    public static uint gUserID = 0;
    public static long FrameTime = 0;
    public PlayerFrame() { }

    public static bool isStart = false;
    private uint userID = 0;
    private static string token = "";

    public FrameData frameData = new FrameData();


    public List<Vector3> moveDirectionFrames = new List<Vector3>();

   

    public List<Vector2> mouseAxisFrames = new List<Vector2>();


    public uint UserID
    {
        get { return userID; }
        set { userID = value; }
    }

    public static string Token
    {
        get { return token; }
        set { token = value; }
    }

    private static GameObject player = null;

    public static GameObject Player
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
        st.Position = 0;
        st.Read(bt, 0, (int)(st.Length));
        /*

        MemoryStream st2 = new MemoryStream();

        BinaryFormatter bf2 = new BinaryFormatter();



        st2.Position = 0;
        st2.Write(bt, 0, bt.Length);
        st2.Position = 0;
        Debug.Log(" MemoryStream -- 1 length:" + st2.Length);

        try
        {

            object obj = bf2.Deserialize(st2);
            Debug.Log(" obj :" + obj.ToString());
            FrameData frame = (FrameData)(obj);
            Debug.Log(" frame:" + frame.dx);
        }
        catch (Exception e)
        {
            Debug.LogError(e);
        }
        st2.Close();
        st2.Dispose();

        */
        st.Close();
        st.Dispose();
        return bt;
    }

    public void decodeFrameData(pb::ByteString data)
    {
        if (data.IsEmpty)
        {
            return;
        }

        MemoryStream st = new MemoryStream();

        BinaryFormatter bf = new BinaryFormatter();

        byte[] bt = data.ToByteArray();


        st.Position = 0;
        st.Write(bt, 0, bt.Length);
        st.Position = 0;

        object obj = bf.Deserialize(st);
        FrameData frame = (FrameData)(obj);
        moveDirectionFrames.Add(new Vector3(frame.dx, frame.dy, frame.dz));
        mouseAxisFrames.Add(new Vector2(frame.mx, frame.my));
        
        st.Close();
        st.Dispose();

    }

    public void clear()
    {
        moveDirectionFrames.Clear();
        mouseAxisFrames.Clear();
    }

}
