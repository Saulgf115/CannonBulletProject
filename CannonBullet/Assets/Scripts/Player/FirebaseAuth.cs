using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FirebaseAuth : MonoBehaviour
{

    public List<Button> button;
    public Text output;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseHelper.OnAuthStateChanged(gameObject.name, "DisplayInfo", "DisplayError");

        button[0].onClick.AddListener(() => GoogleAuth());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayUserInfo(string user)
    {
        //var parsedUser = StringSerializationAPI.Deserialize(typeof(FirebaseUser), user) as FirebaseUser;


    }


    public void GoogleAuth()
    {
        FirebaseHelper.SignInWithGoogle(gameObject.name, "DisplayInfo", "DisplayError");
    }



    public void DisplayInfo(string data)
    {
        output.color = Color.green;
        output.text = data;
        SceneManager.LoadScene("GameScene");
    }

    public void DisplayError(string error)
    {
        output.color = Color.red;
        output.text = error;
    }

}
