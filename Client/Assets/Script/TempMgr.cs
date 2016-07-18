using System.Collections;
using UnityEngine;

public class TempMgr : MonoBehaviour
{
    public UITexture m_Pic = null;

    private string m_url = "http://www.fostudio.cn/zhangjia/app_pic/app_pic_3.jpg";

    private IEnumerator Start()
    {
        WWW www = new WWW(m_url);
        yield return www;

        m_Pic.mainTexture = www.texture;
        m_Pic.height = www.texture.height;
        m_Pic.width = www.texture.width;
    }

    private void Update()
    {

    }
}