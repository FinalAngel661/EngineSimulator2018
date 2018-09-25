using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKHandling : MonoBehaviour
{
    Animator anim;

    public float IKWeight = 1;

    public Transform leftIKTarget;
    public Transform rightIKTarget;

    public Transform hintLeft;
    public Transform hintRight;


    //Foots Variables
    Vector3 lFpos;
    Vector3 rFpos;
    Quaternion lFrot;
    Quaternion rFrot;
    float lFWeight;
    float rFWeight;
    Transform leftFoot;
    Transform rightFoot;
    public float offsetY;
    //

    //Looking Stuff
    public float lookIKweight;
    public float bodyWeight;
    public float headWeight;
    public float eyesWeight;
    public float clampWeight;
    public Transform lookPos;
    //



	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();

        //Foots
        leftFoot = anim.GetBoneTransform(HumanBodyBones.LeftFoot);
        rightFoot = anim.GetBoneTransform(HumanBodyBones.RightFoot);

        lFrot = leftFoot.rotation;
        rFrot = rightFoot.rotation;
        //




    }
	
	// Update is called once per frame
	void Update ()
    {
        RaycastHit leftHit;
        RaycastHit rightHit;

        Vector3 lpos = leftFoot.TransformPoint(Vector3.zero);
        Vector3 rpos = rightFoot.TransformPoint(Vector3.zero);

        if (Physics.Raycast(lpos, -Vector3.up, out leftHit, 1))
        {
            lFpos = leftHit.point;
            lFrot = Quaternion.FromToRotation(transform.up, leftHit.normal) * transform.rotation;
        }

        if (Physics.Raycast(rpos, -Vector3.up, out rightHit, 1))
        {
            rFpos = rightHit.point;
            rFrot = Quaternion.FromToRotation(transform.up, rightHit.normal) * transform.rotation;
        }
    }

    void OnAnimatorIK()
    {
        //Looking IK
        anim.SetLookAtWeight(lookIKweight, bodyWeight, headWeight, eyesWeight, clampWeight);
        anim.SetLookAtPosition(lookPos.position);
        //

        //Feets
        lFWeight = anim.GetFloat("LeftFoot");
        rFWeight = anim.GetFloat("RightFoot");
        anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, lFWeight);
        anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, rFWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftFoot, lFpos + new Vector3(0, offsetY, 0));
        anim.SetIKPosition(AvatarIKGoal.RightFoot, rFpos + new Vector3(0, offsetY, 0));
        //Feets Rotation
        anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, lFWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, rFWeight);
        anim.SetIKRotation(AvatarIKGoal.LeftFoot, lFrot);
        anim.SetIKRotation(AvatarIKGoal.RightFoot, rFrot);
        //

        //Hands
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IKWeight);
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IKWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftHand, leftIKTarget.position);
        anim.SetIKPosition(AvatarIKGoal.RightHand, rightIKTarget.position);
        //Hands Rotation
        anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, IKWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, IKWeight);
        anim.SetIKRotation(AvatarIKGoal.LeftHand, leftIKTarget.rotation);
        anim.SetIKRotation(AvatarIKGoal.RightHand, rightIKTarget.rotation);
        //
    }
}
