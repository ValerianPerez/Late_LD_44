using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    #region Properties
    /// <summary>
    /// Gets or sets the trigger to invoke
    /// </summary>
    /// <returns>UnityAction</returns>
    public UnityEvent OnTrigger;
    #endregion Properties

    #region Unity Built In
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            this.OnTrigger?.Invoke();
        }   
    }
    #endregion Unity Built In
}
