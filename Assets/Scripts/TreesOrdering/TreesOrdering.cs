using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TreesOrdering : MonoBehaviour
{
    List<Transform> trees;

    // Start is called before the first frame update
    void Start()
    {


        trees = this.GetComponentsInChildren<Transform>().OrderByDescending(e => e.position.y).ToList();
        Debug.Log(trees.Count);

        int order = 0;

        foreach (Transform item in trees)
        {
            if (!item.CompareTag("TreesManagement"))
            {
                item.GetComponent<SpriteRenderer>().sortingOrder = order++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
