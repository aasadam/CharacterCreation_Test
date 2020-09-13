using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderId : MonoBehaviour
{
    public int Index;
    public CreationController CreationController;

    public void UpdateValue(float value)
    {
        CreationController.UpdateValue(value, Index);
    }
}
