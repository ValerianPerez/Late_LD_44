using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : GameController 
{
    #region Properties

    /// <summary>
    /// Gets or sets the theme song
    /// </summary>
    public AudioClip ThemeSong;

    #endregion Properties

    #region Fields

    /// <summary>
    /// Gets or sets the audio source 
    /// </summary>
    private AudioSource audioSource;

    #endregion Fields

    #region Unity Built In

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();

        this.audioSource = this.gameObject.GetComponentInChildren<AudioSource>();

        this.audioSource.clip = this.ThemeSong;

        this.audioSource.loop = true;

        this.audioSource.Play();
    }

    #endregion Unity Built In

}
