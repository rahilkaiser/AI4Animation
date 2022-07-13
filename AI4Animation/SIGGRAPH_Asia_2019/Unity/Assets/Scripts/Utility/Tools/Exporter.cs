using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Winterdust;
#if UNITY_EDITOR
using UnityEditor;
#endif
public class Exporter : MonoBehaviour
{
    public GameObject NewSkeleton;
    public string Path;

	public void Process()
	{
		BVH myBvh = new BVH("C:\\YourFileHere.bvh");
	}
}
