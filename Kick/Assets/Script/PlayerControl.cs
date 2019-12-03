using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Matchvs;

public class PlayerControl : MonoBehaviour
{
    private CharacterController controller;
    public float gravity =50.0f;
    public float speed = 10;
    public float rotateSense = 1;
    public float jumpSpeed = 15;
    private uint userID = 0;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.GetComponent<CharacterController>();
        Debug.Log(" player onStart !");
    }

    public void bindUser(uint userID)
    {
        this.userID = userID;
        if (this.userID == PlayerInstance.Inst.UserID)
        {
            PlayerInstance.Inst.Player = this.gameObject;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (this.userID != PlayerInstance.Inst.UserID || !PlayerInstance.Inst.isStart)
        {
            return;
        }

        if (controller.isGrounded)
        {
            Vector3 md = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            PlayerInstance.Inst.frameData.dx = md.x;
            PlayerInstance.Inst.frameData.dy = md.y;
            PlayerInstance.Inst.frameData.dz = md.z;


            Vector3 trmd = transform.TransformDirection(md);
            PlayerInstance.Inst.frameData.dx = trmd.x;
            PlayerInstance.Inst.frameData.dy = trmd.y;
            PlayerInstance.Inst.frameData.dz = trmd.z;


            PlayerInstance.Inst.frameData.dx *= speed;
            PlayerInstance.Inst.frameData.dy *= speed;
            PlayerInstance.Inst.frameData.dz *= speed;
            if (Input.GetButton("Jump"))
            {
                PlayerInstance.Inst.frameData.dy += jumpSpeed;
            }

        }
        PlayerInstance.Inst.frameData.dy -= Time.deltaTime * gravity;
        MatchvsEngine.getInstance().sendFrameEvent(PlayerInstance.Inst.getFrameDataSerialize());
        syncTransform();
        
    }

    void syncTransform()
    {
        Vector2 mouseAxisFrame = PlayerInstance.Inst.mouseAxisFrames[0];
        Vector2 moveDirectionFrame = PlayerInstance.Inst.moveDirectionFrames[0];
        if (mouseAxisFrame != null)
        {
            controller.transform.RotateAround(controller.transform.position, Vector3.up, mouseAxisFrame.x * rotateSense);
            controller.transform.RotateAround(controller.transform.position, controller.transform.right, -mouseAxisFrame.y);
            PlayerInstance.Inst.mouseAxisFrames.Remove(mouseAxisFrame);
        }

        if (moveDirectionFrame != null) {
            controller.Move(moveDirectionFrame * Time.deltaTime);
            PlayerInstance.Inst.moveDirectionFrames.Remove(moveDirectionFrame);
        }
            
    }
}
