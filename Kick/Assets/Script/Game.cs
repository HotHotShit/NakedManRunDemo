using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Matchvs;

public class Game : UnityContext
{

    public GameObject players;
    
    private List<PlayerControl> playerCtrlList = new List<PlayerControl>();
    // Start is called before the first frame update
    void Start()
    {
       
        this.heartBeat = new HeartBeat(this.heatBeatFunc);
        MatchVSResponseInner.Inst.bindAll(this);
        MatchvsEngine.getInstance().init(this, GameConfig.GameID, GameConfig.AppKey, GameConfig.channel, GameConfig.platform);
        
    }

    public void pushPlayerFrame(FrameDataNotify notify)
    {
       
        playerCtrlList.ForEach((PlayerControl ctrl)=>{
            if (ctrl != null && notify != null && notify.SrcUid == ctrl.getUserID())
            {
                ctrl.playerFrame.decodeFrameData(notify.CpProto);
            }
        });
    }

    public void clearPlayerFrame()
    {
        playerCtrlList.ForEach((PlayerControl ctrl) => {
            if (ctrl != null)
            {
                ctrl.playerFrame.clear();
            }
        });
    }

    public void addPlayer(PlayerInfo playerInfo)
    {

        Debug.Log("  add player ------------------- ");
        Debug.Log(playerInfo);
        Object playerObj = Resources.Load("Player/Man_Mesh", typeof(GameObject));
        GameObject player = Instantiate(playerObj) as GameObject;
        player.transform.parent = players.transform;
        player.transform.localPosition = Vector3.zero;
        player.transform.localPosition += new Vector3(getPlayerCount() * 2, 0, 0);
        PlayerControl ctrl = player.GetComponent<PlayerControl>();
        ctrl.bindUser(playerInfo.UserID);
        playerCtrlList.Add(ctrl);
       
    }

    public int getPlayerCount()
    {
        return players.transform.childCount;
    }
    // Update is called once per frame
    void Update()
    {
       
    }

   
    void heatBeatFunc()
    {
        Debug.Log(" heart beat ");
    }
}
