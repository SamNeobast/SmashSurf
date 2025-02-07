using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLeftRightMovement : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (gameObject.transform.position.x <= 0)
            {
                gameObject.transform.position += new Vector3(3, 0, 0);
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (gameObject.transform.position.x >= 0)
            {
                gameObject.transform.position += new Vector3(-3, 0, 0);
            }
        }
    }
}
