using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeAnchorController : MonoBehaviour
{
    [SerializeField] private List<Transform> Anchor0, Anchor1, Anchor2;
    [SerializeField] Transform gravitySource;

    private void Start()
    {
        if (gravitySource == null) 
        {
            gravitySource = GravitySource.instance.transform;
        }


    }

}
