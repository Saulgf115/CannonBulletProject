using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirebaseUser : MonoBehaviour
{
    public string displayName;

    public string email;

    public bool isAnonymous;

    public bool isEmailVerified;

    public FirebaseUserMetadata metadata;

    public string phoneNumber;

    public FirebaseUserProvider[] providerData;

    public string providerId;

    public string uid;
}
