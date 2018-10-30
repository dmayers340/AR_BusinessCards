using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEmail : MonoBehaviour {

    public void EmailToSend()
    {
        string email = "dmayers340@gmail.com";
        string subject = MyEscapeURL("Email After Recieving AR Business Car");
        string body = MyEscapeURL("Here is a quick email to send\r\nIt was great to see your business cards");
        Application.OpenURL("mailto:" + email + "?subject=" + subject + "&body=" + body);
    }
    string MyEscapeURL(string url)
    {
        return WWW.EscapeURL(url).Replace("+", "%20");
    }
}
