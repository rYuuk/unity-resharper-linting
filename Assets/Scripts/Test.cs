using UnityEngine;

public class Test
{
    private string Test =;
    
    private const string constantStringWithWrongCase = "ok";

    public string publicStringWithWrongStyle;

    private string PrivateStringWithWrongStyle;

    private string privateStringUnused;

    
    public void Start()
    {
        Debug.Log(publicStringWithWrongStyle);
        Debug.Log(PrivateStringWithWrongStyle);
        Debug.Log(constantStringWithWrongCase);
    }
}
