using UnityEngine;
using TMPro;

public class PlantCountUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _plantedText;
    [SerializeField] private TMP_Text _remainingText;

    public void UpdateSeeds (int seedsLeft, int seedsPlanted)
    {
        //changes the text based on how many seeds are left and were planted 
        //since seedsLeft and seedsPlanted are ints, they couldn't be used on their own, so a string was added in front of it (the space)
        _plantedText.text = " " + seedsPlanted;
        _remainingText.text = " " + seedsLeft;
    }
}