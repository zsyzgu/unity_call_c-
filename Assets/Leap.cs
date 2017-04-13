using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Leap : MonoBehaviour {
    const int POINT_NUMBER = 60;

    [DllImport("Leap", EntryPoint = "getInt")]
    private static extern int getInt();

    [DllImport("Leap", EntryPoint = "getIntArray")]
    private static extern IntPtr getIntArray();

    private int[] getHand()
    {
        int[] array = new int[POINT_NUMBER];
        Marshal.Copy(getIntArray(), array, 0, POINT_NUMBER);
        return array;
    }

	void Start () {
        try
        {
            Debug.Log(getInt());
            int[] hand = getHand();
            string output = "";
            for (int i = 0; i < hand.Length; i++)
            {
                output += hand[i] + ", ";
            }
            Debug.Log(output);
        } catch (Exception p)
        {
            Debug.Log(p.ToString());
        }
	}
}
