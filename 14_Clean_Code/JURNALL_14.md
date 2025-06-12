<div align="center">
JURNAL <br>
KONSTRUKSI PERANGKAT LUNAK <br>
<!-- JUDUL -->
<br>

<img src="https://lac.telkomuniversity.ac.id/wp-content/uploads/2021/01/cropped-1200px-Telkom_University_Logo.svg-270x270.png" width="250px">

<br>

Disusun Oleh: <br>
Afad Fath Musyarof Halim <br>
2211104030 <br>
SE-06-01 <br>

<br>

Asisten Praktikum : <br>
Naufal El Kamil Aditya Pratama Rahman <br>
Imelda Alfiana Palupi Dewi <br>

<br>

Dosen Pengampu : <br>
Yudha Islami Sulistya, S.Kom., M.Cs <br>

<br>

PROGRAM STUDI S1 REKAYASA PERANGKAT LUNAK <br>
FAKULTAS INFORMATIKA <br> 
TELKOM UNIVERSITY PURWOKERTO <br>

</div>
<hr>

``` C#
/// <summary>
/// Represents a centralized data storage using the singleton pattern.
/// </summary>
public class PusatDataSingleton
{
    private List<string> dataTersimpan;
    private static PusatDataSingleton instance;

    /// <summary>
    /// Initializes a new instance of the <see cref="PusatDataSingleton"/> class.
    /// </summary>
    private PusatDataSingleton()
    {
        dataTersimpan = new List<string>();
    }

    /// <summary>
    /// Gets the singleton instance of PusatDataSingleton.
    /// </summary>
    public static PusatDataSingleton GetInstance()
    {
        if (instance == null)
        {
            instance = new PusatDataSingleton();
        }
        return instance;
    }
}
```

<br>
Kode yang di ambil adalah kode JURNAL dari modul 13. Kode sudah baik secara struktur, tetapi kurang dokumentasi