using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    #region Unity Built In

    // Start is called before the first frame update
    public virtual void Start()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().GameController = this;
    }

    #endregion Unity Built In
}
