using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Days", menuName = "ScriptableObject/Days")]
public class MessageDays : ScriptableObject
{
    public List<Messages> Day1 = new List<Messages>();
    public List<Messages> Day2 = new List<Messages>();
    public List<Messages> Day3 = new List<Messages>();
    public List<Messages> Day4 = new List<Messages>();
    public List<Messages> Day5 = new List<Messages>();
    public List<Messages> Day6 = new List<Messages>();
    public List<Messages> Day7 = new List<Messages>();

    private List<List<Messages>> days = new List<List<Messages>>();
    public void Setup()
    {
        days.Add(Day1);
        days.Add(Day2);
        days.Add(Day3);
        days.Add(Day4);
        days.Add(Day5);
        days.Add(Day6);
        days.Add(Day7);

    }
    public List<Messages>getDaysMessages(int day)
    {
        return days[day];
    }
    public void AddMessage(Messages message, int day)
    {
        days[day].Add(message);
    } 
}
