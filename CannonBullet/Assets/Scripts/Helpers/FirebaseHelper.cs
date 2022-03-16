using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class FirebaseHelper : MonoBehaviour
{
    [DllImport("__Internal")]
    public static extern void SignInWithGoogle(string objectName,string callback,string fallback);

    [DllImport("__Internal")]
    public static extern void OnAuthStateChanged(string objectName, string onUserSignedIn, string onUserSignedOut);
}
