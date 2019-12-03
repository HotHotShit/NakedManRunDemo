using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matchvs;

public class Game : UnityContext
{

    public GameObject players;
    // Start is called before the first frame update
    void Start()
    {
       
        this.heartBeat = new HeartBeat(this.heatBeatFunc);
        MatchVSResponseInner.Inst.bindAll(this);
        MatchvsEngine.getInstance().init(this, GameConfig.GameID, GameConfig.AppKey, GameConfig.channel, GameConfig.platform);
        
    }


    public void addPlayer(PlayerInfo playerInfo)
    {

        Debug.Log("  add player ------------------- ");
        Debug.Log(playerInfo);
        Object playerObj = Resources.Load("Player/Man_Mesh", typeof(GameObject));
        GameObject player = Instantiate(playerObj) as GameObject;
        player.transform.parent = players.transform;
        player.transform.localPosition = Vector3.zero;
        PlayerControl ctrl = player.GetComponent<PlayerControl>();
        ctrl.bindUser(playerInfo.UserID);
       
    }

    public int getPlayerCount()
    {
        return players.transform.childCount;
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerInstance.Inst.isStart)
        {
            
            
        }
    }

   
    void heatBeatFunc()
    {
        Debug.Log(" heart beat ");
    }
}
