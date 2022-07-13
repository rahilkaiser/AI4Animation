using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Winterdust;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class Skinning : MonoBehaviour
{
    public GameObject NewSkeleton;
    public float BendRange = 0.25f;
    public float BendFactor = 0.25f;

    public GameObject anuHips;
    public GameObject anuChest;
    public GameObject anuChest2;
    public GameObject anuChest3;
    public GameObject anuChest4;
    public GameObject anuNeck;
    public GameObject anuHead;

    public GameObject anuRightCollar;
    public GameObject anuRightShoulder;
    public GameObject anuRightElbow;
    public GameObject anuRightWrist;
    public GameObject anuRightTip;
    public GameObject anuLeftCollar;
    public GameObject anuLeftShoulder;
    public GameObject anuLeftElbow;
    public GameObject anuLeftWrist;
    public GameObject anuLeftTip;
    public GameObject anuRightHip;
    public GameObject anuRightKnee;
    public GameObject anuRightAnkle;
    public GameObject anuRightToe;
    public GameObject anuLeftHip;
    public GameObject anuLeftKnee;
    public GameObject anuLeftAnkle;
    public GameObject anuLeftToe;


    //Skeleton generated from NeuralRig
    public GameObject neHips;
    public GameObject neChest;
    public GameObject neChest2;
    public GameObject neChest3;
    public GameObject neChest4;
    public GameObject neNeck;
    public GameObject neHead;
    public GameObject neRightCollar;
    public GameObject neRightShoulder;
    public GameObject neRightElbow;
    public GameObject neRightWrist;
    public GameObject neRightTip;
    public GameObject neLeftCollar;
    public GameObject neLeftShoulder;
    public GameObject neLeftElbow;
    public GameObject neLeftWrist;
    public GameObject neLeftTip;
    public GameObject neRightHip;
    public GameObject neRightKnee;
    public GameObject neRightAnkle;
    public GameObject neRightToe;
    public GameObject neLeftHip;
    public GameObject neLeftKnee;
    public GameObject neLeftAnkle;
    public GameObject neLeftToe;


    public void Retarget()
    {
        // AnuHips existiert immer ... Prüfen, ob Ne Hips existiert
        if (this.neHips != null)
        {
            this.anuHips.transform.position = this.neHips.transform.position;
            // this.SourceHips.transform.SetPositionAndRotation(this.SourceHips.transform.position, Quaternion.Euler(0,-90,0));
        }
        this.resetRotations();
        this.retargetSpine();
        this.retargetLeftArm();
        this.retargetRightArm();
        this.retargetRightHip();
        this.retargetLeftHip();
        
        Debug.Log("Finished");
    }

    private void retargetRightHip()
    {
        if (this.neRightHip != null)
        {
            this.anuRightHip.transform.position = this.neRightHip.transform.position;
        }

        if (this.neRightKnee != null)
        {
            this.anuRightKnee.transform.position = this.neRightKnee.transform.position;
        }

        if (this.neRightAnkle != null)
        {
            this.anuRightAnkle.transform.position = this.neRightAnkle.transform.position;
        }

        if (this.neRightToe != null)
        {
            this.anuRightToe.transform.position = this.neRightToe.transform.position;
        }
    }

    private void retargetLeftHip()
    {
        if (this.neLeftHip != null)
        {
            this.anuLeftHip.transform.position = this.neLeftHip.transform.position;
        }

        if (this.neLeftKnee != null)
        {
            this.anuLeftKnee.transform.position = this.neLeftKnee.transform.position;
        }

        if (this.neLeftAnkle != null)
        {
            this.anuLeftAnkle.transform.position = this.neLeftAnkle.transform.position;
        }

        if (this.neLeftToe != null)
        {
            this.anuLeftToe.transform.position = this.neLeftToe.transform.position;
        }
    }



    private void resetRotations()
    {
        this.anuHips.transform.SetPositionAndRotation(this.anuHips.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightHip.transform.SetPositionAndRotation(this.anuRightHip.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightKnee.transform.SetPositionAndRotation(this.anuRightKnee.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightAnkle.transform.SetPositionAndRotation(this.anuRightAnkle.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightToe.transform.SetPositionAndRotation(this.anuRightToe.transform.position, Quaternion.Euler(0,0,0));
        
        this.anuLeftHip.transform.SetPositionAndRotation(this.anuLeftHip.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftKnee.transform.SetPositionAndRotation(this.anuLeftKnee.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftAnkle.transform.SetPositionAndRotation(this.anuLeftAnkle.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftToe.transform.SetPositionAndRotation(this.anuLeftToe.transform.position, Quaternion.Euler(0,0,0));
        
        
        this.anuChest.transform.SetPositionAndRotation(this.anuChest.transform.position, Quaternion.Euler(0,0,0));
        this.anuChest2.transform.SetPositionAndRotation(this.anuChest2.transform.position, Quaternion.Euler(0,0,0));
        this.anuChest3.transform.SetPositionAndRotation(this.anuChest3.transform.position, Quaternion.Euler(0,0,0));
        this.anuChest4.transform.SetPositionAndRotation(this.anuChest4.transform.position, Quaternion.Euler(0,0,0));
        this.anuNeck.transform.SetPositionAndRotation(this.anuNeck.transform.position, Quaternion.Euler(0,0,0));
        this.anuHead.transform.SetPositionAndRotation(this.anuHead.transform.position, Quaternion.Euler(0,0,0));
      
        
        this.anuRightCollar.transform.SetPositionAndRotation(this.anuRightCollar.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightShoulder.transform.SetPositionAndRotation(this.anuRightShoulder.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightElbow.transform.SetPositionAndRotation(this.anuRightElbow.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightWrist.transform.SetPositionAndRotation(this.anuRightWrist.transform.position, Quaternion.Euler(0,0,0));
        this.anuRightTip.transform.SetPositionAndRotation(this.anuRightTip.transform.position, Quaternion.Euler(0,0,0));
        
        this.anuLeftCollar.transform.SetPositionAndRotation(this.anuLeftCollar.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftShoulder.transform.SetPositionAndRotation(this.anuLeftShoulder.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftElbow.transform.SetPositionAndRotation(this.anuLeftElbow.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftWrist.transform.SetPositionAndRotation(this.anuLeftWrist.transform.position, Quaternion.Euler(0,0,0));
        this.anuLeftTip.transform.SetPositionAndRotation(this.anuLeftTip.transform.position, Quaternion.Euler(0,0,0));
        
        
    }
    private void retargetSpine()
    {

        this.anuChest.transform.position = this.neChest.transform.position;
    
        //Interpolate between CHest and Neck
        if (this.neChest2 != null)
        {
            this.anuChest2.transform.position = this.neChest2.transform.position;
        }
        else
        {
            
            float xd = this.neChest4.transform.position.x - this.anuChest.transform.position.x;
            float yd = this.neChest4.transform.position.y - this.anuChest.transform.position.y;
            float zd = this.neChest4.transform.position.z - this.anuChest.transform.position.z;

            float x0 = (xd * 0.33f) + this.anuChest.transform.position.x;
            float y0 = (yd * 0.33f) + this.anuChest.transform.position.y;
            float z0 = (zd * 0.33f) + this.anuChest.transform.position.z;
            
            // float xd = 0.33f * this.neChest4.transform.position.x + this.anuChest.transform.position.x;
            // float yd = 0.33f * this.neChest4.transform.position.y + this.anuChest.transform.position.y;
            // float zd = 0.33f * this.neChest4.transform.position.z + this.anuChest.transform.position.z;
            
            Debug.Log("X: " + xd);
            Debug.Log("Y: " + yd);
            Debug.Log("Z: " + zd);
            
            this.anuChest2.transform.position = new Vector3(x0, y0, z0);
        }
        
        
        if (this.neChest3 != null)
        {
            this.anuChest3.transform.position = this.neChest3.transform.position;
        }
        else
        {
            float xd = this.neChest4.transform.position.x - this.anuChest.transform.position.x;
            float yd = this.neChest4.transform.position.y - this.anuChest.transform.position.y;
            float zd = this.neChest4.transform.position.z - this.anuChest.transform.position.z;

            float x0 = (xd * 0.66f) + this.anuChest.transform.position.x;
            float y0 = (yd * 0.66f) + this.anuChest.transform.position.y;
            float z0 = (zd * 0.66f) + this.anuChest.transform.position.z;
            
            this.anuChest3.transform.position = new Vector3(x0, y0, z0);
        }
        
        this.anuChest4.transform.position = this.neChest4.transform.position;
        this.anuNeck.transform.position = this.neNeck.transform.position;

        if (this.neHead != null)
        {
            this.anuHead.transform.position = this.neHead.transform.position;
        }
    }

    private void retargetLeftArm()
    {
        if (this.neLeftCollar != null)
        {
            this.anuLeftCollar.transform.position = this.neLeftCollar.transform.position;
        }

        if (this.neLeftShoulder != null)
        {
            this.anuLeftShoulder.transform.position = this.neLeftShoulder.transform.position;
        }

        if (this.neLeftElbow != null)
        {
            this.anuLeftElbow.transform.position = this.neLeftElbow.transform.position;
        }

        if (this.neLeftWrist != null)
        {
            this.anuLeftWrist.transform.position = this.neLeftWrist.transform.position;
        }

        if (this.neLeftTip != null)
        {
            this.anuLeftTip.transform.position = this.neLeftTip.transform.position;
        }
    }

    private void retargetRightArm()
    {
        if (this.neRightCollar != null)
        {
            this.anuRightCollar.transform.position = this.neRightCollar.transform.position;
        }

        if (this.neRightShoulder != null)
        {
            this.anuRightShoulder.transform.position = this.neRightShoulder.transform.position;
        }

        if (this.neRightElbow != null)
        {
            this.anuRightElbow.transform.position = this.neRightElbow.transform.position;
        }

        if (this.neRightWrist != null)
        {
            this.anuRightWrist.transform.position = this.neRightWrist.transform.position;
        }

        if (this.neRightTip != null)
        {
            this.anuRightTip.transform.position = this.neRightTip.transform.position;
        }
    }

    public void Process()
    {
        string[] bones = GetComponent<Actor>() != null ? GetComponent<Actor>().GetBoneNames() : null;
        GameObject.DestroyImmediate(GetComponent<MeshSkinnerDebugWeights>());
        GameObject skeleton = Instantiate(NewSkeleton);
        skeleton.name = "Instance";
        new MeshSkinner(gameObject, skeleton).work(BendRange, BendFactor).debug().finish();
        GameObject.DestroyImmediate(FindSkeleton());
        skeleton.name = "Skeleton";
        Cleanup(skeleton.transform);
        GetComponent<MeshSkinnerDebugWeights>().enabled = false;
        if (GetComponent<Actor>() != null)
        {
            GetComponent<Actor>().ExtractSkeleton(bones);
        }


        Debug.Log("PROCESS");
    }

    private GameObject FindSkeleton()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).name.Contains("Skeleton"))
            {
                return transform.GetChild(i).gameObject;
            }
        }

        return null;
    }

    private void Cleanup(Transform transform)
    {
        Component[] c = transform.GetComponents<Component>();
        for (int i = 0; i < c.Length; i++)
        {
            if (!(c[i] is Transform))
            {
                GameObject.DestroyImmediate(c[i]);
            }
        }

        for (int i = 0; i < transform.childCount; i++)
        {
            Cleanup(transform.GetChild(i));
        }
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(Skinning))]
    public class Skinning_Editor : Editor
    {
        public Skinning Target;

        void Awake()
        {
            Target = (Skinning)target;
        }

        public override void OnInspectorGUI()
        {
            Undo.RecordObject(Target, Target.name);

            DrawDefaultInspector();
            if (GUILayout.Button("Process"))
            {
                Target.Process();
            }

            if (GUILayout.Button("Retarget"))
            {
                Target.Retarget();
            }

            if (GUI.changed)
            {
                EditorUtility.SetDirty(Target);
            }
        }
    }
#endif
}