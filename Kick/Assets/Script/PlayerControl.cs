using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Matchvs;

public class PlayerControl : MonoBehaviour
{
    private CharacterController controller;
    public TextMesh IDText;
    public PlayerFrame playerFrame;
    public float gravity =50.0f;
    public float speed = 10;
    public float rotateSense = 1;
    public float jumpSpeed = 12;
    private uint userID = 0;

    public uint getUserID()
    {
        return this.userID;
    }
    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        playerFrame = new PlayerFrame();
        Debug.Log(" player onStart !");
    }

    public void bindUser(uint userID)
    {
        this.userID = userID;
        this.IDText.text = userID.ToString() + ":" + PlayerFrame.gUserID.ToString();
        if (this.userID == PlayerFrame.gUserID)
        {
            PlayerFrame.Player = this.gameObject;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (!PlayerFrame.isStart)
        {
            return;
        }
       
        if (this.userID == PlayerFrame.gUserID)
        {
            bool isDirty = false;
            if (controller.isGrounded)
            {
               
                Vector3 md = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                if (md.x != 0 || md.y != 0 || md.z != 0)
                {
                    playerFrame.frameData.dx = md.x;
                    playerFrame.frameData.dy = md.y;
                    playerFrame.frameData.dz = md.z;


                    Vector3 trmd = transform.TransformDirection(md);
                    playerFrame.frameData.dx = trmd.x;
                    playerFrame.frameData.dy = trmd.y;
                    playerFrame.frameData.dz = trmd.z;


                    playerFrame.frameData.dx *= speed;
                    playerFrame.frameData.dy *= speed;
                    playerFrame.frameData.dz *= speed;

                    isDirty = true;
                }
                if (Input.GetButton("Jump"))
                {
                    playerFrame.frameData.dy += jumpSpeed * Time.deltaTime;
                    isDirty = true;
                }
            } else
            {
                playerFrame.frameData.dy -= Time.deltaTime * gravity;
                isDirty = true;
            }

            if (isDirty)
            {
                PlayerFrame.FrameTime = System.DateTime.Now.Ticks;
                MatchvsEngine.getInstance().sendFrameEvent(playerFrame.getFrameDataSerialize());
            }
           

        }

       
       
        syncTransform();
        
    }

    void syncTransform()
    {
        if (playerFrame.mouseAxisFrames.Count > 0)
        {
            Vector2 mouseAxisFrame = playerFrame.mouseAxisFrames[0];
            if (mouseAxisFrame != null)
            {
                controller.transform.RotateAround(controller.transform.position, Vector3.up, mouseAxisFrame.x * rotateSense);
                controller.transform.RotateAround(controller.transform.position, controller.transform.right, -mouseAxisFrame.y);
                playerFrame.mouseAxisFrames.Remove(mouseAxisFrame);
            }
        }
       
        if (playerFrame.moveDirectionFrames.Count > 0)
        {
           
            Vector3 moveDirectionFrame = playerFrame.moveDirectionFrames[0];
            if (moveDirectionFrame != null)
            {
                controller.Move(moveDirectionFrame * Time.deltaTime);
                playerFrame.moveDirectionFrames.Remove(moveDirectionFrame);
            }
        }
            
    }
}
