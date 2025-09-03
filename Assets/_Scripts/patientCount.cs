using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class patientCount : MonoBehaviour
{
    public static patientCount instance;
    
    [SerializeField] private int patients;
    public TextMeshProUGUI patient;
    public GameObject message;

    void Start()
    {
        instance = this;
        patients = 0;
    }

    IEnumerator DisplayMessage()
    {
        message.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        message.SetActive(false);
    }

    public void AddPatient(GameObject newPatient)
    {
        if(patients > 0)
            Destroy(newPatient);
        
        
        patients += 1;
        patient.text = "Patients: " + patients.ToString("F0");
        StartCoroutine("DisplayMessage");
    }


    


}
