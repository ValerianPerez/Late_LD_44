using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Properties

    /// <summary>
    /// Gets or sets the current game controller
    /// </summary>
    public GameController GameController;

    #endregion Properties

    #region Unity Built In

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    #endregion Unity Built In
}
