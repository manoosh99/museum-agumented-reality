using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour {
    public GameObject PanelVideo;
    public GameObject PanelPic;
    public GameObject Panel;
    public void PaneV()
    {
        if (Panel != null)
        {
            PanelVideo.SetActive(true);
            PanelPic.SetActive(false);
        }
    }
	

public void PanelP()
{
    if (Panel != null)
    {
        PanelVideo.SetActive(false);
        PanelPic.SetActive(true);
    }
}
	
}
