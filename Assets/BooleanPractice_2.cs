using UnityEngine;

public class BooleanPractice_2 : MonoBehaviour
{
    [SerializeField] string FamilyName;
    [SerializeField] string FirstName;
    [SerializeField] int bornYear;
    [SerializeField] int height;
    [SerializeField] bool isSnoring;

    [SerializeField] bool blalba = false;
    [SerializeField] bool krixkrax = false;


    private void OnValidate()
    {
        blalba = (height > 165 && height < 200 && bornYear >= 2000) && !isSnoring;
        krixkrax = (height < 180 && height !=0) || height > 210 || (FamilyName == FirstName && FamilyName !="" && FirstName !="");
    }

}
