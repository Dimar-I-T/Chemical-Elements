using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SistemKartu : MonoBehaviour
{
    public int banyakKartuMentah = 6;
    public static int jumlahSkor;
    public static int banyakMengulang;
    public static float jumlahWaktu;
    float waktu;
    public Transform[] areaKartuMentah;
    public static int hasil;
    public static int[] score;
    public TextMeshProUGUI skor;
    public static string[] namaKartu = { "ar", "he", "ne", "rn", "kr", "xe" };
    public GameObject[] ujungAnim, ujungLock;
    public static Transform[][] areaKartu;
    int[] indeks = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
    public static int[] ujungIndeks;
    GameObject[] kartu;
    public GameObject panelSkor;
    public GameObject lanjut;
    int a = 0;

    public void Awake()
    {
        areaKartu = new Transform[banyakKartuMentah][];
        score = new int[banyakKartuMentah];
        kartu = new GameObject[banyakKartuMentah];
    }

    public void Start()
    {
        for (int x = 0; x < banyakKartuMentah; x++)
        {
            kartu[x] = GameObject.FindGameObjectWithTag(namaKartu[x]);
            areaKartu[x] = new Transform[2];

            for (int y = 0; y < 2; y++)
            {
                areaKartu[x][y] = areaKartuMentah[a];
                a = a + 1;
            }
        }
    }

    public void Update()
    {
        waktu += Time.deltaTime;
        /*for (int x = 0; x < 6; x++)
        {
            if (kartu[x].transform.localPosition.x >= areaKartu[x][0].localPosition.x &&
            kartu[x].transform.localPosition.x <= areaKartu[x][1].localPosition.x &&
            kartu[x].transform.localPosition.y <= areaKartu[x][0].localPosition.y &&
            kartu[x].transform.localPosition.y >= areaKartu[x][1].localPosition.y)
            {
                score[x] = 1;
            }
        }*/

        /*for (int x = 0; x < 6; x++)
        {
            for (int y = 0; y < 6; y++)
            {
                if (kartu[x].transform.localPosition.x >= areaKartu[y][0].localPosition.x &&
                kartu[x].transform.localPosition.x <= areaKartu[y][1].localPosition.x &&
                kartu[x].transform.localPosition.y <= areaKartu[y][0].localPosition.y &&
                kartu[x].transform.localPosition.y >= areaKartu[y][1].localPosition.y)
                {
                    Debug.Log(y);
                    ujungIndeks[y] = 1; 
                    if (gerakan.ujungAnimAktif[y] == true)
                    {
                        // if y = x score++
                        if (kartu[y].transform.localPosition.x >= areaKartu[x][0].localPosition.x &&
                            kartu[y].transform.localPosition.x <= areaKartu[x][1].localPosition.x &&
                            kartu[y].transform.localPosition.y <= areaKartu[x][0].localPosition.y &&
                            kartu[y].transform.localPosition.y >= areaKartu[x][1].localPosition.y)
                        {
                            score[x] = 1;
                        }
                        ujungAnim[y].SetActive(true);
                        gerakan aktiff = kartu[x].GetComponent<gerakan>();
                        aktiff.aktif = false;
                    }
                }
                else
                {
                    //ujungIndeks[y] = 0;
                }
            }
        }*/

        for (int x = 0; x < banyakKartuMentah; x++)
        {
            ujungAnim[x].SetActive(gerakan.nomorAnim[x] == 1);
        }
    }

    public void Hitung()
    {
        int benar = 0;

        for (int x = 0; x < score.Length; x++)
        {
            if (score[x] == 1)
                benar++;
        }

        hasil = (benar * 100) / score.Length;
        skor.text = "Skor: " + (benar * 100) / score.Length + " ";
        jumlahSkor += hasil;
        jumlahWaktu += waktu;
        lanjut.SetActive(hasil == 100);
        panelSkor.SetActive(true);
    }
}
