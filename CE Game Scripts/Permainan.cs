using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Permainan : MonoBehaviour
{
    public int lanjutLevel;
    public int levelSekarang;
    public GameObject suaraKlik;
    public int banyakKartu = 6;
    public static float skorAkhir;

    public void Ulang()
    {
        Reload();
        SistemKartu.banyakMengulang++;
        SceneManager.LoadScene(levelSekarang);
    }

    public void Keluar()
    {
        SceneManager.LoadScene(0);
        SistemKartu.jumlahSkor = 0;
        SistemKartu.banyakMengulang = 0;
        SistemKartu.jumlahWaktu = 0;
        Reload();
    }
    
    public void Lanjut()
    {
        skorAkhir = SistemKartu.jumlahSkor / ((SistemKartu.banyakMengulang * SistemKartu.jumlahWaktu) + (SistemKartu.jumlahWaktu * 8));
        SceneManager.LoadScene(lanjutLevel);
        Reload();
    }

    public void Reload()
    {
        for (int x = 0; x < banyakKartu; x++)
        {
            gerakan.nomorAnim[x] = 0;
            SistemKartu.score[x] = 0;
        }

        Instantiate(suaraKlik, transform.position, transform.rotation);
        SistemKartu.hasil = 0;
    }

    public void Klik()
    {
        Instantiate(suaraKlik, transform.position, transform.rotation);
    }
}
