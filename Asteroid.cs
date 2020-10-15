using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Ast());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Ast()
    {
        yield return new WaitForSeconds(20);
        while (true)
        {
            for (int i = 0; i < 30; i++)
            {
                transform.position += new Vector3(0, 0, -1);
                yield return new WaitForSeconds(1);
            }
            for (int i = 0; i < 30; i++)
            {
                transform.position += new Vector3(0, 0, 1);
                yield return new WaitForSeconds(1);
            }
        }
        }
}
