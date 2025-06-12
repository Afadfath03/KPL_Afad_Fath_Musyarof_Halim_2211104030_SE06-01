using System;
using System.Collections.Generic;

public class PusatDataSingleton
{
    // Atribut
    private List<string> DataTersimpan;
    private static PusatDataSingleton _instance;

    // Konstruktor private
    private PusatDataSingleton() {
        DataTersimpan = new List<string>();
    }

    // Method GetDataSingleton
    public static PusatDataSingleton GetDataSingleton()
    {
        if (_instance == null) _instance = new PusatDataSingleton();
        return _instance;
    }

    // Method GetSemuaData
    public List<string> GetSemuaData() { 
        return DataTersimpan; 
    }

    // Method PrintSemuaData
    public void PrintSemuaData() {
        foreach (string data in DataTersimpan){
            Console.WriteLine(data);
        }
    }

    // Method AddSebuahData
    public void AddSebuahData(string input) {
        DataTersimpan.Add(input);
    }

    // Method HapusSebuahData
    public void HapusSebuahData(int index) {
        if (index >= 0 && index < DataTersimpan.Count) {
            DataTersimpan.RemoveAt(index);
        }
        else {
            Console.WriteLine("Index tidak valid.");
        }
    }
}