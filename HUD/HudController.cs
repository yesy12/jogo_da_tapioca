using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudController : MonoBehaviour{

    [Header("-------------------------------------------Start Time-------------------------------------------")]
    public GameObject TimePanel;

    [Header("---Day Normal---")]

    public Slider dayNormalSelector;
    public TMP_Text dayNormalText;

    [Header("---Day After Holiday---")]
    public Slider dayAfterHolidaySelector;
    public TMP_Text dayAfterHolidayText;

    [Header("---Day Before Holiday---")]
    public Slider dayBeforeHolidaySelector;
    public TMP_Text dayBeforeHolidayText;

    [Header("---Day of Holiday---")]
    public Slider dayHolidaySelector;
    public TMP_Text dayHolidayText;

    // [Header("------------------------")]

    void Awake(){
        // TimePanel.SetActive(false);
        dayNormalText.text =  "24";
    }
    
    void Start(){
        
    }

    void FixedUpdate(){

        updateHourOnTextsOnString(dayNormalSelector, dayNormalText);
        updateHourOnTextsOnString(dayAfterHolidaySelector, dayAfterHolidayText);
        updateHourOnTextsOnString(dayBeforeHolidaySelector, dayBeforeHolidayText);
        updateHourOnTextsOnString(dayHolidaySelector, dayHolidayText);
    } 

    void updateHourOnTextsOnString(Slider getNumberFromSlider,TMP_Text whereOnChangeNumberText){
        whereOnChangeNumberText.text = getNumberFromSlider.value.ToString();
    }

}
