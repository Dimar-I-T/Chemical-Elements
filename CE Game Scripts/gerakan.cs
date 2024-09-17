using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerakan : MonoBehaviour
{
    public bool aktif = true;
    public bool upAktif = false;
    public static bool[] ujungAnimAktif = { false, false, false, false, false, false };
    public string[] namaKartu = { "ar", "he", "ne", "rn", "kr", "xe" };
    public static int[] nomorAnim;
    int nomorKartu;
    public int banyakKartu = 6;

    public void Awake()
    {
        nomorAnim = new int[banyakKartu];
    }

    public void Start()
    {
        for (int x = 0; x < banyakKartu; x++)
        {
            if (namaKartu[x] == this.tag)
                nomorKartu = x;
        }
    }

    public void OnMouseDrag()
    {
        if (aktif)
        {
            transform.SetLocalPositionAndRotation(new Vector3((2 * Input.mousePosition.x - Screen.width) / Screen.width,
                                              (2 * Input.mousePosition.y - Screen.height) / Screen.height), transform.rotation);
            upAktif = false;
        }
    }

    public void OnMouseUp()
    {
        upAktif = true;

        /*if (upAktif)
        {
            for (int x = 0; x < 6; x++)
            {
                if (SistemKartu.ujungIndeks[x] == 1)
                {
                    ujungAnimAktif[x] = true;
                }
                else
                {
                    ujungAnimAktif[x] = false;
                }
            }
        }*/

        for (int x = 0; x < banyakKartu; x++)
        {
            if (transform.localPosition.x >= SistemKartu.areaKartu[x][0].localPosition.x &&
                transform.localPosition.x <= SistemKartu.areaKartu[x][1].localPosition.x &&
                transform.localPosition.y <= SistemKartu.areaKartu[x][0].localPosition.y &&
                transform.localPosition.y >= SistemKartu.areaKartu[x][1].localPosition.y)
            {
                aktif = false;
                nomorAnim[x] = 1;
                if (x == nomorKartu)
                {
                    SistemKartu.score[x] = 1;
                }
            }
        }
    }
}
