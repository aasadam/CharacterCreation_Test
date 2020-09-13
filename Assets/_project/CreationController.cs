using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class CreationController : MonoBehaviour
{
    public GameObject Character;

    [Range(-100, 100)] public int[] Sliders;


    private SkinnedMeshRenderer _meshRenderer;

    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = Character.GetComponent<SkinnedMeshRenderer>();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < Sliders.Length; i++)
        {
            int value = Sliders[i];

            _meshRenderer.SetBlendShapeWeight(i * 2, value < 0 ? 0 : Mathf.Abs(value));
            _meshRenderer.SetBlendShapeWeight((i * 2) + 1, value > 0 ? 0 : Mathf.Abs(value));
        }
    }

    public void UpdateValue(float value, int index)
    {
        Sliders[index] = Mathf.CeilToInt(value);
    }

    public void Test(string teste)
    {

    }

    [SerializeField]
    public ScrollEvent2 onValueChanged2;

    public class ScrollEvent2 : UnityEvent<float>
    {
    }
}
