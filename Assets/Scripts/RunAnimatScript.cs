using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnimatScript : MonoBehaviour
{
    public float speed;

    private SkinnedMeshRenderer meshRender;
    private float value;
    private bool CheckProgress;

    // Start is called before the first frame update
    void Start()
    {
        meshRender = this.GetComponent<SkinnedMeshRenderer>();
        CheckProgress = true;
        value = 0f;
    }

    void Update()
    {
        if (value >= 100f)
        {
            CheckProgress = false;
        }
        else if (value <= 0f)
        {
            CheckProgress = true;
        }

        if (CheckProgress)
        {
            value += speed * Time.deltaTime;
        }
        else
        {
            value -= speed * Time.deltaTime;
        }
        meshRender.SetBlendShapeWeight(0, value);
    }
}
