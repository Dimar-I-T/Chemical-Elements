using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class skorAkhir : MonoBehaviour
{
    public Text skor;
    public Text kesimpulanTeks;
    float skorAkhirr;
    string grade;
    string kesimpulan;
    public GameObject suaraKlik;

    public void Update()
    {
        skorAkhirr = SistemKartu.jumlahSkor * 100000 / ((SistemKartu.banyakMengulang * SistemKartu.jumlahWaktu) + (SistemKartu.jumlahWaktu * 8));

        if (skorAkhirr >= 9000 && skorAkhirr <= 500000)
        {
            if (SistemKartu.banyakMengulang >= 4)
            {
                kesimpulan = "Kamu banyak mengulang";
                grade = "C";
            }
            else
            {
                grade = "A";
            }
        } 
        else if (skorAkhirr >= 5000 && skorAkhirr < 30000)
        {
            if (SistemKartu.banyakMengulang >= 4)
            {
                kesimpulan = "Kamu banyak mengulang";
                grade = "C";
            }
            else
            {
                grade = "B";
            }
        }else if (skorAkhirr < 5000)
        {
            grade = "C";
        }

        if (SistemKartu.jumlahWaktu >= 1100 && SistemKartu.banyakMengulang < 5)
        {
            kesimpulan = "Kamu terlalu lama";
        }else if (SistemKartu.jumlahWaktu < 1100 && SistemKartu.banyakMengulang < 2)
        {
            kesimpulan = "Keren!";
        }else if (SistemKartu.banyakMengulang >= 4)
        {
            kesimpulan = "Kamu banyak mengulang";
        }

        skor.text = "Skor Akhirmu: " + skorAkhirr.ToString("F0") + " (" + grade + ")";
        kesimpulanTeks.text = kesimpulan;
    }

    public void Keluar()
    {
        SceneManager.LoadScene(0);
        skorAkhirr = 0;
        grade = " ";
        kesimpulan = " ";
    }

    public void Klik()
    {
        Instantiate(suaraKlik, transform.position, transform.rotation);
    }
}
